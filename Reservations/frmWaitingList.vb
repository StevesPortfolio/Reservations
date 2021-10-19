
'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 5 April, 2018
'Module: frmWaitingList
'Purpose: Waiting LIst Maintenance. Allows user to view waiting list, and remove people from waiting list

Public Class frmWaitingList




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmWaitingList_Load(sender As Object, e As EventArgs) Handles Me.Load

        lvWaitingList = PopulateWaitingList(lvWaitingList)

    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click


        WaitList.RemoveAt(lvWaitingList.SelectedIndices(0))
        SaveWaitingList()
        lvWaitingList.Clear()
        lvWaitingList = PopulateWaitingList(lvWaitingList)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim wlFound As ListViewItem

        'Search for the entered text
        wlFound = lvWaitingList.FindItemWithText(txtSearchBox.Text, True, 0)

        'Search returns index of -1 if text not found, otherwise it returns the index of the found item in the list
        If wlFound.Index <> -1 Then
            'Select the found item, and make sure it is visible to the user
            lvWaitingList.Focus()
            wlFound.Selected = True
            lvWaitingList.Items(wlFound.Index).Selected = True
            wlFound.EnsureVisible()
        Else
            'Reservation was not found
            MessageBox.Show(txtSearchBox.Text & " was not found in the Waiting list.",
                            "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAddToWaitingList_Click(sender As Object, e As EventArgs) Handles btnAddToWaitingList.Click
        frmAddToWaitingList.Show()




    End Sub
End Class