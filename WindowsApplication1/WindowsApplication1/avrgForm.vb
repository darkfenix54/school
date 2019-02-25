Option Strict On

' Name: Kevin Romero
' ID: 100686399
' Date: 2019-02-22
' Project: Lab 3
' Description: This program validates user input of 3 employee, Promps if error
'              Then adds 7 day average shipping for each employee, Finally it displays
'              The average Units Shipped for the company. 


Public Class averageFrm
    'Declare Vars
    Dim unitShipped(2, 6) As Integer
    Dim average(3) As Double
    Dim buffer As String
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim bool As Boolean = False


    ''This function validates input and returns a string
    Private Function validation() As String
        ''this adds to the x in array
        If y = 7 Then
            x += 1
            y = 0
        End If

        'Validate if Integer
        If Integer.TryParse(buffer, unitShipped(x, y)) Then
            'Validate if between 0-1000
            If unitShipped(x, y) >= 0 And unitShipped(x, y) <= 1000 Then
                ''This is so the calc is done in it's own function
                ''if bool is true then it will  be store in it's appropriate array
                bool = True
            Else
                ''If not between 0 - 1000 false display error
                MsgBox("INPUT INVALID!" & vbCrLf &
                       "Your number of units for Day: " & x & " must be between 0 - 1000!")

                bool = False
            End If

        Else
            ''if not int then display error
            MsgBox("INPUT INVALID!" & vbCrLf &
                   "Your input must a whole number between 0 - 1000!")

            bool = False
        End If

        ''return string to display output
        Return String.Format("{0:0}", unitShipped(x, y)) & Environment.NewLine
    End Function

    ''This function calculates the average units shipped per employee
    Private Function averageDisplay() As String
        'add units in array
        For i = 0 To (y - 1) Step 1
            average(x) += unitShipped(x, i)
        Next
        'get the average 
        average(x) = average(x) / 7

        'return appropriate string
        Return String.Format("{0:0.00}", average(x))
    End Function

    'This sub handles main events
    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        buffer = inputBox.Text
        'Send buffer to be validated
        validation()

        'ALL comments in first if apply to everything inside this loop
        If bool = True And x = 0 Then
            'output string 
            dailyUnits1.Text &= validation()
            'add 1 more to y
            y += 1
            'If y is 7 then display average
            If y = 7 Then
                empAvg1.Text = averageDisplay()

            End If
        ElseIf bool = True And x = 1 Then
            dailyUnits2.Text &= validation()
            y += 1
            If y = 7 Then
                empAvg2.Text = averageDisplay()
            End If

        ElseIf bool = True And x = 2 Then
            dailyUnits3.Text &= validation()
            y += 1
            If y = 7 Then
                empAvg3.Text = averageDisplay()
                'get the total average
                For i = 0 To 2 Step 1
                    average(3) += average(i)
                Next
                'display the final average
                average(3) = average(3) / 3
                totalAvg.Text = String.Format("{0:0.00}", average(3))
                dayLb.Text = "Done!"

                ''set everything to read only.
                inputBox.Clear()
                enterBtn.Enabled = False
                inputBox.ReadOnly = True
            End If
        End If

        'display the day
        If x <= 2 And y <= 7 Then
            dayLb.Text = String.Format("Day: {0}", (y + 1))
        End If

        'clear inputbox everytime they hit enter so not accidental enters
        inputBox.Clear()
    End Sub

    'Exit button
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub inputBox_Leave(sender As Object, e As EventArgs) Handles inputBox.Leave
    End Sub

    'Reset everything
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        'Reset variables
        ReDim unitShipped(2, 6)
        ReDim average(3)
        buffer = Nothing
        x = 0
        y = 0
        bool = False

        'clear textboxes
        For Each txt In {empAvg1, empAvg2, empAvg3, totalAvg, dailyUnits1, dailyUnits2, dailyUnits3}
            txt.Clear()
        Next

        'everything good as new.
        dayLb.Text = "Day: 1"
        enterBtn.Enabled = True
        inputBox.ReadOnly = False
    End Sub
End Class
