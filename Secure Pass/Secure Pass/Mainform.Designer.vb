<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CheckBox1 = New CheckBox()
        DataGridView1 = New DataGridView()
        AccountName = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 0
        Label1.Text = "Search account"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(234, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Find account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(287, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 4
        Label2.Text = "website"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(287, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 5
        Label3.Text = "Username"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(393, 108)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(393, 155)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(393, 198)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 8
        TextBox4.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(290, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(290, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 10
        Label5.Text = "Note"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(393, 256)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(235, 109)
        TextBox5.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(287, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 12
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(418, 383)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(553, 383)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 14
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(524, 206)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(85, 19)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Show/Hide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {AccountName})
        DataGridView1.Location = New Point(12, 96)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(253, 342)
        DataGridView1.TabIndex = 16
        ' 
        ' AccountName
        ' 
        AccountName.HeaderText = "Account Name"
        AccountName.Name = "AccountName"
        AccountName.ReadOnly = True
        AccountName.Width = 180
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(656, 450)
        Controls.Add(DataGridView1)
        Controls.Add(CheckBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "MainForm"
        Text = "Mainform"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AccountName As DataGridViewTextBoxColumn
End Class
