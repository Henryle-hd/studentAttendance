<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnAttede = New Button()
        listAttendee = New ListBox()
        TextFirstName = New TextBox()
        textLastName = New TextBox()
        TextReg = New TextBox()
        lbFirstName = New Label()
        LbLastName = New Label()
        LbReg = New Label()
        lbListAttendee = New Label()
        LbRegister = New Label()
        SuspendLayout()
        ' 
        ' btnAttede
        ' 
        btnAttede.Location = New Point(619, 208)
        btnAttede.Name = "btnAttede"
        btnAttede.Size = New Size(120, 58)
        btnAttede.TabIndex = 0
        btnAttede.Text = "Attende"
        btnAttede.UseVisualStyleBackColor = True
        ' 
        ' listAttendee
        ' 
        listAttendee.Font = New Font("Segoe UI", 12F)
        listAttendee.FormattingEnabled = True
        listAttendee.ItemHeight = 21
        listAttendee.Location = New Point(12, 59)
        listAttendee.Name = "listAttendee"
        listAttendee.Size = New Size(407, 361)
        listAttendee.TabIndex = 1
        ' 
        ' TextFirstName
        ' 
        TextFirstName.Location = New Point(590, 59)
        TextFirstName.Name = "TextFirstName"
        TextFirstName.PlaceholderText = "eg. Alex"
        TextFirstName.Size = New Size(180, 23)
        TextFirstName.TabIndex = 2
        ' 
        ' textLastName
        ' 
        textLastName.Location = New Point(590, 114)
        textLastName.Name = "textLastName"
        textLastName.PlaceholderText = "eg.  Mwombeck"
        textLastName.Size = New Size(180, 23)
        textLastName.TabIndex = 3
        ' 
        ' TextReg
        ' 
        TextReg.Location = New Point(590, 164)
        TextReg.Name = "TextReg"
        TextReg.PlaceholderText = "eg.  02.7654.21.01.2005"
        TextReg.Size = New Size(180, 23)
        TextReg.TabIndex = 4
        ' 
        ' lbFirstName
        ' 
        lbFirstName.AutoSize = True
        lbFirstName.Location = New Point(512, 67)
        lbFirstName.Name = "lbFirstName"
        lbFirstName.Size = New Size(64, 15)
        lbFirstName.TabIndex = 5
        lbFirstName.Tag = ""
        lbFirstName.Text = "First Name"
        ' 
        ' LbLastName
        ' 
        LbLastName.AutoSize = True
        LbLastName.Location = New Point(512, 117)
        LbLastName.Name = "LbLastName"
        LbLastName.Size = New Size(63, 15)
        LbLastName.TabIndex = 6
        LbLastName.Text = "Last Name"
        ' 
        ' LbReg
        ' 
        LbReg.AutoSize = True
        LbReg.Location = New Point(512, 172)
        LbReg.Name = "LbReg"
        LbReg.Size = New Size(71, 15)
        LbReg.TabIndex = 7
        LbReg.Text = "RegNumber"
        ' 
        ' lbListAttendee
        ' 
        lbListAttendee.AutoSize = True
        lbListAttendee.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbListAttendee.Location = New Point(12, 24)
        lbListAttendee.Name = "lbListAttendee"
        lbListAttendee.Size = New Size(134, 21)
        lbListAttendee.TabIndex = 8
        lbListAttendee.Text = "List of Attendee "
        ' 
        ' LbRegister
        ' 
        LbRegister.AutoSize = True
        LbRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LbRegister.Location = New Point(619, 24)
        LbRegister.Name = "LbRegister"
        LbRegister.Size = New Size(98, 21)
        LbRegister.TabIndex = 9
        LbRegister.Text = "Attendence"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LbRegister)
        Controls.Add(lbListAttendee)
        Controls.Add(LbReg)
        Controls.Add(LbLastName)
        Controls.Add(lbFirstName)
        Controls.Add(TextReg)
        Controls.Add(textLastName)
        Controls.Add(TextFirstName)
        Controls.Add(listAttendee)
        Controls.Add(btnAttede)
        Name = "Form1"
        Text = "Class Attendence Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAttede As Button
    Friend WithEvents listAttendee As ListBox
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents textLastName As TextBox
    Friend WithEvents TextReg As TextBox
    Friend WithEvents lbFirstName As Label
    Friend WithEvents LbLastName As Label
    Friend WithEvents LbReg As Label
    Friend WithEvents lbListAttendee As Label
    Friend WithEvents LbRegister As Label

End Class
