'Name: Connor Simmonds-Parke
'Student ID: 100344939
'Project: SemesterAverageCalculator
'Date: Feb 21, 2018
'Description: A program that takes user input into each textbox and displays the letter grade. Once all the
'             text boxes are full, the user can hit the accept button To calculate the average Of all the grades
'             And display the average grade letter. This program also uses validation And an error box label
'             to help the user understand what they need to input Or what Is missing.

Option Strict On

Public Class frmSemesterAverageCalculator
    ''' <summary>
    ''' A select statement that returns the letter grade depending on the input.
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Private Function Grade(ByVal userInput As Double) As String

        Select Case userInput

            Case < 50
                Return "F"
            Case 50 To 52
                Return "D-"
            Case 53 To 56
                Return "D"
            Case 57 To 59
                Return "D+"
            Case 60 To 62
                Return "C-"
            Case 63 To 65
                Return "C"
            Case 66 To 69
                Return "C+"
            Case 70 To 72
                Return "B-"
            Case 73 To 76
                Return "B"
            Case 77 To 79
                Return "B+"
            Case 80 To 84
                Return "A-"
            Case 85 To 89
                Return "A"
            Case > 90
                Return "A+"

        End Select

    End Function
    ''' <summary>
    ''' Checks to see if the input is a number and within range. If not, outputs a error message.
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <param name="validUserInput"></param>
    ''' <returns></returns>
    Private Function IsValid(ByVal userInput As String, ByRef validUserInput As Double) As Boolean

        'DECLARATIONS

        'CONSTANTS
        Const minimumGrade As Double = 0.0 'Constant to hold the minimum grade (For input).
        Const maximumGrade As Double = 100.0 'Constant to hold the maximum grade (For input).

        'VARIABLES
        Dim userInputDouble As Double = 0.0 'Variable to hold the tryparse out value (For input).
        Dim output As String = String.Empty 'Variable to hold the error output, if any (for output).
        Dim returnValue As Boolean = True 'Variable to hold the return value for the calling code.

        'INPUT
        If (Double.TryParse(userInput, userInputDouble)) Then 'If the input is a number.

            If (userInputDouble >= minimumGrade AndAlso userInputDouble <= maximumGrade) Then 'If the input is within range.

                validUserInput = userInputDouble 'Value to be returned to the calling code.
                returnValue = True

            Else 'If the input is out of range.
                output = "Please ensure your input is a number between " & minimumGrade & " and " & maximumGrade & "."
                returnValue = False

            End If

        Else 'If the input is not a number.
            output = "Your input is not a number, please enter a number for the course grade."
            returnValue = False

        End If

        If (returnValue = False) Then 'If there was a validation error, displays the error in the error box label.
            lblErrorBox.Text = output

        End If


        Return returnValue 'Returns True if the validation passed, false if not.

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close() 'Closes this form, and therefore ends the program.

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Clears all the text boxes.
        txtCourseOne.Clear()
        txtCourseTwo.Clear()
        txtCourseThree.Clear()
        txtCourseFour.Clear()
        txtCourseFive.Clear()
        txtCourseSix.Clear()

        'Clears all the course grade labels.
        lblCourseOneLetterGrade.Text() = "".ToString
        lblCourseTwoLetterGrade.Text() = "".ToString
        lblCourseThreeLetterGrade.Text() = "".ToString
        lblCourseFourLetterGrade.Text() = "".ToString
        lblCourseFiveLetterGrade.Text() = "".ToString
        lblCourseSixLetterGrade.Text() = "".ToString
        lblSemesterLetterGrade.Text() = "".ToString

        'Clears the semester average and error box labels.
        lblErrorBox.Text() = "".ToString
        lblSemesterAverage.Text() = "".ToString

        'Allows the user to input into the text boxes again by turning off read only.
        txtCourseOne.ReadOnly() = False
        txtCourseTwo.ReadOnly() = False
        txtCourseThree.ReadOnly() = False
        txtCourseFour.ReadOnly() = False
        txtCourseFive.ReadOnly() = False
        txtCourseSix.ReadOnly() = False

        btnCalculate.Enabled() = True 'Enables the calculate button.

    End Sub
    ''' <summary>
    ''' Calculates the average from all the inputs in the text boxes. Stores the text box values in an array
    ''' and loops those to calculate the sum that is used to average. Checks for any empty values and focuses
    ''' on the first text box that is empty. Displays a message to the user telling them which (if any) text 
    ''' box is empty.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'DECLARATIONS

        'VARIABLES
        'An array to hold the list of text box controls.
        Dim textBoxList() As TextBox = {txtCourseOne, txtCourseTwo, txtCourseThree, txtCourseFour, txtCourseFive, txtCourseSix}
        Dim gradesArray(5) As String 'An array to hold the values of the user inputs in the text boxes.
        Dim gradeSum As Double = 0.0 'Variable to hold the sum of the user inputs in the text boxes.
        Dim gradeAverage As Double = 0.0 'Variable to hold the average value for all the user inputs in the text boxes.
        Dim textBoxToDoubleValue As Double = 0.0 'Variable to hold the converted value of the text boxes from string to double.
        Dim textBoxEmpty As Boolean = False 'Variable to hold a true or false to whether or not a text box was empty.

        lblErrorBox.Text = "Error(s): " & vbCrLf

        For arrayCounter = 1 To gradesArray.Length 'Loop to sum the text boxes
            gradesArray(arrayCounter - 1) = textBoxList(arrayCounter - 1).Text.ToString 'Sets the array's indexes to the text boxes' value.

            If (textBoxList(arrayCounter - 1).Text = "") Then 'If the text box is empty
                lblErrorBox.Text &= "Course " & arrayCounter & " input is empty." & vbCrLf
                textBoxList(arrayCounter - 1).Focus() 'Focuses the text box.
                textBoxList(arrayCounter - 1).SelectAll() 'Selects all the text in the text box.
                textBoxEmpty = True 'Sets the flag for empty text box values.

            Else 'If the text box isn't empty.

                If (IsValid(textBoxList(arrayCounter - 1).Text, textBoxToDoubleValue)) Then 'Checks to make sure the value is a number and within range using the IsValid function.

                    gradeSum += textBoxToDoubleValue 'Adds the converted text box value to the sum.

                End If

            End If
        Next

        If (textBoxEmpty = False) Then 'If there were no empty text box values.
            gradeAverage = (gradeSum / gradesArray.Length) 'Averages the sum of the text boxes.
            lblSemesterAverage.Text = gradeAverage.ToString("n2") 'Outputs the average to the semester average label.
            lblSemesterLetterGrade.Text = Grade(gradeAverage) 'Finds the grade using the grade function and outputs it to the semester grade letter label.
            btnCalculate.Enabled = False 'Disables the calculate button.

            For index = 1 To textBoxList.Length 'Loop to turn all the text boxes read only.
                textBoxList(index - 1).ReadOnly = True
            Next

        End If

    End Sub

    ''' <summary>
    ''' When the text box loses focus, this code is implemented. It calls to the IsValid function to check
    ''' if the input is valid and then calls to the Grade function to set the course letter label. This is 
    ''' nearly identical code for each text box, so only going to comment this first one.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtCourseOne_Leave(sender As Object, e As EventArgs) Handles txtCourseOne.Leave

        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty 'Holds the user's input from the text box.
        Dim output As String = String.Empty 'Holds the output if any validation check is tripped.
        Dim userInputDouble As Double = 0.0 'Holds the tryparse output to used to check if the input is a number.


        userInput = txtCourseOne.Text 'Sets the userInput to what is in the text box.

        If (IsValid(userInput, userInputDouble)) Then 'Calls to the IsValid function. If it passes the validation then:

            lblCourseOneLetterGrade.Text = Grade(userInputDouble) 'Calls to the Grade function to set the course grade letter label.

        Else 'If the input fails the validation check from the IsValid function.
            txtCourseOne.Focus() 'Sets the focus back to the text box.
            txtCourseOne.SelectAll() 'Selects all the data in the text box.

        End If

    End Sub

    Private Sub txtCourseTwo_Leave(sender As Object, e As EventArgs) Handles txtCourseTwo.Leave

        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim userInputDouble As Double = 0.0

        'INPUT

        userInput = txtCourseTwo.Text

        If (IsValid(userInput, userInputDouble)) Then

            lblCourseTwoLetterGrade.Text = Grade(userInputDouble)

        Else
            txtCourseTwo.Focus()
            txtCourseTwo.SelectAll()

        End If
    End Sub

    Private Sub txtCourseThree_Leave(sender As Object, e As EventArgs) Handles txtCourseThree.Leave

        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim userInputDouble As Double = 0.0

        'INPUT

        userInput = txtCourseThree.Text

        If (IsValid(userInput, userInputDouble)) Then

            lblCourseThreeLetterGrade.Text = Grade(userInputDouble)

        Else
            txtCourseThree.Focus()
            txtCourseThree.SelectAll()

        End If
    End Sub

    Private Sub txtCourseFour_Leave(sender As Object, e As EventArgs) Handles txtCourseFour.Leave

        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim userInputDouble As Double = 0.0

        'INPUT

        userInput = txtCourseFour.Text

        If (IsValid(userInput, userInputDouble)) Then

            lblCourseFourLetterGrade.Text = Grade(userInputDouble)

        Else
            txtCourseFour.Focus()
            txtCourseFour.SelectAll()

        End If
    End Sub

    Private Sub txtCourseFive_Leave(sender As Object, e As EventArgs) Handles txtCourseFive.Leave
        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim userInputDouble As Double = 0.0

        'INPUT

        userInput = txtCourseFive.Text

        If (IsValid(userInput, userInputDouble)) Then

            lblCourseFiveLetterGrade.Text = Grade(userInputDouble)

        Else
            txtCourseFive.Focus()
            txtCourseFive.SelectAll()

        End If
    End Sub

    Private Sub txtCourseSix_Leave(sender As Object, e As EventArgs) Handles txtCourseSix.Leave
        'DECLARATIONS

        'VARIABLES
        Dim userInput As String = String.Empty
        Dim output As String = String.Empty
        Dim userInputDouble As Double = 0.0

        'INPUT

        userInput = txtCourseSix.Text

        If (IsValid(userInput, userInputDouble)) Then

            lblCourseSixLetterGrade.Text = Grade(userInputDouble)

        Else
            txtCourseSix.Focus()
            txtCourseSix.SelectAll()

        End If
    End Sub
End Class

