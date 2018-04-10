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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnWriteColors = New System.Windows.Forms.Button()
        Me.btnTopBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clrTopLine = New System.Windows.Forms.Label()
        Me.clrTopFooter = New System.Windows.Forms.Label()
        Me.clrTopText = New System.Windows.Forms.Label()
        Me.clrTopHeader = New System.Windows.Forms.Label()
        Me.clrTopStripes = New System.Windows.Forms.Label()
        Me.clrTopBackGlow = New System.Windows.Forms.Label()
        Me.clrTopBack = New System.Windows.Forms.Label()
        Me.btnTopLine = New System.Windows.Forms.Button()
        Me.btnTopFooter = New System.Windows.Forms.Button()
        Me.btnTopText = New System.Windows.Forms.Button()
        Me.btnTopHeader = New System.Windows.Forms.Button()
        Me.btnTopStripes = New System.Windows.Forms.Button()
        Me.btnTopBackGlow = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.clrBottomFooter = New System.Windows.Forms.Label()
        Me.clrButtonGlow = New System.Windows.Forms.Label()
        Me.clrButtonColor = New System.Windows.Forms.Label()
        Me.clrButtonTextMask = New System.Windows.Forms.Label()
        Me.clrButtonText = New System.Windows.Forms.Label()
        Me.clrBottomLine = New System.Windows.Forms.Label()
        Me.clrBottomText = New System.Windows.Forms.Label()
        Me.clrBottomMask = New System.Windows.Forms.Label()
        Me.clrBottomStripes = New System.Windows.Forms.Label()
        Me.clrBottomBackGlow = New System.Windows.Forms.Label()
        Me.clrBottomBack = New System.Windows.Forms.Label()
        Me.btnButtonGlow = New System.Windows.Forms.Button()
        Me.btnButtonColor = New System.Windows.Forms.Button()
        Me.btnButtonTextMask = New System.Windows.Forms.Button()
        Me.btnButtonText = New System.Windows.Forms.Button()
        Me.btnBottomLine = New System.Windows.Forms.Button()
        Me.btnBottomFooter = New System.Windows.Forms.Button()
        Me.btnBottomText = New System.Windows.Forms.Button()
        Me.btnBottomMask = New System.Windows.Forms.Button()
        Me.btnBottomStripes = New System.Windows.Forms.Button()
        Me.btnBottomBackGlow = New System.Windows.Forms.Button()
        Me.btnBottomBack = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenThemeDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Decompressed sleep_LZ|sleep.LZ"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Open sleep.LZ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnWriteColors
        '
        Me.btnWriteColors.Location = New System.Drawing.Point(6, 49)
        Me.btnWriteColors.Name = "btnWriteColors"
        Me.btnWriteColors.Size = New System.Drawing.Size(135, 23)
        Me.btnWriteColors.TabIndex = 5
        Me.btnWriteColors.Text = "Write Colors"
        Me.btnWriteColors.UseVisualStyleBackColor = True
        '
        'btnTopBack
        '
        Me.btnTopBack.Location = New System.Drawing.Point(7, 21)
        Me.btnTopBack.Name = "btnTopBack"
        Me.btnTopBack.Size = New System.Drawing.Size(134, 23)
        Me.btnTopBack.TabIndex = 6
        Me.btnTopBack.Text = "Background"
        Me.btnTopBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnWriteColors)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 173)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Open Theme File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 107)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save Theme File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clrTopLine)
        Me.GroupBox2.Controls.Add(Me.clrTopFooter)
        Me.GroupBox2.Controls.Add(Me.clrTopText)
        Me.GroupBox2.Controls.Add(Me.clrTopHeader)
        Me.GroupBox2.Controls.Add(Me.clrTopStripes)
        Me.GroupBox2.Controls.Add(Me.clrTopBackGlow)
        Me.GroupBox2.Controls.Add(Me.clrTopBack)
        Me.GroupBox2.Controls.Add(Me.btnTopLine)
        Me.GroupBox2.Controls.Add(Me.btnTopFooter)
        Me.GroupBox2.Controls.Add(Me.btnTopText)
        Me.GroupBox2.Controls.Add(Me.btnTopHeader)
        Me.GroupBox2.Controls.Add(Me.btnTopStripes)
        Me.GroupBox2.Controls.Add(Me.btnTopBackGlow)
        Me.GroupBox2.Controls.Add(Me.btnTopBack)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 231)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Top Screen"
        '
        'clrTopLine
        '
        Me.clrTopLine.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopLine.Location = New System.Drawing.Point(147, 197)
        Me.clrTopLine.Name = "clrTopLine"
        Me.clrTopLine.Size = New System.Drawing.Size(43, 23)
        Me.clrTopLine.TabIndex = 19
        '
        'clrTopFooter
        '
        Me.clrTopFooter.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopFooter.Location = New System.Drawing.Point(147, 167)
        Me.clrTopFooter.Name = "clrTopFooter"
        Me.clrTopFooter.Size = New System.Drawing.Size(43, 23)
        Me.clrTopFooter.TabIndex = 18
        '
        'clrTopText
        '
        Me.clrTopText.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopText.Location = New System.Drawing.Point(147, 138)
        Me.clrTopText.Name = "clrTopText"
        Me.clrTopText.Size = New System.Drawing.Size(43, 23)
        Me.clrTopText.TabIndex = 17
        '
        'clrTopHeader
        '
        Me.clrTopHeader.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopHeader.Location = New System.Drawing.Point(147, 108)
        Me.clrTopHeader.Name = "clrTopHeader"
        Me.clrTopHeader.Size = New System.Drawing.Size(43, 23)
        Me.clrTopHeader.TabIndex = 16
        '
        'clrTopStripes
        '
        Me.clrTopStripes.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopStripes.Location = New System.Drawing.Point(147, 79)
        Me.clrTopStripes.Name = "clrTopStripes"
        Me.clrTopStripes.Size = New System.Drawing.Size(43, 23)
        Me.clrTopStripes.TabIndex = 15
        '
        'clrTopBackGlow
        '
        Me.clrTopBackGlow.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopBackGlow.Location = New System.Drawing.Point(147, 49)
        Me.clrTopBackGlow.Name = "clrTopBackGlow"
        Me.clrTopBackGlow.Size = New System.Drawing.Size(43, 23)
        Me.clrTopBackGlow.TabIndex = 14
        '
        'clrTopBack
        '
        Me.clrTopBack.BackColor = System.Drawing.SystemColors.Control
        Me.clrTopBack.Location = New System.Drawing.Point(147, 21)
        Me.clrTopBack.Name = "clrTopBack"
        Me.clrTopBack.Size = New System.Drawing.Size(43, 23)
        Me.clrTopBack.TabIndex = 13
        '
        'btnTopLine
        '
        Me.btnTopLine.Location = New System.Drawing.Point(7, 197)
        Me.btnTopLine.Name = "btnTopLine"
        Me.btnTopLine.Size = New System.Drawing.Size(134, 23)
        Me.btnTopLine.TabIndex = 12
        Me.btnTopLine.Text = "Line"
        Me.btnTopLine.UseVisualStyleBackColor = True
        '
        'btnTopFooter
        '
        Me.btnTopFooter.Location = New System.Drawing.Point(7, 167)
        Me.btnTopFooter.Name = "btnTopFooter"
        Me.btnTopFooter.Size = New System.Drawing.Size(134, 23)
        Me.btnTopFooter.TabIndex = 11
        Me.btnTopFooter.Text = "Footer"
        Me.btnTopFooter.UseVisualStyleBackColor = True
        '
        'btnTopText
        '
        Me.btnTopText.Location = New System.Drawing.Point(7, 138)
        Me.btnTopText.Name = "btnTopText"
        Me.btnTopText.Size = New System.Drawing.Size(134, 23)
        Me.btnTopText.TabIndex = 10
        Me.btnTopText.Text = "Text"
        Me.btnTopText.UseVisualStyleBackColor = True
        '
        'btnTopHeader
        '
        Me.btnTopHeader.Location = New System.Drawing.Point(7, 108)
        Me.btnTopHeader.Name = "btnTopHeader"
        Me.btnTopHeader.Size = New System.Drawing.Size(134, 23)
        Me.btnTopHeader.TabIndex = 9
        Me.btnTopHeader.Text = "Header"
        Me.btnTopHeader.UseVisualStyleBackColor = True
        '
        'btnTopStripes
        '
        Me.btnTopStripes.Location = New System.Drawing.Point(7, 79)
        Me.btnTopStripes.Name = "btnTopStripes"
        Me.btnTopStripes.Size = New System.Drawing.Size(134, 23)
        Me.btnTopStripes.TabIndex = 8
        Me.btnTopStripes.Text = "Stripes"
        Me.btnTopStripes.UseVisualStyleBackColor = True
        '
        'btnTopBackGlow
        '
        Me.btnTopBackGlow.Location = New System.Drawing.Point(7, 50)
        Me.btnTopBackGlow.Name = "btnTopBackGlow"
        Me.btnTopBackGlow.Size = New System.Drawing.Size(134, 23)
        Me.btnTopBackGlow.TabIndex = 7
        Me.btnTopBackGlow.Text = "Background Glow"
        Me.btnTopBackGlow.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.clrBottomFooter)
        Me.GroupBox3.Controls.Add(Me.clrButtonGlow)
        Me.GroupBox3.Controls.Add(Me.clrButtonColor)
        Me.GroupBox3.Controls.Add(Me.clrButtonTextMask)
        Me.GroupBox3.Controls.Add(Me.clrButtonText)
        Me.GroupBox3.Controls.Add(Me.clrBottomLine)
        Me.GroupBox3.Controls.Add(Me.clrBottomText)
        Me.GroupBox3.Controls.Add(Me.clrBottomMask)
        Me.GroupBox3.Controls.Add(Me.clrBottomStripes)
        Me.GroupBox3.Controls.Add(Me.clrBottomBackGlow)
        Me.GroupBox3.Controls.Add(Me.clrBottomBack)
        Me.GroupBox3.Controls.Add(Me.btnButtonGlow)
        Me.GroupBox3.Controls.Add(Me.btnButtonColor)
        Me.GroupBox3.Controls.Add(Me.btnButtonTextMask)
        Me.GroupBox3.Controls.Add(Me.btnButtonText)
        Me.GroupBox3.Controls.Add(Me.btnBottomLine)
        Me.GroupBox3.Controls.Add(Me.btnBottomFooter)
        Me.GroupBox3.Controls.Add(Me.btnBottomText)
        Me.GroupBox3.Controls.Add(Me.btnBottomMask)
        Me.GroupBox3.Controls.Add(Me.btnBottomStripes)
        Me.GroupBox3.Controls.Add(Me.btnBottomBackGlow)
        Me.GroupBox3.Controls.Add(Me.btnBottomBack)
        Me.GroupBox3.Location = New System.Drawing.Point(370, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(198, 352)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bottom Screen"
        '
        'clrBottomFooter
        '
        Me.clrBottomFooter.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomFooter.Location = New System.Drawing.Point(147, 167)
        Me.clrBottomFooter.Name = "clrBottomFooter"
        Me.clrBottomFooter.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomFooter.TabIndex = 28
        '
        'clrButtonGlow
        '
        Me.clrButtonGlow.BackColor = System.Drawing.SystemColors.Control
        Me.clrButtonGlow.Location = New System.Drawing.Point(147, 317)
        Me.clrButtonGlow.Name = "clrButtonGlow"
        Me.clrButtonGlow.Size = New System.Drawing.Size(43, 23)
        Me.clrButtonGlow.TabIndex = 27
        '
        'clrButtonColor
        '
        Me.clrButtonColor.BackColor = System.Drawing.SystemColors.Control
        Me.clrButtonColor.Location = New System.Drawing.Point(147, 287)
        Me.clrButtonColor.Name = "clrButtonColor"
        Me.clrButtonColor.Size = New System.Drawing.Size(43, 23)
        Me.clrButtonColor.TabIndex = 26
        '
        'clrButtonTextMask
        '
        Me.clrButtonTextMask.BackColor = System.Drawing.SystemColors.Control
        Me.clrButtonTextMask.Location = New System.Drawing.Point(147, 257)
        Me.clrButtonTextMask.Name = "clrButtonTextMask"
        Me.clrButtonTextMask.Size = New System.Drawing.Size(43, 23)
        Me.clrButtonTextMask.TabIndex = 25
        '
        'clrButtonText
        '
        Me.clrButtonText.BackColor = System.Drawing.SystemColors.Control
        Me.clrButtonText.Location = New System.Drawing.Point(147, 227)
        Me.clrButtonText.Name = "clrButtonText"
        Me.clrButtonText.Size = New System.Drawing.Size(43, 23)
        Me.clrButtonText.TabIndex = 24
        '
        'clrBottomLine
        '
        Me.clrBottomLine.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomLine.Location = New System.Drawing.Point(147, 197)
        Me.clrBottomLine.Name = "clrBottomLine"
        Me.clrBottomLine.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomLine.TabIndex = 23
        '
        'clrBottomText
        '
        Me.clrBottomText.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomText.Location = New System.Drawing.Point(147, 138)
        Me.clrBottomText.Name = "clrBottomText"
        Me.clrBottomText.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomText.TabIndex = 22
        '
        'clrBottomMask
        '
        Me.clrBottomMask.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomMask.Location = New System.Drawing.Point(147, 108)
        Me.clrBottomMask.Name = "clrBottomMask"
        Me.clrBottomMask.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomMask.TabIndex = 21
        '
        'clrBottomStripes
        '
        Me.clrBottomStripes.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomStripes.Location = New System.Drawing.Point(147, 79)
        Me.clrBottomStripes.Name = "clrBottomStripes"
        Me.clrBottomStripes.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomStripes.TabIndex = 20
        '
        'clrBottomBackGlow
        '
        Me.clrBottomBackGlow.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomBackGlow.Location = New System.Drawing.Point(147, 50)
        Me.clrBottomBackGlow.Name = "clrBottomBackGlow"
        Me.clrBottomBackGlow.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomBackGlow.TabIndex = 19
        '
        'clrBottomBack
        '
        Me.clrBottomBack.BackColor = System.Drawing.SystemColors.Control
        Me.clrBottomBack.Location = New System.Drawing.Point(147, 21)
        Me.clrBottomBack.Name = "clrBottomBack"
        Me.clrBottomBack.Size = New System.Drawing.Size(43, 23)
        Me.clrBottomBack.TabIndex = 18
        '
        'btnButtonGlow
        '
        Me.btnButtonGlow.Location = New System.Drawing.Point(7, 317)
        Me.btnButtonGlow.Name = "btnButtonGlow"
        Me.btnButtonGlow.Size = New System.Drawing.Size(134, 23)
        Me.btnButtonGlow.TabIndex = 17
        Me.btnButtonGlow.Text = "Button Glow"
        Me.btnButtonGlow.UseVisualStyleBackColor = True
        '
        'btnButtonColor
        '
        Me.btnButtonColor.Location = New System.Drawing.Point(7, 287)
        Me.btnButtonColor.Name = "btnButtonColor"
        Me.btnButtonColor.Size = New System.Drawing.Size(134, 23)
        Me.btnButtonColor.TabIndex = 16
        Me.btnButtonColor.Text = "Button Color"
        Me.btnButtonColor.UseVisualStyleBackColor = True
        '
        'btnButtonTextMask
        '
        Me.btnButtonTextMask.Location = New System.Drawing.Point(7, 257)
        Me.btnButtonTextMask.Name = "btnButtonTextMask"
        Me.btnButtonTextMask.Size = New System.Drawing.Size(134, 23)
        Me.btnButtonTextMask.TabIndex = 15
        Me.btnButtonTextMask.Text = "Button Text Mask"
        Me.btnButtonTextMask.UseVisualStyleBackColor = True
        '
        'btnButtonText
        '
        Me.btnButtonText.Location = New System.Drawing.Point(7, 227)
        Me.btnButtonText.Name = "btnButtonText"
        Me.btnButtonText.Size = New System.Drawing.Size(134, 23)
        Me.btnButtonText.TabIndex = 14
        Me.btnButtonText.Text = "Button Text"
        Me.btnButtonText.UseVisualStyleBackColor = True
        '
        'btnBottomLine
        '
        Me.btnBottomLine.Location = New System.Drawing.Point(7, 197)
        Me.btnBottomLine.Name = "btnBottomLine"
        Me.btnBottomLine.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomLine.TabIndex = 13
        Me.btnBottomLine.Text = "Line"
        Me.btnBottomLine.UseVisualStyleBackColor = True
        '
        'btnBottomFooter
        '
        Me.btnBottomFooter.Location = New System.Drawing.Point(7, 167)
        Me.btnBottomFooter.Name = "btnBottomFooter"
        Me.btnBottomFooter.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomFooter.TabIndex = 12
        Me.btnBottomFooter.Text = "Footer"
        Me.btnBottomFooter.UseVisualStyleBackColor = True
        '
        'btnBottomText
        '
        Me.btnBottomText.Location = New System.Drawing.Point(7, 138)
        Me.btnBottomText.Name = "btnBottomText"
        Me.btnBottomText.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomText.TabIndex = 11
        Me.btnBottomText.Text = "Text"
        Me.btnBottomText.UseVisualStyleBackColor = True
        '
        'btnBottomMask
        '
        Me.btnBottomMask.Location = New System.Drawing.Point(7, 108)
        Me.btnBottomMask.Name = "btnBottomMask"
        Me.btnBottomMask.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomMask.TabIndex = 10
        Me.btnBottomMask.Text = "Mask"
        Me.btnBottomMask.UseVisualStyleBackColor = True
        '
        'btnBottomStripes
        '
        Me.btnBottomStripes.Location = New System.Drawing.Point(7, 79)
        Me.btnBottomStripes.Name = "btnBottomStripes"
        Me.btnBottomStripes.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomStripes.TabIndex = 9
        Me.btnBottomStripes.Text = "Stripes"
        Me.btnBottomStripes.UseVisualStyleBackColor = True
        '
        'btnBottomBackGlow
        '
        Me.btnBottomBackGlow.Location = New System.Drawing.Point(7, 50)
        Me.btnBottomBackGlow.Name = "btnBottomBackGlow"
        Me.btnBottomBackGlow.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomBackGlow.TabIndex = 8
        Me.btnBottomBackGlow.Text = "Background Glow"
        Me.btnBottomBackGlow.UseVisualStyleBackColor = True
        '
        'btnBottomBack
        '
        Me.btnBottomBack.Location = New System.Drawing.Point(7, 21)
        Me.btnBottomBack.Name = "btnBottomBack"
        Me.btnBottomBack.Size = New System.Drawing.Size(134, 23)
        Me.btnBottomBack.TabIndex = 7
        Me.btnBottomBack.Text = "Background"
        Me.btnBottomBack.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Sleep_LZ Theme|*.slzt"
        '
        'OpenThemeDialog
        '
        Me.OpenThemeDialog.FileName = "OpenFileDialog2"
        Me.OpenThemeDialog.Filter = "Sleep_LZ Theme|*.slzt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 375)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sleep_LZ Color Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents btnWriteColors As Button
    Friend WithEvents btnTopBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTopStripes As Button
    Friend WithEvents btnTopBackGlow As Button
    Friend WithEvents clrTopLine As Label
    Friend WithEvents clrTopFooter As Label
    Friend WithEvents clrTopText As Label
    Friend WithEvents clrTopHeader As Label
    Friend WithEvents clrTopStripes As Label
    Friend WithEvents clrTopBackGlow As Label
    Friend WithEvents clrTopBack As Label
    Friend WithEvents btnTopLine As Button
    Friend WithEvents btnTopFooter As Button
    Friend WithEvents btnTopText As Button
    Friend WithEvents btnTopHeader As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBottomBack As Button
    Friend WithEvents clrButtonGlow As Label
    Friend WithEvents clrButtonColor As Label
    Friend WithEvents clrButtonTextMask As Label
    Friend WithEvents clrButtonText As Label
    Friend WithEvents clrBottomLine As Label
    Friend WithEvents clrBottomText As Label
    Friend WithEvents clrBottomMask As Label
    Friend WithEvents clrBottomStripes As Label
    Friend WithEvents clrBottomBackGlow As Label
    Friend WithEvents clrBottomBack As Label
    Friend WithEvents btnButtonGlow As Button
    Friend WithEvents btnButtonColor As Button
    Friend WithEvents btnButtonTextMask As Button
    Friend WithEvents btnButtonText As Button
    Friend WithEvents btnBottomLine As Button
    Friend WithEvents btnBottomFooter As Button
    Friend WithEvents btnBottomText As Button
    Friend WithEvents btnBottomMask As Button
    Friend WithEvents btnBottomStripes As Button
    Friend WithEvents btnBottomBackGlow As Button
    Friend WithEvents clrBottomFooter As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenThemeDialog As OpenFileDialog
End Class
