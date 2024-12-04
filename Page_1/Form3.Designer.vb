<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(132, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 29)
        Label1.TabIndex = 1
        Label1.Text = "USER LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(19, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 25)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(185, 104)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Your Username"
        TextBox1.Size = New Size(195, 30)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(185, 167)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "Enter Your Password"
        TextBox2.Size = New Size(195, 30)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 25)
        Label3.TabIndex = 4
        Label3.Text = "PASSWORD:"
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold)
        Button1.Location = New Point(132, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 39)
        Button1.TabIndex = 7
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.pngtree_yellow_background_with_3d_t_shirts_rendered_image_3711716
        PictureBox1.Image = My.Resources.Resources.image_removebg_preview__13_1
        PictureBox1.Location = New Point(351, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(387, 340)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.image_removebg_preview__14_
        PictureBox2.Location = New Point(5, 317)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(712, 68)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.LOGO_FROD_removebg_preview
        PictureBox3.Location = New Point(-10, -16)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(119, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(729, 385)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
End Class
