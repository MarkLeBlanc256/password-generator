<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPasswordGenerator
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
        Me.txtNumCharacters = New System.Windows.Forms.TextBox()
        Me.btnMinus1 = New System.Windows.Forms.Button()
        Me.btnPlus1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.chkSpecialChar = New System.Windows.Forms.CheckBox()
        Me.chkUppercase = New System.Windows.Forms.CheckBox()
        Me.chkLowercase = New System.Windows.Forms.CheckBox()
        Me.chkNumbers = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtNumCharacters
        '
        Me.txtNumCharacters.Location = New System.Drawing.Point(115, 36)
        Me.txtNumCharacters.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumCharacters.Name = "txtNumCharacters"
        Me.txtNumCharacters.Size = New System.Drawing.Size(30, 20)
        Me.txtNumCharacters.TabIndex = 0
        Me.txtNumCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMinus1
        '
        Me.btnMinus1.Location = New System.Drawing.Point(89, 36)
        Me.btnMinus1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMinus1.Name = "btnMinus1"
        Me.btnMinus1.Size = New System.Drawing.Size(21, 19)
        Me.btnMinus1.TabIndex = 1
        Me.btnMinus1.Text = "-"
        Me.btnMinus1.UseVisualStyleBackColor = True
        '
        'btnPlus1
        '
        Me.btnPlus1.Location = New System.Drawing.Point(148, 36)
        Me.btnPlus1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPlus1.Name = "btnPlus1"
        Me.btnPlus1.Size = New System.Drawing.Size(21, 19)
        Me.btnPlus1.TabIndex = 2
        Me.btnPlus1.Text = "+"
        Me.btnPlus1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length:"
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(9, 229)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(164, 20)
        Me.txtOutput.TabIndex = 4
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(9, 197)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(163, 27)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create Password"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'chkSpecialChar
        '
        Me.chkSpecialChar.AutoSize = True
        Me.chkSpecialChar.Location = New System.Drawing.Point(22, 168)
        Me.chkSpecialChar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSpecialChar.Name = "chkSpecialChar"
        Me.chkSpecialChar.Size = New System.Drawing.Size(137, 17)
        Me.chkSpecialChar.TabIndex = 6
        Me.chkSpecialChar.Text = "Use Special Characters"
        Me.chkSpecialChar.UseVisualStyleBackColor = True
        '
        'chkUppercase
        '
        Me.chkUppercase.AutoSize = True
        Me.chkUppercase.Location = New System.Drawing.Point(22, 102)
        Me.chkUppercase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkUppercase.Name = "chkUppercase"
        Me.chkUppercase.Size = New System.Drawing.Size(135, 17)
        Me.chkUppercase.TabIndex = 7
        Me.chkUppercase.Text = "Use Uppercase Letters"
        Me.chkUppercase.UseVisualStyleBackColor = True
        '
        'chkLowercase
        '
        Me.chkLowercase.AutoSize = True
        Me.chkLowercase.Location = New System.Drawing.Point(22, 124)
        Me.chkLowercase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkLowercase.Name = "chkLowercase"
        Me.chkLowercase.Size = New System.Drawing.Size(135, 17)
        Me.chkLowercase.TabIndex = 8
        Me.chkLowercase.Text = "Use Lowercase Letters"
        Me.chkLowercase.UseVisualStyleBackColor = True
        '
        'chkNumbers
        '
        Me.chkNumbers.AutoSize = True
        Me.chkNumbers.Location = New System.Drawing.Point(22, 146)
        Me.chkNumbers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNumbers.Name = "chkNumbers"
        Me.chkNumbers.Size = New System.Drawing.Size(90, 17)
        Me.chkNumbers.TabIndex = 9
        Me.chkNumbers.Text = "Use Numbers"
        Me.chkNumbers.UseVisualStyleBackColor = True
        '
        'frmPasswordGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 258)
        Me.Controls.Add(Me.chkNumbers)
        Me.Controls.Add(Me.chkLowercase)
        Me.Controls.Add(Me.chkUppercase)
        Me.Controls.Add(Me.chkSpecialChar)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlus1)
        Me.Controls.Add(Me.btnMinus1)
        Me.Controls.Add(Me.txtNumCharacters)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPasswordGenerator"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumCharacters As TextBox
    Friend WithEvents btnMinus1 As Button
    Friend WithEvents btnPlus1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents chkSpecialChar As CheckBox
    Friend WithEvents chkUppercase As CheckBox
    Friend WithEvents chkLowercase As CheckBox
    Friend WithEvents chkNumbers As CheckBox
End Class
