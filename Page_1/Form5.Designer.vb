<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        txtImagePath = New TextBox()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        Button2 = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button6 = New Button()
        TextBox7 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(292, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 25)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN PAGE "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(624, 183)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(240, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 28)
        Button1.TabIndex = 8
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(466, 261)
        Button4.Name = "Button4"
        Button4.Size = New Size(102, 28)
        Button4.TabIndex = 11
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(txtImagePath)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(43, 295)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(346, 381)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"T-Shirts", "Jeans", "Sneakers", "Watches"})
        ComboBox1.Location = New Point(20, 149)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(169, 28)
        ComboBox1.TabIndex = 19
        ' 
        ' txtImagePath
        ' 
        txtImagePath.Location = New Point(195, 286)
        txtImagePath.Name = "txtImagePath"
        txtImagePath.Size = New Size(143, 23)
        txtImagePath.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(23, 245)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(166, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(195, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 28)
        Button3.TabIndex = 10
        Button3.Text = "Add Product"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(33, 199)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 28)
        Button2.TabIndex = 9
        Button2.Text = "Select Image"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(21, 99)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Enter product quantity"
        TextBox3.Size = New Size(169, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(20, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter product price"
        TextBox2.Size = New Size(169, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(21, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter product name"
        TextBox1.Size = New Size(169, 23)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Location = New Point(414, 295)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(208, 122)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(52, 61)
        Button6.Name = "Button6"
        Button6.Size = New Size(102, 55)
        Button6.TabIndex = 21
        Button6.Text = "Delete Product"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(21, 22)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Enter product ID"
        TextBox7.Size = New Size(169, 23)
        TextBox7.TabIndex = 18
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(694, 9)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 28)
        Button5.TabIndex = 15
        Button5.Text = "Log Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 685)
        Controls.Add(Button5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
