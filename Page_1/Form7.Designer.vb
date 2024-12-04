<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Button5 = New Button()
        Button2 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(451, 385)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 28)
        Button5.TabIndex = 17
        Button5.Text = "Close"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(265, 385)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 28)
        Button2.TabIndex = 19
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(117, 19)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(599, 344)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(107, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(621, 367)
        Panel1.TabIndex = 22
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
