<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secondForm
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
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MidnightBlue
        Button1.Font = New Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(1120, 669)
        Button1.Name = "Button1"
        Button1.Size = New Size(226, 57)
        Button1.TabIndex = 10
        Button1.Text = "CONTINUE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("STZhongsong", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(610, 589)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 21)
        Label4.TabIndex = 16
        Label4.Text = "Enter Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("STZhongsong", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(610, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 21)
        Label3.TabIndex = 15
        Label3.Text = "Enter Username"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Image = My.Resources.Resources.f13d2252_aed3_4981_a80d_84e0e3723437
        PictureBox3.Location = New Point(145, 440)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(206, 192)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Cascadia Code SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(400, 215)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(582, 42)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Cascadia Code SemiBold", 20.25F, FontStyle.Bold)
        TextBox1.Location = New Point(400, 530)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(582, 42)
        TextBox1.TabIndex = 12
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources._87cc1ae0_930f_4f98_ae1a_e6a798341047
        PictureBox4.Image = My.Resources.Resources._87cc1ae0_930f_4f98_ae1a_e6a798341047
        PictureBox4.Location = New Point(145, 124)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(206, 192)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(199, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 34)
        Label1.TabIndex = 17
        Label1.Text = "Player 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palace Script MT", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(199, 403)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 34)
        Label2.TabIndex = 18
        Label2.Text = "Player 2"
        ' 
        ' secondForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1370, 749)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox4)
        Controls.Add(Button1)
        Name = "secondForm"
        Text = "Form2"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
