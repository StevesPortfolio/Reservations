Imports System.IO

'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: Reservation Handling
'Purpose: Functions and subroutines to read and write to Reservations file

Module ReservationHandling

    Public Const Resfile As String = "Reservations.csv"
    Public Reservations(9, 3) As ReservationModel 'Reservations(row, col)
    Public ResList As New List(Of ReservationModel)()

    'Declare boolean variables
    Public ResFileMissing As Boolean
    Public SeatsRemaining As Integer = 40


    ''' <summary>
    ''' Read existing Reservations from file and populate the 
    ''' Reservations array with existing reservations
    ''' </summary>
    Public Function GetReservations() As List(Of ReservationModel)

        'Re-initialise seats remaining counter to known value before reading reservations from file
        SeatsRemaining = 40

        Dim output = New List(Of ReservationModel)

        Try
            ResFileMissing = False
            Dim sr As New StreamReader(Resfile)
            Do While sr.Peek() >= 0
                Dim record As String
                record = sr.ReadLine()
                output.Add(InflateReservation(record))
            Loop
            'Don't forget to close the file
            sr.Close()
        Catch ex As FileNotFoundException
            MessageBox.Show("Reservations file cannot be found. A new Reservations file has been created.",
                            "File Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            'Ensure new Reservations file is created if none already exists
            Dim sw = New StreamWriter(Resfile)
            sw.Close()
        End Try

        'Calculate new seats remaining value
        SeatsRemaining = SeatsRemaining - ResList.Count

        frmMain.lblSeatsRemaining.Text = SeatsRemaining.ToString()

        For Each r As ReservationModel In output
            Reservations(r.SeatRow, r.SeatColumn) = r
        Next

        Return output
    End Function

    ''' <summary>
    ''' Populates list of existing reservations.
    ''' Adds columns to ListView box, and adds each reservation to the list view.
    ''' </summary>
    Public Function PopulateReservationsView(lv As ListView) As ListView
        ResList = GetReservations()
        lv.Clear()
        'Set properties of list view and populate with reservation data
        With lv
            .Columns.Add("Passenger Name", 180, HorizontalAlignment.Left)
            .Columns.Add("Seat", 60, HorizontalAlignment.Left)
            .View = View.Details
            For Each r As ReservationModel In ResList
                .Items.Add(New ListViewItem({r.Passenger.FullName.ToString(), r.Seat.ToString()}))
            Next
        End With

        Return lv

    End Function

    ''' <summary>
    ''' Loop through reservations array and save all existing reservations
    ''' overwriting existing file, if any
    ''' </summary>
    Public Sub SaveReservations()

        Dim sw As StreamWriter = New StreamWriter(Resfile)

        For r = 0 To 9 'Loop through rows
            For c = 0 To 3 'Loop through columns
                If Not String.IsNullOrWhiteSpace(Reservations(r, c).Passenger.FullName) Then
                    'Only save array elements that contain a passenger name. 
                    'Assume elements without a passenger are available seats
                    sw.WriteLine(DeflateReservation(Reservations(r, c)))
                End If
            Next
        Next

        sw.Close()

    End Sub

    ''' <summary>
    ''' Deflates a variable of type ReservationModel into a CSV string
    ''' which can be saved to a text file
    ''' </summary>
    ''' <param name="reservation">Reservation as ReservationModel type</param>
    ''' <returns>String with values separated by "," character</returns>
    Private Function DeflateReservation(reservation As ReservationModel) As String

        'Reservations Record Format:
        'FirstName, LastName,SeatRow, SeatColumn

        Dim output As String

        'Convert ReservationModel to single line of text with fields separated by "," character
        output = reservation.Passenger.Firstname & "," &
            reservation.Passenger.Lastname & "," & reservation.SeatRow & "," &
            reservation.SeatColumn

        Return output

    End Function

    ''' <summary>
    ''' Converts a single line from Reservations CSV file into a ReservationModel type
    ''' </summary>
    ''' <param name="record">Single line of CSV file as string</param>
    ''' <returns>Reservation as ReservationModel type</returns>
    Private Function InflateReservation(record As String) As ReservationModel
        'Reservations Record Format (temprecord()):
        '0 = FirstName, 
        '1 = LastName, 
        '2 = SeatRow, 
        '3 = SeatColumn

        'Create new empty instance of Person type
        Dim p As New PersonModel() With {.Firstname = "", .Lastname = ""}

        'Create new empty instance of Reservation type
        Dim output As New ReservationModel() With {.Passenger = p, .SeatRow = 0, .SeatColumn = 0}

        'Split passed string on "," character, and place in temporary array
        Dim temprecord() As String
        temprecord = Split(record, ","c)

        'Populate reservation with data
        output.Passenger.Firstname = temprecord(0)
        output.Passenger.Lastname = temprecord(1)
        output.SeatRow = CInt(temprecord(2))
        output.SeatColumn = CInt(temprecord(3))

        Return output

    End Function

    ''' <summary>
    ''' Cancels a reservation.
    ''' Overwrites passenger reservation with an empty reservation type
    ''' </summary>
    ''' <param name="seat">String value containing the friendly seat name</param>
    Public Sub CancelReservation(seat As String)
        'Convert seat number to row and column
        Dim row As Integer = ConvertSeatRow(seat.Substring(0, 1))
        Dim col As Integer = CInt(seat.Substring(1, 1).ToString()) - 1

        'Replace passenger in selected seat with a new empty instance of Person type
        Reservations(row, col).Passenger = New PersonModel()

        'Use the seating dictionary to change the colour of the seat to show as now available (light green)
        SeatingButtons.Item(Reservations(row, col).Seat).BackColor = frmMain.lblAvailable.BackColor

        'Add to seats remaining
        SeatsRemaining += 1

        'Save reservations file
        SaveReservations()

        'If there are people waiting for reservations
        If File.Exists(WaitFile) Then
            Dim result = MessageBox.Show("Reservation has been canceled. Would you like to move the first person on the waiting list into the vacated seat?",
                                         "Reservation Canceled", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                MoveNextWaitingToFlight(row, col)
            End If

        End If

            'Update Reservations array from file
            ResList = GetReservations()



    End Sub

    ''' <summary>
    ''' Add a reservation to the reservations file and update the seating chart 
    ''' to show the selected seat as reserved (light red)
    ''' </summary>
    ''' <param name="p"> Passenger for the reservation as Person type</param>
    ''' <param name="seatNumber">Friendly seat number as string</param>
    Public Sub MakeReservation(p As PersonModel, seatNumber As String)

        'If there are seats available, make reservation
        If SeatsRemaining > 0 And Not String.IsNullOrWhiteSpace(seatNumber) Then
            Dim row, col As Integer
            'Create new empty reservation
            Dim r As New ReservationModel()

            'Convert friendly seat number into row and column of reservations array
            row = ConvertSeatRow(seatNumber.Substring(0, 1))
            col = CInt(seatNumber.Substring(1, 1)) - 1 'Be sure to subtract 1 to compensate for zero-based array

            'Only allow reservation if seat is available
            If String.IsNullOrWhiteSpace(Reservations(row, col).Passenger.FullName) Then
                'Populate reservation with passenger and seat details
                r.Passenger = p
                r.SeatRow = row
                r.SeatColumn = col

                'Add reservation to the correct position in the reservations array
                Reservations(row, col) = r
                'Change seat colour to indicate seat reserved
                SeatingButtons.Item(Reservations(row, col).Seat).BackColor = frmMain.lblReserved.BackColor
                'Save and overwrite the reservations file
                SaveReservations()

                'Regenerate reservations array from file (also refreshes seating chart)
                ResList = GetReservations()
                With frmMain
                    'Clear Reservation info from form
                    .txtFirstName.Text = ""
                    .txtLastName.Text = ""
                    .lblSeat.Text = ""
                End With
            Else
                MessageBox.Show("The seat you have chosen is already occupied. Please select an available seat",
                                "Seat not available", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Clear Seat number from form
                frmMain.lblSeat.Text = ""
            End If
        Else
            'Add person to Waiting List

            'If no seats remaining
            If SeatsRemaining < 1 Then
                AddToWaitingList(p)
                MessageBox.Show("There are no more available seats. You have been added to the waiting list",
                                "Add to Waiting List", MessageBoxButtons.OK)
                With frmMain
                    'Clear Reservation info from form
                    .txtFirstName.Text = ""
                    .txtLastName.Text = ""
                    .lblSeat.Text = ""
                End With

            ElseIf String.IsNullOrWhiteSpace(seatNumber) Then
                'If seats are remaining, but a seat has not been selected
                Dim result As Integer = MessageBox.Show("You have not selected a seat number. Would you like to be added to the waiting list?",
                                                        "No Seat Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    AddToWaitingList(p)
                    MessageBox.Show("You have been added to the waiting list", "Add to Waiting List", MessageBoxButtons.OK)
                    With frmMain
                        'Clear Reservation info from form
                        .txtFirstName.Text = ""
                        .txtLastName.Text = ""
                        .lblSeat.Text = ""
                    End With
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Please select an available seat to complete your reservation", "Please select a seat", MessageBoxButtons.OK)
                End If
            End If

        End If


    End Sub


End Module
