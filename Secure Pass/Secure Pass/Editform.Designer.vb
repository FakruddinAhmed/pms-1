<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editform
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
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 0
        Label1.Text = "Account"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(289, 43)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 23)
        Button1.TabIndex = 1
        Button1.Text = "search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(95, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 3
        Label2.Text = "Website"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 5
        Label4.Text = "Note"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(95, 97)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(95, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(175, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(95, 205)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(175, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 9
        Label5.Text = "Password"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(95, 256)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(269, 107)
        TextBox5.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(51, 385)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 23)
        Button2.TabIndex = 11
        Button2.Text = "update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Editform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 431)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Editform"
        Text = "Editform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
End Class
