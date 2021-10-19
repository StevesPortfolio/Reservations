<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaitingList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.lvWaitingList = New System.Windows.Forms.ListView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.lblExisting = New System.Windows.Forms.Label()
        Me.btnAddToWaitingList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(374, 513)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.BackColor = System.Drawing.SystemColors.Control
        Me.btnRemoveSelected.Location = New System.Drawing.Point(374, 413)
        Me.btnRemoveSelected.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(100, 64)
        Me.btnRemoveSelected.TabIndex = 2
        Me.btnRemoveSelected.Text = "Remove selected Passenger"
        Me.btnRemoveSelected.UseVisualStyleBackColor = False
        '
        'lvWaitingList
        '
        Me.lvWaitingList.Location = New System.Drawing.Point(12, 111)
        Me.lvWaitingList.Name = "lvWaitingList"
        Me.lvWaitingList.Size = New System.Drawing.Size(346, 431)
        Me.lvWaitingList.TabIndex = 3
        Me.lvWaitingList.UseCompatibleStateImageBehavior = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.Reservations.My.Resources.Resources.Search_noHalo_16x
        Me.btnSearch.Location = New System.Drawing.Point(374, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 24)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(12, 9)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(412, 40)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search for passenger name, or select from list below to remove a passenger from t" &
    "he waiting list"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Location = New System.Drawing.Point(15, 52)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(352, 23)
        Me.txtSearchBox.TabIndex = 9
        '
        'lblExisting
        '
        Me.lblExisting.AutoSize = True
        Me.lblExisting.Location = New System.Drawing.Point(12, 91)
        Me.lblExisting.Name = "lblExisting"
        Me.lblExisting.Size = New System.Drawing.Size(141, 17)
        Me.lblExisting.TabIndex = 8
        Me.lblExisting.Text = "Current reservations:"
        '
        'btnAddToWaitingList
        '
        Me.btnAddToWaitingList.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddToWaitingList.Location = New System.Drawing.Point(374, 329)
        Me.btnAddToWaitingList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToWaitingList.Name = "btnAddToWaitingList"
        Me.btnAddToWaitingList.Size = New System.Drawing.Size(100, 64)
        Me.btnAddToWaitingList.TabIndex = 12
        Me.btnAddToWaitingList.Text = "Add new person to the Waiting List"
        Me.btnAddToWaitingList.UseVisualStyleBackColor = False
        '
        'frmWaitingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(492, 554)
        Me.Controls.Add(Me.btnAddToWaitingList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.lblExisting)
        Me.Controls.Add(Me.lvWaitingList)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWaitingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current passenger waiting list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents lvWaitingList As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents lblExisting As Label
    Friend WithEvents btnAddToWaitingList As Button
End Class
