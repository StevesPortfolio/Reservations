<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpAddReservation = New System.Windows.Forms.GroupBox()
        Me.lblSeat = New System.Windows.Forms.Label()
        Me.lblSeatHeader = New System.Windows.Forms.Label()
        Me.btnAddReservation = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpCancelReservation = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.lblExisting = New System.Windows.Forms.Label()
        Me.lblCancelInstructions = New System.Windows.Forms.Label()
        Me.lvCurrentReservations = New System.Windows.Forms.ListView()
        Me.btnCancelReservation = New System.Windows.Forms.Button()
        Me.grpSeating = New System.Windows.Forms.GroupBox()
        Me.lblSeatsRemaining = New System.Windows.Forms.Label()
        Me.lblHdrSeatsRemaining = New System.Windows.Forms.Label()
        Me.btnClearSeat = New System.Windows.Forms.Button()
        Me.lblReserved = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.tlpSeatingChart = New System.Windows.Forms.TableLayoutPanel()
        Me.btnShowWaiting = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.grpAddReservation.SuspendLayout()
        Me.grpCancelReservation.SuspendLayout()
        Me.grpSeating.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(781, 656)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 29)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpAddReservation
        '
        Me.grpAddReservation.Controls.Add(Me.lblSeat)
        Me.grpAddReservation.Controls.Add(Me.lblSeatHeader)
        Me.grpAddReservation.Controls.Add(Me.btnAddReservation)
        Me.grpAddReservation.Controls.Add(Me.txtLastName)
        Me.grpAddReservation.Controls.Add(Me.txtFirstName)
        Me.grpAddReservation.Controls.Add(Me.lblLastName)
        Me.grpAddReservation.Controls.Add(Me.lblFirstName)
        Me.grpAddReservation.Location = New System.Drawing.Point(12, 96)
        Me.grpAddReservation.Name = "grpAddReservation"
        Me.grpAddReservation.Size = New System.Drawing.Size(444, 122)
        Me.grpAddReservation.TabIndex = 1
        Me.grpAddReservation.TabStop = False
        Me.grpAddReservation.Text = "Add Reservation"
        '
        'lblSeat
        '
        Me.lblSeat.BackColor = System.Drawing.Color.White
        Me.lblSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeat.Location = New System.Drawing.Point(325, 42)
        Me.lblSeat.Name = "lblSeat"
        Me.lblSeat.Size = New System.Drawing.Size(88, 48)
        Me.lblSeat.TabIndex = 9
        Me.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeatHeader
        '
        Me.lblSeatHeader.AutoSize = True
        Me.lblSeatHeader.Location = New System.Drawing.Point(322, 19)
        Me.lblSeatHeader.Name = "lblSeatHeader"
        Me.lblSeatHeader.Size = New System.Drawing.Size(91, 17)
        Me.lblSeatHeader.TabIndex = 8
        Me.lblSeatHeader.Text = "Seat Number"
        '
        'btnAddReservation
        '
        Me.btnAddReservation.Enabled = False
        Me.btnAddReservation.Location = New System.Drawing.Point(92, 80)
        Me.btnAddReservation.Name = "btnAddReservation"
        Me.btnAddReservation.Size = New System.Drawing.Size(143, 30)
        Me.btnAddReservation.TabIndex = 7
        Me.btnAddReservation.Text = "Add Reservation"
        Me.btnAddReservation.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(92, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(198, 23)
        Me.txtLastName.TabIndex = 6
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(92, 25)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(198, 23)
        Me.txtFirstName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 54)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(6, 28)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(297, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(300, 29)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Airline Reservation System"
        '
        'grpCancelReservation
        '
        Me.grpCancelReservation.Controls.Add(Me.btnSearch)
        Me.grpCancelReservation.Controls.Add(Me.lblSearch)
        Me.grpCancelReservation.Controls.Add(Me.txtSearchBox)
        Me.grpCancelReservation.Controls.Add(Me.lblExisting)
        Me.grpCancelReservation.Controls.Add(Me.lblCancelInstructions)
        Me.grpCancelReservation.Controls.Add(Me.lvCurrentReservations)
        Me.grpCancelReservation.Controls.Add(Me.btnCancelReservation)
        Me.grpCancelReservation.Location = New System.Drawing.Point(12, 237)
        Me.grpCancelReservation.Name = "grpCancelReservation"
        Me.grpCancelReservation.Size = New System.Drawing.Size(444, 454)
        Me.grpCancelReservation.TabIndex = 3
        Me.grpCancelReservation.TabStop = False
        Me.grpCancelReservation.Text = "Cancel existing Reservation"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.Reservations.My.Resources.Resources.Search_noHalo_16x
        Me.btnSearch.Location = New System.Drawing.Point(374, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 24)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(12, 27)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(412, 40)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Search for passenger name, or select from list below to cancel a reservation"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Location = New System.Drawing.Point(15, 70)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(352, 23)
        Me.txtSearchBox.TabIndex = 5
        '
        'lblExisting
        '
        Me.lblExisting.AutoSize = True
        Me.lblExisting.Location = New System.Drawing.Point(9, 99)
        Me.lblExisting.Name = "lblExisting"
        Me.lblExisting.Size = New System.Drawing.Size(141, 17)
        Me.lblExisting.TabIndex = 4
        Me.lblExisting.Text = "Current reservations:"
        '
        'lblCancelInstructions
        '
        Me.lblCancelInstructions.Location = New System.Drawing.Point(274, 119)
        Me.lblCancelInstructions.Name = "lblCancelInstructions"
        Me.lblCancelInstructions.Size = New System.Drawing.Size(164, 147)
        Me.lblCancelInstructions.TabIndex = 3
        Me.lblCancelInstructions.Text = "To cancel a reservation, select the passenger and click ""Cancel Reservation"". Whe" &
    "n a reservation is cancelled, the next person on the waiting list will be given " &
    "the vacated seat."
        '
        'lvCurrentReservations
        '
        Me.lvCurrentReservations.AutoArrange = False
        Me.lvCurrentReservations.FullRowSelect = True
        Me.lvCurrentReservations.Location = New System.Drawing.Point(9, 119)
        Me.lvCurrentReservations.Name = "lvCurrentReservations"
        Me.lvCurrentReservations.Size = New System.Drawing.Size(259, 329)
        Me.lvCurrentReservations.TabIndex = 2
        Me.lvCurrentReservations.UseCompatibleStateImageBehavior = False
        Me.lvCurrentReservations.View = System.Windows.Forms.View.Details
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.Location = New System.Drawing.Point(277, 397)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(161, 51)
        Me.btnCancelReservation.TabIndex = 1
        Me.btnCancelReservation.Text = "Cancel Reservation"
        Me.btnCancelReservation.UseVisualStyleBackColor = True
        '
        'grpSeating
        '
        Me.grpSeating.Controls.Add(Me.lblSeatsRemaining)
        Me.grpSeating.Controls.Add(Me.lblHdrSeatsRemaining)
        Me.grpSeating.Controls.Add(Me.btnClearSeat)
        Me.grpSeating.Controls.Add(Me.lblReserved)
        Me.grpSeating.Controls.Add(Me.lblAvailable)
        Me.grpSeating.Controls.Add(Me.tlpSeatingChart)
        Me.grpSeating.Location = New System.Drawing.Point(495, 105)
        Me.grpSeating.Name = "grpSeating"
        Me.grpSeating.Size = New System.Drawing.Size(386, 533)
        Me.grpSeating.TabIndex = 4
        Me.grpSeating.TabStop = False
        Me.grpSeating.Text = "Seating Chart"
        '
        'lblSeatsRemaining
        '
        Me.lblSeatsRemaining.AutoSize = True
        Me.lblSeatsRemaining.Location = New System.Drawing.Point(286, 196)
        Me.lblSeatsRemaining.Name = "lblSeatsRemaining"
        Me.lblSeatsRemaining.Size = New System.Drawing.Size(0, 17)
        Me.lblSeatsRemaining.TabIndex = 10
        '
        'lblHdrSeatsRemaining
        '
        Me.lblHdrSeatsRemaining.AutoSize = True
        Me.lblHdrSeatsRemaining.Location = New System.Drawing.Point(259, 175)
        Me.lblHdrSeatsRemaining.Name = "lblHdrSeatsRemaining"
        Me.lblHdrSeatsRemaining.Size = New System.Drawing.Size(114, 17)
        Me.lblHdrSeatsRemaining.TabIndex = 9
        Me.lblHdrSeatsRemaining.Text = "Seats remaining:"
        '
        'btnClearSeat
        '
        Me.btnClearSeat.Location = New System.Drawing.Point(289, 476)
        Me.btnClearSeat.Name = "btnClearSeat"
        Me.btnClearSeat.Size = New System.Drawing.Size(87, 43)
        Me.btnClearSeat.TabIndex = 8
        Me.btnClearSeat.Text = "Clear Seat Number"
        Me.btnClearSeat.UseVisualStyleBackColor = True
        '
        'lblReserved
        '
        Me.lblReserved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblReserved.Location = New System.Drawing.Point(274, 101)
        Me.lblReserved.Name = "lblReserved"
        Me.lblReserved.Size = New System.Drawing.Size(99, 37)
        Me.lblReserved.TabIndex = 7
        Me.lblReserved.Text = "Reserved Seat"
        Me.lblReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvailable
        '
        Me.lblAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvailable.Location = New System.Drawing.Point(274, 44)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(99, 37)
        Me.lblAvailable.TabIndex = 6
        Me.lblAvailable.Text = "Available Seat"
        Me.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpSeatingChart
        '
        Me.tlpSeatingChart.ColumnCount = 4
        Me.tlpSeatingChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSeatingChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSeatingChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSeatingChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpSeatingChart.Location = New System.Drawing.Point(6, 36)
        Me.tlpSeatingChart.Name = "tlpSeatingChart"
        Me.tlpSeatingChart.RowCount = 10
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeatingChart.Size = New System.Drawing.Size(242, 483)
        Me.tlpSeatingChart.TabIndex = 5
        '
        'btnShowWaiting
        '
        Me.btnShowWaiting.Location = New System.Drawing.Point(501, 656)
        Me.btnShowWaiting.Name = "btnShowWaiting"
        Me.btnShowWaiting.Size = New System.Drawing.Size(242, 29)
        Me.btnShowWaiting.TabIndex = 5
        Me.btnShowWaiting.Text = "Display or Add to Waiting List"
        Me.btnShowWaiting.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(9, 47)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(872, 46)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "To make a reservation, enter your name and select your preferred seat from those " &
    "available. If no seat is selected, your name will be added to the flight waiting" &
    " list."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 703)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnShowWaiting)
        Me.Controls.Add(Me.grpSeating)
        Me.Controls.Add(Me.grpCancelReservation)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpAddReservation)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airline Reservations System - Written by Steve Teece"
        Me.grpAddReservation.ResumeLayout(False)
        Me.grpAddReservation.PerformLayout()
        Me.grpCancelReservation.ResumeLayout(False)
        Me.grpCancelReservation.PerformLayout()
        Me.grpSeating.ResumeLayout(False)
        Me.grpSeating.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents grpAddReservation As GroupBox
    Friend WithEvents lblSeat As Label
    Friend WithEvents lblSeatHeader As Label
    Friend WithEvents btnAddReservation As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents grpCancelReservation As GroupBox
    Friend WithEvents btnCancelReservation As Button
    Friend WithEvents grpSeating As GroupBox
    Friend WithEvents lblReserved As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents tlpSeatingChart As TableLayoutPanel
    Friend WithEvents btnShowWaiting As Button
    Friend WithEvents btnClearSeat As Button
    Friend WithEvents lvCurrentReservations As ListView
    Friend WithEvents lblExisting As Label
    Friend WithEvents lblCancelInstructions As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblSeatsRemaining As Label
    Friend WithEvents lblHdrSeatsRemaining As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchBox As TextBox
End Class
