Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomMessageBox
    Public Enum CustomMessageBoxResult As Integer
        button1 = DialogResult.OK
        button2 = DialogResult.Yes
        button3 = DialogResult.No
        buttonHelp = DialogResult.Cancel
    End Enum

    Public Shared Function ShowMessageBox(ByVal title As String, ByVal instruction As String, ByVal message As String, ByVal img As String, ByVal button1text As String, ByVal button2text As String, ByVal button3text As String, Optional ByVal helpbuttontext As String = "Help") As CustomMessageBoxResult
        Dim f As New CustomMessageBoxForm
        f.lblInstruction.Text = instruction
        f.lblMessage.Text = message
        f.btn1.Text = button1text
        f.btn2.Text = button2text
        f.btn3.Text = button3text
        f.btnHelp.Text = helpbuttontext
        f.ico.Image = Image.FromFile(img)
        f.Icon = SystemIcons.Information
        f.Text = title
        Dim dlg = f.ShowDialog()
        Return dlg
    End Function
End Class
