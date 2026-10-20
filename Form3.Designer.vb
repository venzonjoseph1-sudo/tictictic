<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guidelines
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
        PLAY = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' PLAY
        ' 
        PLAY.BackColor = Color.MidnightBlue
        PLAY.Font = New Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PLAY.ForeColor = SystemColors.ButtonHighlight
        PLAY.Location = New Point(1097, 662)
        PLAY.Name = "PLAY"
        PLAY.Size = New Size(226, 57)
        PLAY.TabIndex = 9
        PLAY.Text = "PLAY"
        PLAY.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 90F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(525, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 111)
        Label1.TabIndex = 10
        Label1.Text = "Guidelines"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(155, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 21)
        Label2.TabIndex = 11
        Label2.Text = "1. 2 players to play TicTac Toe "
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MidnightBlue
        Button2.Font = New Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(854, 661)
        Button2.Name = "Button2"
        Button2.Size = New Size(226, 57)
        Button2.TabIndex = 12
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(155, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(998, 21)
        Label5.TabIndex = 15
        Label5.Text = "2. There are Five (5) rounds to play, and the player who got the highest score will be declared as a winner"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(155, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(16, 21)
        Label6.TabIndex = 16
        Label6.Text = " "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(155, 253)
        Label7.Name = "Label7"
        Label7.Size = New Size(1008, 21)
        Label7.TabIndex = 17
        Label7.Text = "4. 1 point rewarded for the player who successfully make a diagonal, horizontal, or vertical lines (ALL X/Y)" & vbCrLf
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(155, 232)
        Label8.Name = "Label8"
        Label8.Size = New Size(799, 21)
        Label8.TabIndex = 18
        Label8.Text = "3. The player who wins 3 times straight will be automatically declared as the winner"
        ' 
        ' Guidelines
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1352, 749)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PLAY)
        Name = "Guidelines"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PLAY As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
