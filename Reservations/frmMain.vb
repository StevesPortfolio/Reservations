Imports System.String

'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 2 April, 2018
'Module: Menu
'Purpose: Accepts passenger details and controls program flow

Public Class frmMain

    Private seatNumber As String


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Clear seat number label
        lblSeat.Text = ""
        InitializeReservationArray()
        ResList = GetReservations()
        WaitList = GetWaitingList()
        'Initialise seating chart and mark current reservations
        DrawSeatingChart()
        btnAddReservation.Enabled = False
        lvCurrentReservations = PopulateReservationsView(lvCurrentReservations)

    End Sub

    Public Sub SeatingChart_Click(sender As Object, e As EventArgs)

        'Work out which seat the user has selected and populate the Seat Number box
        seatNumber = Strings.Right(sender.ToString(), 2)
        'Convert the seat number into the correct Row and Column of the Reservations array
        Dim seatrow As Integer = ConvertSeatRow(seatNumber.Substring(0, 1))
        Dim seatcol As Integer = CInt(Strings.Right(seatNumber, 1).ToString()) - 1

        'Set the Seat Number friendly name label
        lblSeat.Text = seatNumber
    End Sub

    Private Sub btnClearSeat_Click(sender As Object, e As EventArgs) Handles btnClearSeat.Click
        lblSeat.Text = ""
    End Sub

    ''' <summary>
    ''' Check to ensure FirstName, LastName and Seat have all been filled in before
    ''' enabling the 'Add Reservation' button
    ''' </summary>
    Private Sub ValidateReservation()
        'Ensure FirstName, LastName and Seat fields all contain data before enabling Add Reservation button

        If IsNullOrWhiteSpace(txtFirstName.Text) Or IsNullOrWhiteSpace(txtLastName.Text) Then
            btnAddReservation.Enabled = False
        Else
            btnAddReservation.Enabled = True
        End If
    End Sub

    Private Sub lblSeat_TextChanged(sender As Object, e As EventArgs) Handles lblSeat.TextChanged
        ValidateReservation()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        ValidateReservation()
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        ValidateReservation()
    End Sub

    ''' <summary>
    ''' Cancel a Reservation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click

        'Get selected reservation seat number
        Dim resSeat As String = lvCurrentReservations.SelectedItems(0).SubItems(1).Text
        'Remove record from Current Reservations list
        lvCurrentReservations.Items.RemoveAt(lvCurrentReservations.SelectedIndices(0))

        CancelReservation(resSeat)

        lvCurrentReservations = PopulateReservationsView(lvCurrentReservations)

        'Clear Search Text Box
        txtSearchBox.Text = ""

    End Sub

    ''' <summary>
    ''' Add a reservation, or if no seats available, add to waiting list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddReservation_Click(sender As Object, e As EventArgs) Handles btnAddReservation.Click
        'Convert FirstName and LastName to PersonModel
        Dim p As New PersonModel()
        p.Firstname = txtFirstName.Text
        p.Lastname = txtLastName.Text

        'Get Seat Number
        seatNumber = lblSeat.Text

        MakeReservation(p, seatNumber)

        'update current passenger list
        lvCurrentReservations = PopulateReservationsView(lvCurrentReservations)

    End Sub

    ''' <summary>
    ''' Search the current reservations for a name entered by the user.
    ''' Highlight the name in the reservations list, ready to cancel the
    ''' reservation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim resFound As ListViewItem

        'Search for the entered text
        resFound = lvCurrentReservations.FindItemWithText(txtSearchBox.Text, True, 0)

        'Search returns index of -1 if text not found, otherwise it returns the index of the found item in the list
        If resFound.Index <> -1 Then
            'Select the found item, and make sure it is visible to the user
            lvCurrentReservations.Focus()
            resFound.Selected = True
            lvCurrentReservations.Items(resFound.Index).Selected = True
            resFound.EnsureVisible()
        Else
            'Reservation was not found
            MessageBox.Show("The reservation for " & txtSearchBox.Text & " was not found.",
                            "Reservation not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnShowWaiting_Click(sender As Object, e As EventArgs) Handles btnShowWaiting.Click
        frmWaitingList.Show()
    End Sub
End Class
