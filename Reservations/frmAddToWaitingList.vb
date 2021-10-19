
'Program Name: Reservations
'Author: Steve Teece
'Version 1.0
'Date Written: 7 April, 2018
'Module: frmAddToWaitingList
'Purpose: Gets the name of a new person to be added to the waiting list

Public Class frmAddToWaitingList
    Private Sub btnAddWaiting_Click(sender As Object, e As EventArgs) Handles btnAddWaiting.Click

        Dim p = New PersonModel()
        'Convert entered text to Person model
        p.Firstname = txtFirstName.Text
        p.Lastname = txtLastName.Text

        AddToWaitingList(p)

        'Refresh waiting list
        frmWaitingList.lvWaitingList = PopulateWaitingList(frmWaitingList.lvWaitingList)

        MessageBox.Show("Person has been added to the waiting list", "Waiting List updated", MessageBoxButtons.OK)
        Me.Close()


    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Me.Close()
    End Sub
End Class