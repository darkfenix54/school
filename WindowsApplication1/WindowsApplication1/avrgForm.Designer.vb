<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class averageFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.dayLb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dailyUnits1 = New System.Windows.Forms.TextBox()
        Me.dailyUnits2 = New System.Windows.Forms.TextBox()
        Me.dailyUnits3 = New System.Windows.Forms.TextBox()
        Me.emp1 = New System.Windows.Forms.Label()
        Me.emp2 = New System.Windows.Forms.Label()
        Me.emp3 = New System.Windows.Forms.Label()
        Me.empAvg1 = New System.Windows.Forms.TextBox()
        Me.empAvg2 = New System.Windows.Forms.TextBox()
        Me.empAvg3 = New System.Windows.Forms.TextBox()
        Me.totalAvg = New System.Windows.Forms.TextBox()
        Me.enterBtn = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputBox.Location = New System.Drawing.Point(63, 45)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(94, 22)
        Me.inputBox.TabIndex = 0
        Me.toolTip.SetToolTip(Me.inputBox, "This input box accepts the units shipped per day. Please ensure your input is num" &
        "eric!")
        '
        'dayLb
        '
        Me.dayLb.AutoSize = True
        Me.dayLb.Location = New System.Drawing.Point(13, 13)
        Me.dayLb.Name = "dayLb"
        Me.dayLb.Size = New System.Drawing.Size(49, 17)
        Me.dayLb.TabIndex = 1
        Me.dayLb.Text = "Day: 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Units:"
        '
        'dailyUnits1
        '
        Me.dailyUnits1.BackColor = System.Drawing.Color.White
        Me.dailyUnits1.Location = New System.Drawing.Point(12, 103)
        Me.dailyUnits1.Multiline = True
        Me.dailyUnits1.Name = "dailyUnits1"
        Me.dailyUnits1.ReadOnly = True
        Me.dailyUnits1.Size = New System.Drawing.Size(145, 187)
        Me.dailyUnits1.TabIndex = 3
        Me.toolTip.SetToolTip(Me.dailyUnits1, "This textbox displays the units entered per day for Employee 1")
        '
        'dailyUnits2
        '
        Me.dailyUnits2.BackColor = System.Drawing.Color.White
        Me.dailyUnits2.Location = New System.Drawing.Point(172, 103)
        Me.dailyUnits2.Multiline = True
        Me.dailyUnits2.Name = "dailyUnits2"
        Me.dailyUnits2.ReadOnly = True
        Me.dailyUnits2.Size = New System.Drawing.Size(145, 187)
        Me.dailyUnits2.TabIndex = 4
        Me.toolTip.SetToolTip(Me.dailyUnits2, "This textbox displays the units entered per day for Employee 2")
        '
        'dailyUnits3
        '
        Me.dailyUnits3.BackColor = System.Drawing.Color.White
        Me.dailyUnits3.Location = New System.Drawing.Point(330, 103)
        Me.dailyUnits3.Multiline = True
        Me.dailyUnits3.Name = "dailyUnits3"
        Me.dailyUnits3.ReadOnly = True
        Me.dailyUnits3.Size = New System.Drawing.Size(145, 187)
        Me.dailyUnits3.TabIndex = 5
        Me.toolTip.SetToolTip(Me.dailyUnits3, "This textbox displays the units entered per day for Employee 3")
        '
        'emp1
        '
        Me.emp1.AutoSize = True
        Me.emp1.Location = New System.Drawing.Point(38, 80)
        Me.emp1.Name = "emp1"
        Me.emp1.Size = New System.Drawing.Size(82, 17)
        Me.emp1.TabIndex = 6
        Me.emp1.Text = "Employee 1"
        '
        'emp2
        '
        Me.emp2.AutoSize = True
        Me.emp2.Location = New System.Drawing.Point(202, 80)
        Me.emp2.Name = "emp2"
        Me.emp2.Size = New System.Drawing.Size(82, 17)
        Me.emp2.TabIndex = 7
        Me.emp2.Text = "Employee 2"
        '
        'emp3
        '
        Me.emp3.AutoSize = True
        Me.emp3.Location = New System.Drawing.Point(360, 80)
        Me.emp3.Name = "emp3"
        Me.emp3.Size = New System.Drawing.Size(82, 17)
        Me.emp3.TabIndex = 8
        Me.emp3.Text = "Employee 3"
        '
        'empAvg1
        '
        Me.empAvg1.BackColor = System.Drawing.SystemColors.Menu
        Me.empAvg1.Location = New System.Drawing.Point(12, 296)
        Me.empAvg1.Name = "empAvg1"
        Me.empAvg1.ReadOnly = True
        Me.empAvg1.Size = New System.Drawing.Size(145, 22)
        Me.empAvg1.TabIndex = 9
        Me.empAvg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.empAvg1, "This textbox displays the average units shipped for Employee 1")
        '
        'empAvg2
        '
        Me.empAvg2.BackColor = System.Drawing.SystemColors.Menu
        Me.empAvg2.Location = New System.Drawing.Point(172, 296)
        Me.empAvg2.Name = "empAvg2"
        Me.empAvg2.ReadOnly = True
        Me.empAvg2.Size = New System.Drawing.Size(145, 22)
        Me.empAvg2.TabIndex = 10
        Me.empAvg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.empAvg2, "This textbox displays the average units shipped for Employee 2")
        '
        'empAvg3
        '
        Me.empAvg3.BackColor = System.Drawing.SystemColors.Menu
        Me.empAvg3.Location = New System.Drawing.Point(330, 296)
        Me.empAvg3.Name = "empAvg3"
        Me.empAvg3.ReadOnly = True
        Me.empAvg3.Size = New System.Drawing.Size(145, 22)
        Me.empAvg3.TabIndex = 11
        Me.empAvg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.empAvg3, "This textbox displays the average units shipped for Employee 3")
        '
        'totalAvg
        '
        Me.totalAvg.BackColor = System.Drawing.SystemColors.Menu
        Me.totalAvg.Location = New System.Drawing.Point(12, 325)
        Me.totalAvg.Name = "totalAvg"
        Me.totalAvg.ReadOnly = True
        Me.totalAvg.Size = New System.Drawing.Size(463, 22)
        Me.totalAvg.TabIndex = 12
        Me.totalAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.totalAvg, "This textbox displays the average units shipped for all employees")
        '
        'enterBtn
        '
        Me.enterBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.enterBtn.Location = New System.Drawing.Point(13, 354)
        Me.enterBtn.Name = "enterBtn"
        Me.enterBtn.Size = New System.Drawing.Size(144, 41)
        Me.enterBtn.TabIndex = 13
        Me.enterBtn.Text = "&Enter"
        Me.toolTip.SetToolTip(Me.enterBtn, "This button will save the data you entered if correct")
        Me.enterBtn.UseVisualStyleBackColor = True
        '
        'resetbtn
        '
        Me.resetbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.resetbtn.Location = New System.Drawing.Point(172, 354)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(145, 41)
        Me.resetbtn.TabIndex = 14
        Me.resetbtn.Text = "&Reset"
        Me.toolTip.SetToolTip(Me.resetbtn, "This button will reset everything in your program.")
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(330, 354)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(145, 41)
        Me.exitBtn.TabIndex = 15
        Me.exitBtn.Text = "&Exit"
        Me.toolTip.SetToolTip(Me.exitBtn, "This button will exit your program")
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipTitle = "Info:"
        '
        'averageFrm
        '
        Me.AcceptButton = Me.enterBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.resetbtn
        Me.ClientSize = New System.Drawing.Size(487, 407)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.enterBtn)
        Me.Controls.Add(Me.totalAvg)
        Me.Controls.Add(Me.empAvg3)
        Me.Controls.Add(Me.empAvg2)
        Me.Controls.Add(Me.empAvg1)
        Me.Controls.Add(Me.emp3)
        Me.Controls.Add(Me.emp2)
        Me.Controls.Add(Me.emp1)
        Me.Controls.Add(Me.dailyUnits3)
        Me.Controls.Add(Me.dailyUnits2)
        Me.Controls.Add(Me.dailyUnits1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dayLb)
        Me.Controls.Add(Me.inputBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "averageFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox As TextBox
    Friend WithEvents dayLb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dailyUnits1 As TextBox
    Friend WithEvents dailyUnits2 As TextBox
    Friend WithEvents dailyUnits3 As TextBox
    Friend WithEvents emp1 As Label
    Friend WithEvents emp2 As Label
    Friend WithEvents emp3 As Label
    Friend WithEvents empAvg1 As TextBox
    Friend WithEvents empAvg2 As TextBox
    Friend WithEvents empAvg3 As TextBox
    Friend WithEvents totalAvg As TextBox
    Friend WithEvents enterBtn As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents toolTip As ToolTip
End Class
