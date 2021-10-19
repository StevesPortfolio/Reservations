<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddToWaitingList
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
        Me.btnAddWaiting = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblAddWaitingHeader = New System.Windows.Forms.Label()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddWaiting
        '
        Me.btnAddWaiting.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAddWaiting.Location = New System.Drawing.Point(125, 108)
        Me.btnAddWaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddWaiting.Name = "btnAddWaiting"
        Me.btnAddWaiting.Size = New System.Drawing.Size(191, 37)
        Me.btnAddWaiting.TabIndex = 12
        Me.btnAddWaiting.Text = "Add to Waiting List"
        Me.btnAddWaiting.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(125, 78)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(273, 23)
        Me.txtLastName.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(125, 46)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(273, 23)
        Me.txtFirstName.TabIndex = 10
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(20, 82)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(20, 50)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name:"
        '
        'lblAddWaitingHeader
        '
        Me.lblAddWaitingHeader.AutoSize = True
        Me.lblAddWaitingHeader.Location = New System.Drawing.Point(20, 9)
        Me.lblAddWaitingHeader.Name = "lblAddWaitingHeader"
        Me.lblAddWaitingHeader.Size = New System.Drawing.Size(239, 17)
        Me.lblAddWaitingHeader.TabIndex = 13
        Me.lblAddWaitingHeader.Text = "Add a new person to the Waiting List"
        '
        'bntClose
        '
        Me.bntClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bntClose.Location = New System.Drawing.Point(323, 108)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(75, 37)
        Me.bntClose.TabIndex = 14
        Me.bntClose.Text = "Close"
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'frmAddToWaitingList
        '
        Me.AcceptButton = Me.btnAddWaiting
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bntClose
        Me.ClientSize = New System.Drawing.Size(424, 162)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.lblAddWaitingHeader)
        Me.Controls.Add(Me.btnAddWaiting)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddToWaitingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add to Waiting List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddWaiting As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblAddWaitingHeader As Label
    Friend WithEvents bntClose As Button
End Class
