<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverageCalculator
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
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemesterLetterGrade = New System.Windows.Forms.Label()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.lblErrorBox = New System.Windows.Forms.Label()
        Me.lblCourseSixLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblCourseFiveLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseFourLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblCourseThreeLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseTwoLetterGrade = New System.Windows.Forms.Label()
        Me.lblCouseTwo = New System.Windows.Forms.Label()
        Me.lblCourseOneLetterGrade = New System.Windows.Forms.Label()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.txtCourseSix = New System.Windows.Forms.TextBox()
        Me.txtCourseFive = New System.Windows.Forms.TextBox()
        Me.txtCourseFour = New System.Windows.Forms.TextBox()
        Me.txtCourseThree = New System.Windows.Forms.TextBox()
        Me.txtCourseTwo = New System.Windows.Forms.TextBox()
        Me.txtCourseOne = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SemesterAverageTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(26, 150)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 21
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SemesterAverageTips.SetToolTip(Me.lblSemester, "To get the average grade fill all six of the boxes for your course grades and pre" &
        "ss the calculate button")
        '
        'lblSemesterLetterGrade
        '
        Me.lblSemesterLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterLetterGrade.Location = New System.Drawing.Point(172, 148)
        Me.lblSemesterLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSemesterLetterGrade.Name = "lblSemesterLetterGrade"
        Me.lblSemesterLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblSemesterLetterGrade.TabIndex = 23
        Me.lblSemesterLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverage.Location = New System.Drawing.Point(85, 149)
        Me.lblSemesterAverage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(75, 19)
        Me.lblSemesterAverage.TabIndex = 22
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterAverageTips.SetToolTip(Me.lblSemesterAverage, "Your average grade this semester")
        '
        'lblErrorBox
        '
        Me.lblErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorBox.Location = New System.Drawing.Point(12, 178)
        Me.lblErrorBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblErrorBox.MaximumSize = New System.Drawing.Size(260, 122)
        Me.lblErrorBox.MinimumSize = New System.Drawing.Size(248, 122)
        Me.lblErrorBox.Name = "lblErrorBox"
        Me.lblErrorBox.Size = New System.Drawing.Size(260, 122)
        Me.lblErrorBox.TabIndex = 24
        Me.lblErrorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseSixLetterGrade
        '
        Me.lblCourseSixLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseSixLetterGrade.Location = New System.Drawing.Point(172, 126)
        Me.lblCourseSixLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseSixLetterGrade.Name = "lblCourseSixLetterGrade"
        Me.lblCourseSixLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseSixLetterGrade.TabIndex = 20
        Me.lblCourseSixLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(5, 126)
        Me.lblCourseSix.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseSix.TabIndex = 10
        Me.lblCourseSix.Text = "Course &6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFiveLetterGrade
        '
        Me.lblCourseFiveLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFiveLetterGrade.Location = New System.Drawing.Point(172, 103)
        Me.lblCourseFiveLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseFiveLetterGrade.Name = "lblCourseFiveLetterGrade"
        Me.lblCourseFiveLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseFiveLetterGrade.TabIndex = 19
        Me.lblCourseFiveLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(5, 103)
        Me.lblCourseFive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseFive.TabIndex = 8
        Me.lblCourseFive.Text = "Course &5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFourLetterGrade
        '
        Me.lblCourseFourLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseFourLetterGrade.Location = New System.Drawing.Point(172, 80)
        Me.lblCourseFourLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseFourLetterGrade.Name = "lblCourseFourLetterGrade"
        Me.lblCourseFourLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseFourLetterGrade.TabIndex = 18
        Me.lblCourseFourLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(5, 79)
        Me.lblCourseFour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseFour.TabIndex = 6
        Me.lblCourseFour.Text = "Course &4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseThreeLetterGrade
        '
        Me.lblCourseThreeLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseThreeLetterGrade.Location = New System.Drawing.Point(172, 57)
        Me.lblCourseThreeLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseThreeLetterGrade.Name = "lblCourseThreeLetterGrade"
        Me.lblCourseThreeLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseThreeLetterGrade.TabIndex = 17
        Me.lblCourseThreeLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(5, 57)
        Me.lblCourseThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseThree.TabIndex = 4
        Me.lblCourseThree.Text = "Course &3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseTwoLetterGrade
        '
        Me.lblCourseTwoLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseTwoLetterGrade.Location = New System.Drawing.Point(172, 35)
        Me.lblCourseTwoLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseTwoLetterGrade.Name = "lblCourseTwoLetterGrade"
        Me.lblCourseTwoLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseTwoLetterGrade.TabIndex = 16
        Me.lblCourseTwoLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCouseTwo
        '
        Me.lblCouseTwo.Location = New System.Drawing.Point(5, 34)
        Me.lblCouseTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCouseTwo.Name = "lblCouseTwo"
        Me.lblCouseTwo.Size = New System.Drawing.Size(75, 19)
        Me.lblCouseTwo.TabIndex = 2
        Me.lblCouseTwo.Text = "Course &2:"
        Me.lblCouseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseOneLetterGrade
        '
        Me.lblCourseOneLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseOneLetterGrade.Location = New System.Drawing.Point(172, 11)
        Me.lblCourseOneLetterGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseOneLetterGrade.Name = "lblCourseOneLetterGrade"
        Me.lblCourseOneLetterGrade.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseOneLetterGrade.TabIndex = 15
        Me.lblCourseOneLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(5, 11)
        Me.lblCourseOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(75, 19)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourseSix
        '
        Me.txtCourseSix.Location = New System.Drawing.Point(85, 126)
        Me.txtCourseSix.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseSix.Name = "txtCourseSix"
        Me.txtCourseSix.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseSix.TabIndex = 11
        Me.txtCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseSix, "Enter a numeric value for the grade of this course")
        '
        'txtCourseFive
        '
        Me.txtCourseFive.Location = New System.Drawing.Point(85, 103)
        Me.txtCourseFive.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseFive.Name = "txtCourseFive"
        Me.txtCourseFive.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseFive.TabIndex = 9
        Me.txtCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseFive, "Enter a numeric value for the grade of this course")
        '
        'txtCourseFour
        '
        Me.txtCourseFour.Location = New System.Drawing.Point(85, 80)
        Me.txtCourseFour.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseFour.Name = "txtCourseFour"
        Me.txtCourseFour.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseFour.TabIndex = 7
        Me.txtCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseFour, "Enter a numeric value for the grade of this course")
        '
        'txtCourseThree
        '
        Me.txtCourseThree.Location = New System.Drawing.Point(85, 58)
        Me.txtCourseThree.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseThree.Name = "txtCourseThree"
        Me.txtCourseThree.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseThree.TabIndex = 5
        Me.txtCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseThree, "Enter a numeric value for the grade of this course")
        '
        'txtCourseTwo
        '
        Me.txtCourseTwo.Location = New System.Drawing.Point(85, 35)
        Me.txtCourseTwo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseTwo.Name = "txtCourseTwo"
        Me.txtCourseTwo.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseTwo.TabIndex = 3
        Me.txtCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseTwo, "Enter a numeric value for the grade of this course")
        '
        'txtCourseOne
        '
        Me.txtCourseOne.Location = New System.Drawing.Point(85, 12)
        Me.txtCourseOne.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCourseOne.Name = "txtCourseOne"
        Me.txtCourseOne.Size = New System.Drawing.Size(76, 20)
        Me.txtCourseOne.TabIndex = 1
        Me.txtCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterAverageTips.SetToolTip(Me.txtCourseOne, "Enter a numeric value for the grade of this course")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(191, 316)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 27)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.SemesterAverageTips.SetToolTip(Me.btnExit, "Click to close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(112, 316)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(60, 27)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.SemesterAverageTips.SetToolTip(Me.btnReset, "Click to reset the form to the orginal state")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 316)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(62, 27)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterAverageTips.SetToolTip(Me.btnCalculate, "Calculates your average grade, requires all six courses to have a valid grade ent" &
        "ered")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmSemesterAverageCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 357)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSemesterLetterGrade)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblErrorBox)
        Me.Controls.Add(Me.lblCourseSixLetterGrade)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblCourseFiveLetterGrade)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseFourLetterGrade)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseThreeLetterGrade)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwoLetterGrade)
        Me.Controls.Add(Me.lblCouseTwo)
        Me.Controls.Add(Me.lblCourseOneLetterGrade)
        Me.Controls.Add(Me.lblCourseOne)
        Me.Controls.Add(Me.txtCourseSix)
        Me.Controls.Add(Me.txtCourseFive)
        Me.Controls.Add(Me.txtCourseFour)
        Me.Controls.Add(Me.txtCourseThree)
        Me.Controls.Add(Me.txtCourseTwo)
        Me.Controls.Add(Me.txtCourseOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverageCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSemester As Label
    Friend WithEvents lblSemesterLetterGrade As Label
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents lblErrorBox As Label
    Friend WithEvents lblCourseSixLetterGrade As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblCourseFiveLetterGrade As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseFourLetterGrade As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblCourseThreeLetterGrade As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseTwoLetterGrade As Label
    Friend WithEvents lblCouseTwo As Label
    Friend WithEvents lblCourseOneLetterGrade As Label
    Friend WithEvents lblCourseOne As Label
    Friend WithEvents txtCourseSix As TextBox
    Friend WithEvents txtCourseFive As TextBox
    Friend WithEvents txtCourseFour As TextBox
    Friend WithEvents txtCourseThree As TextBox
    Friend WithEvents txtCourseTwo As TextBox
    Friend WithEvents txtCourseOne As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents SemesterAverageTips As ToolTip
End Class
