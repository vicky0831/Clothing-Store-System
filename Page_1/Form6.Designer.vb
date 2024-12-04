<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        DataGridView1 = New DataGridView()
        SqlDataSourceEnumeratorBindingSource = New BindingSource(components)
        Button5 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SqlDataSourceEnumeratorBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(619, 309)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(47, 12)
        DataGridView1.TabIndex = 0
        ' 
        ' SqlDataSourceEnumeratorBindingSource
        ' 
        SqlDataSourceEnumeratorBindingSource.DataSource = GetType(Microsoft.Data.Sql.SqlDataSourceEnumerator)
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(694, 12)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 28)
        Button5.TabIndex = 16
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(327, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 28)
        Button1.TabIndex = 17
        Button1.Text = "CHECK OUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(20, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(553, 272)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(93, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(595, 298)
        Panel1.TabIndex = 19
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 420)
        Controls.Add(Button1)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(SqlDataSourceEnumeratorBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SqlDataSourceEnumeratorBindingSource As BindingSource
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
