
'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: Tools
'Purpose: Contains general purpose code that can be used by other forms or modules

Module Tools

    Private IsReserved As Boolean = False

    'Declare dictionary to manipulate buttons used to draw seating chart
    Public SeatingButtons As Dictionary(Of String, Button) = New Dictionary(Of String, Button)


    ''' <summary>
    ''' Loops through the seating chart array, and adds a button for each seat.
    ''' Button can be clicked to give seat location for reservations.
    ''' Button background colour indicates seat availability. 
    ''' Light Green = Available
    ''' Light Red = Reserved
    ''' </summary>
    Public Sub DrawSeatingChart()
        'Loop through 2d array and create a button for each seat
        For cols As Integer = 0 To 3
            For rows As Integer = 0 To 9
                'Reset reserved flag to false
                IsReserved = False
                If Not ResFileMissing Then
                    If Not String.IsNullOrEmpty(Reservations(rows, cols).Passenger.Lastname) Then
                        IsReserved = True
                    End If
                End If
                'Ensure starting with a clean seat letter
                Dim seatletter As String = ""
                seatletter = ConvertSeatRow(rows)
                'Create new button and set properties
                Dim b As New Button
                'Set button properties
                With b
                    'If seat is reserved, make it reserved colour on seating plan
                    If IsReserved Then
                        .BackColor = frmMain.lblReserved.BackColor
                    Else
                        'otherwise make it available colour
                        .BackColor = frmMain.lblAvailable.BackColor
                    End If
                    .FlatStyle = FlatStyle.Flat
                    .Text = seatletter + (cols + 1).ToString
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Width = 50
                    .Height = 50
                End With
                'Add button to dictionary
                SeatingButtons.Add(b.Text, b)
                'Track button in dictionary by tag
                b.Tag = seatletter + (cols + 1).ToString()
                'Add button to seating chart
                frmMain.tlpSeatingChart.Controls.Add(b, cols, rows)
                'Add OnClick event handler for button. Each button uses same event handler
                AddHandler b.Click, AddressOf frmMain.SeatingChart_Click
            Next
        Next

    End Sub

    ''' <summary>
    ''' Initialise the Reservations array by placing a blank passenger into
    ''' each element, and setting the seat numbers
    ''' </summary>
    Public Sub InitializeReservationArray()

        'Fill Reservations array with new empty reservations
        For rows = 0 To 9
            For cols = 0 To 3
                Dim p As New PersonModel() With {.Firstname = "", .Lastname = ""}
                Dim r As New ReservationModel() With {.SeatColumn = cols, .SeatRow = rows, .Passenger = p}
                Reservations(rows, cols) = r
            Next
        Next
    End Sub

    ''' <summary>
    ''' Converts the seat row into an alpha character, so seat number can be
    ''' presented in the format of "A7" or "H10", etc.
    ''' </summary>
    ''' <param name="rownumber">Row number of the reservation as an integer</param>
    ''' <returns>String representing the letter of the row</returns>
    Public Function ConvertSeatRow(rownumber As Integer) As String
        Dim output As String = ""
        'Convert Seat into Alpha row and Numeric column format
        'NOTE: No need for a Case Else as this is controlled by hard coded array
        Select Case rownumber
            Case 0
                output = "A"
            Case 1
                output = "B"
            Case 2
                output = "C"
            Case 3
                output = "D"
            Case 4
                output = "E"
            Case 5
                output = "F"
            Case 6
                output = "G"
            Case 7
                output = "H"
            Case 8
                output = "I"
            Case 9
                output = "J"
        End Select

        Return output
    End Function

    ''' <summary>
    ''' Converts Seat row from a letter to an integer for storage in array.
    ''' </summary>
    ''' <param name="rowletter">Letter component of the seat number as a string</param>
    ''' <returns>Integer value representing the seat's position in the array row</returns>
    Public Function ConvertSeatRow(rowletter As String) As Integer

        Dim output As Integer = 0

        'Ensure we are working with an upper case letter
        rowletter = rowletter.ToUpper()

        'Convert alpha character to an integer
        Select Case rowletter
            Case "A"
                output = 0
            Case "B"
                output = 1
            Case "C"
                output = 2
            Case "D"
                output = 3
            Case "E"
                output = 4
            Case "F"
                output = 5
            Case "G"
                output = 6
            Case "H"
                output = 7
            Case "I"
                output = 8
            Case "J"
                output = 9
        End Select

        Return output

    End Function

    ''' <summary>
    ''' Populate the waiting list from file
    ''' </summary>
    Public Function PopulateWaitingList(lv As ListView) As ListView

        'Get people from Waiting list and store in array
        WaitList = GetWaitingList()
        lv.Clear()
        'Set properties of List view and populate data
        With lv
            .Columns.Add("Passenger Name", 180, HorizontalAlignment.Left)
            .View = View.Details
            For Each p As PersonModel In WaitList
                .Items.Add(New ListViewItem(p.FullName))
            Next

        End With

        'Return populated list view
        Return lv

    End Function

    ''' <summary>
    ''' Move first person on the Waiting List to the newly vacated seat
    ''' </summary>
    ''' <param name="row">Integer giving the row of the seat in the reservations array 
    ''' to allocate to the person on the waiting list</param>
    ''' <param name="col">Integer giving the column of the seat in the reservations array
    ''' to allocate to the person on the waiting list</param>
    Public Sub MoveNextWaitingToFlight(row As Integer, col As Integer)

        Reservations(row, col).Passenger = WaitList.First()
        ResList.Add(Reservations(row, col))
        WaitList.RemoveAt(0)
        SeatingButtons.Item(Reservations(row, col).Seat).BackColor = frmMain.lblReserved.BackColor
        SaveReservations()
        SaveWaitingList()

    End Sub


End Module
