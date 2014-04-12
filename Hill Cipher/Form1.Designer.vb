<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.encode = New System.Windows.Forms.Button()
        Me.plaintextInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.encodedInput = New System.Windows.Forms.TextBox()
        Me.encrypt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.decrypt = New System.Windows.Forms.Button()
        Me.cipherInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.decode = New System.Windows.Forms.Button()
        Me.encodedInput2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.plaintextInput2 = New System.Windows.Forms.TextBox()
        Me.keyBox = New System.Windows.Forms.TextBox()
        Me.invkeyBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.keySizeGB = New System.Windows.Forms.GroupBox()
        Me.clearAll = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.keySizeGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'encode
        '
        Me.encode.ForeColor = System.Drawing.Color.Black
        Me.encode.Location = New System.Drawing.Point(299, 58)
        Me.encode.Name = "encode"
        Me.encode.Size = New System.Drawing.Size(149, 23)
        Me.encode.TabIndex = 0
        Me.encode.Text = "Encode"
        Me.encode.UseVisualStyleBackColor = True
        '
        'plaintextInput
        '
        Me.plaintextInput.Location = New System.Drawing.Point(133, 32)
        Me.plaintextInput.Name = "plaintextInput"
        Me.plaintextInput.Size = New System.Drawing.Size(315, 20)
        Me.plaintextInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Plain Text:"
        '
        'encodedInput
        '
        Me.encodedInput.Location = New System.Drawing.Point(133, 88)
        Me.encodedInput.Name = "encodedInput"
        Me.encodedInput.Size = New System.Drawing.Size(315, 20)
        Me.encodedInput.TabIndex = 5
        '
        'encrypt
        '
        Me.encrypt.ForeColor = System.Drawing.Color.Black
        Me.encrypt.Location = New System.Drawing.Point(299, 114)
        Me.encrypt.Name = "encrypt"
        Me.encrypt.Size = New System.Drawing.Size(149, 23)
        Me.encrypt.TabIndex = 6
        Me.encrypt.Text = "Encrypt"
        Me.encrypt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Encoded Message:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cipher:"
        '
        'decrypt
        '
        Me.decrypt.ForeColor = System.Drawing.Color.Black
        Me.decrypt.Location = New System.Drawing.Point(299, 169)
        Me.decrypt.Name = "decrypt"
        Me.decrypt.Size = New System.Drawing.Size(149, 23)
        Me.decrypt.TabIndex = 9
        Me.decrypt.Text = "Decrypt"
        Me.decrypt.UseVisualStyleBackColor = True
        '
        'cipherInput
        '
        Me.cipherInput.Location = New System.Drawing.Point(133, 143)
        Me.cipherInput.Name = "cipherInput"
        Me.cipherInput.Size = New System.Drawing.Size(315, 20)
        Me.cipherInput.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Encoded Message:"
        '
        'decode
        '
        Me.decode.ForeColor = System.Drawing.Color.Black
        Me.decode.Location = New System.Drawing.Point(299, 224)
        Me.decode.Name = "decode"
        Me.decode.Size = New System.Drawing.Size(149, 23)
        Me.decode.TabIndex = 12
        Me.decode.Text = "Decode"
        Me.decode.UseVisualStyleBackColor = True
        '
        'encodedInput2
        '
        Me.encodedInput2.Location = New System.Drawing.Point(133, 198)
        Me.encodedInput2.Name = "encodedInput2"
        Me.encodedInput2.Size = New System.Drawing.Size(315, 20)
        Me.encodedInput2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Plain Text:"
        '
        'plaintextInput2
        '
        Me.plaintextInput2.Location = New System.Drawing.Point(133, 252)
        Me.plaintextInput2.Name = "plaintextInput2"
        Me.plaintextInput2.Size = New System.Drawing.Size(315, 20)
        Me.plaintextInput2.TabIndex = 14
        '
        'keyBox
        '
        Me.keyBox.Location = New System.Drawing.Point(26, 104)
        Me.keyBox.Multiline = True
        Me.keyBox.Name = "keyBox"
        Me.keyBox.Size = New System.Drawing.Size(100, 83)
        Me.keyBox.TabIndex = 17
        '
        'invkeyBox
        '
        Me.invkeyBox.Location = New System.Drawing.Point(26, 206)
        Me.invkeyBox.Multiline = True
        Me.invkeyBox.Name = "invkeyBox"
        Me.invkeyBox.Size = New System.Drawing.Size(100, 83)
        Me.invkeyBox.TabIndex = 18
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "2x2"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.Text = "3x3"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'keySizeGB
        '
        Me.keySizeGB.Controls.Add(Me.RadioButton1)
        Me.keySizeGB.Controls.Add(Me.RadioButton2)
        Me.keySizeGB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keySizeGB.Location = New System.Drawing.Point(26, 19)
        Me.keySizeGB.Name = "keySizeGB"
        Me.keySizeGB.Size = New System.Drawing.Size(94, 63)
        Me.keySizeGB.TabIndex = 22
        Me.keySizeGB.TabStop = False
        Me.keySizeGB.Text = "Key Size"
        '
        'clearAll
        '
        Me.clearAll.ForeColor = System.Drawing.Color.Black
        Me.clearAll.Location = New System.Drawing.Point(133, 278)
        Me.clearAll.Name = "clearAll"
        Me.clearAll.Size = New System.Drawing.Size(315, 23)
        Me.clearAll.TabIndex = 23
        Me.clearAll.Text = "Clear All"
        Me.clearAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.keySizeGB)
        Me.GroupBox1.Controls.Add(Me.keyBox)
        Me.GroupBox1.Controls.Add(Me.invkeyBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(479, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 309)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encryption Key"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.encode)
        Me.GroupBox2.Controls.Add(Me.plaintextInput)
        Me.GroupBox2.Controls.Add(Me.clearAll)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.plaintextInput2)
        Me.GroupBox2.Controls.Add(Me.decode)
        Me.GroupBox2.Controls.Add(Me.encodedInput)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.encrypt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.encodedInput2)
        Me.GroupBox2.Controls.Add(Me.cipherInput)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.decrypt)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 309)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cipher Hill"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Key:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Key Inverse:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Hill_Cipher.My.Resources.Resources.banner2
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 116)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(627, 442)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.keySizeGB.ResumeLayout(False)
        Me.keySizeGB.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents encode As System.Windows.Forms.Button
    Friend WithEvents plaintextInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents encodedInput As System.Windows.Forms.TextBox
    Friend WithEvents encrypt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents decrypt As System.Windows.Forms.Button
    Friend WithEvents cipherInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents decode As System.Windows.Forms.Button
    Friend WithEvents encodedInput2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents plaintextInput2 As System.Windows.Forms.TextBox
    Friend WithEvents keyBox As System.Windows.Forms.TextBox
    Friend WithEvents invkeyBox As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents keySizeGB As System.Windows.Forms.GroupBox
    Friend WithEvents clearAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
