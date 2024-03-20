Public Class Form1

    Dim iAttendeeNo As Integer
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnAttede.Click

        iAttendeeNo = iAttendeeNo + 1

        Dim stFirstName As String
        Dim stLastName As String
        Dim stReg As String

        stFirstName = TextFirstName.Text
        stLastName = textLastName.Text
        stReg = TextReg.Text

        If (TextFirstName.Text = "" Or textLastName.Text = "" Or TextReg.Text = "") Then
            MsgBox("All Input requred!", vbCritical, "Missing Input")

        Else
            TextFirstName.Text = ""
            textLastName.Text = ""
            TextReg.Text = ""

            listAttendee.Items.Add("" & iAttendeeNo & ". " & stFirstName & " " & stLastName & " ——→ " & stReg)

        End If



    End Sub
End Class
