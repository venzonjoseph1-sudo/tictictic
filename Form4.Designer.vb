<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAME
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
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button8 = New Button()
        Button9 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(49, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1273, 93)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._8ca02b84_7373_49c6_a208_71b4c9ba4522
        PictureBox3.Location = New Point(447, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(388, 81)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MidnightBlue
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(1105, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 38)
        Label4.TabIndex = 17
        Label4.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MidnightBlue
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(126, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 38)
        Label3.TabIndex = 14
        Label3.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palace Script MT", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(1046, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 32)
        Label2.TabIndex = 16
        Label2.Text = "Player 2 (O)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(114, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 32)
        Label1.TabIndex = 14
        Label1.Text = "Player 1 (X)"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.f13d2252_aed3_4981_a80d_84e0e3723437
        PictureBox2.Location = New Point(1156, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(102, 79)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._87cc1ae0_930f_4f98_ae1a_e6a798341047
        PictureBox1.Location = New Point(6, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 79)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(316, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(742, 597)
        Panel2.TabIndex = 1
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.White
        Button8.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(280, 396)
        Button8.Name = "Button8"
        Button8.Size = New Size(182, 178)
        Button8.TabIndex = 10
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.White
        Button9.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.Location = New Point(468, 396)
        Button9.Name = "Button9"
        Button9.Size = New Size(182, 178)
        Button9.TabIndex = 9
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.White
        Button6.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(468, 210)
        Button6.Name = "Button6"
        Button6.Size = New Size(182, 178)
        Button6.TabIndex = 8
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.White
        Button7.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(90, 396)
        Button7.Name = "Button7"
        Button7.Size = New Size(182, 178)
        Button7.TabIndex = 7
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(280, 209)
        Button5.Name = "Button5"
        Button5.Size = New Size(182, 178)
        Button5.TabIndex = 6
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(92, 209)
        Button4.Name = "Button4"
        Button4.Size = New Size(182, 178)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(468, 24)
        Button3.Name = "Button3"
        Button3.Size = New Size(182, 178)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(280, 23)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 178)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Elephant", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(92, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 178)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.MidnightBlue
        Button10.Font = New Font("Engravers MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = SystemColors.ButtonHighlight
        Button10.Location = New Point(1110, 542)
        Button10.Name = "Button10"
        Button10.Size = New Size(212, 57)
        Button10.TabIndex = 11
        Button10.Text = "RESET"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.MidnightBlue
        Button11.Font = New Font("Engravers MT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.ButtonHighlight
        Button11.Location = New Point(1110, 605)
        Button11.Name = "Button11"
        Button11.Size = New Size(212, 57)
        Button11.TabIndex = 12
        Button11.Text = "NEW GAME"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.MidnightBlue
        Button12.Font = New Font("Engravers MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.ButtonHighlight
        Button12.Location = New Point(1110, 670)
        Button12.Name = "Button12"
        Button12.Size = New Size(212, 57)
        Button12.TabIndex = 13
        Button12.Text = "EXIT"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' GAME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1370, 749)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button10)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "GAME"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
