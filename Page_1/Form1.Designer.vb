<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label4 = New Label()
        Timer3 = New Timer(components)
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 48F, FontStyle.Bold)
        Label1.Location = New Point(101, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 85)
        Label1.TabIndex = 0
        Label1.Text = """Test1"""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 20.25F)
        Label2.Location = New Point(252, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 29)
        Label2.TabIndex = 1
        Label2.Text = "Welcome To"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(217, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(238, 29)
        Label3.TabIndex = 2
        Label3.Text = "Official Application"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(606, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(252, 451)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1500
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 3500
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe Print", 18F, FontStyle.Bold)
        Label4.Location = New Point(80, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(509, 43)
        Label4.TabIndex = 4
        Label4.Text = "Life isn’t perfect, but your outfit can be."
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold)
        Button1.Location = New Point(237, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 65)
        Button1.TabIndex = 5
        Button1.Text = "SHOP NOW"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.location_vector_removebg_preview__1_
        PictureBox2.Location = New Point(12, 410)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(63, 63)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 21)
        Label5.TabIndex = 7
        Label5.Text = "Location"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.LOGO_FROD_removebg_preview
        PictureBox3.Location = New Point(-10, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(128, 118)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 475)
        Controls.Add(PictureBox3)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox

End Class
