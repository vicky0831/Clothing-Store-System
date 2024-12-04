<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox6 = New TextBox()
        Label4 = New Label()
        TextBox7 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(326, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 28)
        Button1.TabIndex = 18
        Button1.Text = "PROCEED"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(554, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(178, 39)
        Button2.TabIndex = 19
        Button2.Text = "Calculate Distance"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 21)
        Label1.TabIndex = 20
        Label1.Text = "Address To Ship :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(113, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 26)
        TextBox1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 19)
        Label2.TabIndex = 26
        Label2.Text = "HouseNo :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 19)
        Label3.TabIndex = 28
        Label3.Text = "Street Name :"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(145, 140)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(227, 26)
        TextBox6.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 19)
        Label4.TabIndex = 30
        Label4.Text = "City :"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(83, 199)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(168, 26)
        TextBox7.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(26, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 19)
        Label5.TabIndex = 32
        Label5.Text = "Postcode:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(122, 251)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(157, 26)
        TextBox2.TabIndex = 31
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(23, 318)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 19)
        Label6.TabIndex = 34
        Label6.Text = "State:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(83, 315)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(168, 26)
        TextBox3.TabIndex = 33
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox7)
        Controls.Add(Label3)
        Controls.Add(TextBox6)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
