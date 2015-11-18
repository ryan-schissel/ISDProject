<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Certifications = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchEmployees = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AddEmployee = New System.Windows.Forms.Button()
        Me.UpdateEmployee = New System.Windows.Forms.Button()
        Me.RemoveEmployee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "First Name"
        '
        'Certifications
        '
        Me.Certifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Certifications.Location = New System.Drawing.Point(492, 9)
        Me.Certifications.Name = "Certifications"
        Me.Certifications.Size = New System.Drawing.Size(106, 23)
        Me.Certifications.TabIndex = 6
        Me.Certifications.Text = "Certifications"
        Me.Certifications.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(98, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Address"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(98, 103)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(98, 132)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(170, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Postal Code"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(98, 160)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(170, 22)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(98, 189)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(170, 22)
        Me.TextBox7.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Mobile Phone Number"
        '
        'SearchEmployees
        '
        Me.SearchEmployees.Location = New System.Drawing.Point(277, 9)
        Me.SearchEmployees.Name = "SearchEmployees"
        Me.SearchEmployees.Size = New System.Drawing.Size(75, 23)
        Me.SearchEmployees.TabIndex = 17
        Me.SearchEmployees.Text = "Search"
        Me.SearchEmployees.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(428, 40)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(170, 22)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(428, 67)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(170, 22)
        Me.TextBox9.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(278, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Home Phone Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(354, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Hire Date"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(428, 100)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(170, 22)
        Me.TextBox10.TabIndex = 22
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(428, 128)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(170, 22)
        Me.TextBox11.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(305, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Termination Date"
        '
        'AddEmployee
        '
        Me.AddEmployee.Location = New System.Drawing.Point(428, 160)
        Me.AddEmployee.Name = "AddEmployee"
        Me.AddEmployee.Size = New System.Drawing.Size(75, 23)
        Me.AddEmployee.TabIndex = 25
        Me.AddEmployee.Text = "Add"
        Me.AddEmployee.UseVisualStyleBackColor = True
        '
        'UpdateEmployee
        '
        Me.UpdateEmployee.Location = New System.Drawing.Point(509, 159)
        Me.UpdateEmployee.Name = "UpdateEmployee"
        Me.UpdateEmployee.Size = New System.Drawing.Size(75, 23)
        Me.UpdateEmployee.TabIndex = 26
        Me.UpdateEmployee.Text = "Update"
        Me.UpdateEmployee.UseVisualStyleBackColor = True
        '
        'RemoveEmployee
        '
        Me.RemoveEmployee.Location = New System.Drawing.Point(471, 189)
        Me.RemoveEmployee.Name = "RemoveEmployee"
        Me.RemoveEmployee.Size = New System.Drawing.Size(75, 23)
        Me.RemoveEmployee.TabIndex = 27
        Me.RemoveEmployee.Text = "Remove"
        Me.RemoveEmployee.UseVisualStyleBackColor = True
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(609, 222)
        Me.Controls.Add(Me.RemoveEmployee)
        Me.Controls.Add(Me.UpdateEmployee)
        Me.Controls.Add(Me.AddEmployee)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.SearchEmployees)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Certifications)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employees"
        Me.Text = "Employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Certifications As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchEmployees As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents AddEmployee As Button
    Friend WithEvents UpdateEmployee As Button
    Friend WithEvents RemoveEmployee As Button
End Class
