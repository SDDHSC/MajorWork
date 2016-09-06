Module GlobalSubs
    Public Sub styleForm(Form As Form)
        Form.BackColor = schoolBlue
        Form.Width = 700
        Form.Height = 450
        Form.FormBorderStyle = FormBorderStyle.None
        Form.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub openForm(originalForm, newForm)
        newForm.TopLevel = False
        Main.Panel1.Controls.Add(newForm)
        newForm.Show()
        originalForm.Close()
    End Sub
    'Example: Opening ForgotPassword form.
    'openForm(Me, new forgotPassword)

    'Converts back and forth from ordinal (i.e. 1st) to integer (i.e. 1)
    Public Function ordinalConvert(val)
        If TypeOf (val) Is String Then
            Return val.substring(0, val.length - 2)
        Else
            If val Mod 10 = 1 And val Mod 100 <> 11 Then
                Return (CStr(val) + "st")
            ElseIf val Mod 10 = 2 And val Mod 100 <> 12 Then
                Return (CStr(val) + "nd")
            ElseIf val Mod 10 = 3 And val Mod 100 <> 13 Then
                Return (CStr(val) + "rd")
            Else
                Return (CStr(val) + "th")
            End If
        End If
    End Function

End Module
