Public Class frmPasswordGenerator

    Private Sub frmPasswordGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumCharacters.Text = "8"
    End Sub


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        txtOutput.Text = String.Empty

        'Makes sure length text box has a numeric value. If not, inform the user
        If IsNumeric(txtNumCharacters.Text) Then
#Region "Old Code"
            'Dim length = CInt(txtNumCharacters.Text)   'Length of password
            'Dim charType As Integer = 0    'Stores value for type of each character
            'Dim password As String = String.Empty  'Used to store the password
            'Dim randNum As New Random    'Used for randomly selecting each character
            'Dim typeSelecter As New Random   'Generated to determine type of each character

            'Dim useSpecial As Integer
            ''If the special characters check box is checked, then the upper range of typeSelector will be set to
            ''4, allowing special characters to be chosen. If not, then it will be 3, preventing them from being chosen.
            'If chkSpecialChar.Checked = True Then
            '    useSpecial = 4
            'Else
            '    useSpecial = 3
            'End If

            'For i = 1 To length    'Generates the password
            '    charType = typeSelecter.Next(0, useSpecial)
            '    '
            '    If charType = 0 Then   'Uppercase letter
            '        password &= Chr(randNum.Next(65, 91))
            '    ElseIf charType = 1 Then   'Lowercase letter
            '        password &= Chr(randNum.Next(97, 123))
            '    ElseIf charType = 2 Then   'Number
            '        password &= randNum.Next(0, 9).ToString
            '    ElseIf charType = 3 Then   'Special Character
            '        password &= Chr(randNum.Next(33, 46))
            '    End If
            'Next

            'txtOutput.Text = password   'Outputs the password
#End Region
            'Check to see if any of the character select check boxes are checked. If not, inform the user.
            If chkUppercase.Checked = True Or chkLowercase.Checked = True Or chkNumbers.Checked = True Or chkSpecialChar.Checked = True Then
                Dim length As Integer = CInt(txtNumCharacters.Text)   'Number of characters in the password
                Dim selectedChars As New ArrayList   'Stores ASCII values of selected characters - Used when generating password
                Dim password As String = String.Empty   'Stores password
                Dim randNum As New Random   'Random number used for generating password

                'Adds ASCII values for uppercase letters to selectable characters
                If chkUppercase.Checked = True Then
                    For i = 65 To 90
                        selectedChars.Add(i)
                    Next
                End If
                'Adds ASCII values for lowercase letters
                If chkLowercase.Checked = True Then
                    For i = 97 To 122
                        selectedChars.Add(i)
                    Next
                End If
                'Adds ASCII values for numbers
                If chkNumbers.Checked = True Then
                    For i = 48 To 57
                        selectedChars.Add(i)
                    Next
                End If
                'Adds ASCII values for special characters
                'Plan to add feature to select specific special characters user wants
                If chkSpecialChar.Checked = True Then
                    For i = 33 To 47
                        selectedChars.Add(i)
                    Next
                    For i = 58 To 64
                        selectedChars.Add(i)
                    Next
                    For i = 91 To 96
                        selectedChars.Add(i)
                    Next
                    For i = 123 To 126
                        selectedChars.Add(i)
                    Next
                End If


                'Generates password. randNum is used to select an ASCII value from selectedChars, which is converted into
                'a character and added to the password
                For i = 1 To length
                    password &= Chr(selectedChars(randNum.Next(0, selectedChars.Count)))
                Next
                'Outputs password
                txtOutput.Text = password
            Else
                MessageBox.Show("Please select at least one character type.", "Error")
            End If
        Else
            MessageBox.Show("Length must be numeric.", "Error")
            txtNumCharacters.Focus()
        End If
    End Sub

    Private Sub btnMinus1_Click(sender As Object, e As EventArgs) Handles btnMinus1.Click
        'Decreases value in txtNumCharacters by 1
        If IsNumeric(txtNumCharacters.Text) Then
            If txtNumCharacters.Text > 0 Then
                txtNumCharacters.Text = (CInt(txtNumCharacters.Text) - 1).ToString
            End If
        End If
    End Sub

    Private Sub btnPlus1_Click(sender As Object, e As EventArgs) Handles btnPlus1.Click
        'Increases value in txtNumCharacters by 1
        If IsNumeric(txtNumCharacters.Text) Then
            txtNumCharacters.Text = (CInt(txtNumCharacters.Text) + 1).ToString
        End If
    End Sub

    Private Sub txtNumCharacters_TextChanged(sender As Object, e As EventArgs) Handles txtNumCharacters.TextChanged
        If IsNumeric(txtNumCharacters.Text) Then
            If CInt(txtNumCharacters.Text) > 5000 Then
                txtNumCharacters.Text = 5000
                MessageBox.Show("5000 is the maximum length allowed.", "Notification")
            ElseIf CInt(txtNumCharacters.Text) <= 0 Then
                txtNumCharacters.Text = 8
                MessageBox.Show("Password cannot be zero or less characters.", "Notification")
            End If
        End If
    End Sub
End Class
