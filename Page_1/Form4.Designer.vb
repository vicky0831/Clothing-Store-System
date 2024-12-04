<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button5 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(12, 166)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1224, 413)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(1142, 12)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 34)
        Button5.TabIndex = 16
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image_removebg_preview__22_
        PictureBox1.Location = New Point(1048, -11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 48F, FontStyle.Bold)
        Label1.Location = New Point(402, -2)
        Label1.Margin = New Padding(300, 0, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 85)
        Label1.TabIndex = 18
        Label1.Text = "FROD JERRY"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Cyan
        Label2.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(315, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 44)
        Label2.TabIndex = 19
        Label2.Text = "Jeans"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Cyan
        Label3.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 44)
        Label3.TabIndex = 20
        Label3.Text = "T-Shirts"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Cyan
        Label5.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(759, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 44)
        Label5.TabIndex = 22
        Label5.Text = "Sneakers"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Cyan
        Label6.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(978, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 44)
        Label6.TabIndex = 23
        Label6.Text = "Watches"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.RosyBrown
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(80, 86)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1067, 74)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.LOGO_FROD_removebg_preview
        PictureBox2.Location = New Point(-5, -11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 113)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 608)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Button5)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
