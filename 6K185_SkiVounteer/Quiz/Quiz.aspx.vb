Imports System.Data.SqlClient
Imports System.Data
Partial Class Quiz_Quiz
    Inherits System.Web.UI.Page
    'count question for each load
    Public allQuestion As Integer
    Public rightAnswer(10) As String  'this will store the right answer for when loading the answer
    Public selectedAnswer(10) As String  'this will store the selected answers for when submit
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'clean the global value
        allQuestion = 0
        If Not rightAnswer Is Nothing Then Array.Clear(rightAnswer, 0, rightAnswer.Length)

        'start pulling the dataset
        Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
        Dim cmd As SqlCommand = New SqlCommand
        Dim dataReader As SqlDataReader
        Dim ct As Integer = 0 'this will be used as a count 
        With cmd
            .Connection = conStr
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Ski_Pulling_Quiz"
            .Parameters.AddWithValue("@committeeName", Session("CommittName"))
        End With
        conStr.Open()
        dataReader = cmd.ExecuteReader
        Dim temID As String = ""
        'start
        While dataReader.Read
            If temID <> dataReader("QuestionID").ToString Then
                Dim Qlabel As New Label 'create a new lable oject to contain the question
                ct = ct + 1
                temID = dataReader("QuestionID").ToString
                Qlabel.Text = ct.ToString + ". " + dataReader("QuestionContent") 'the question number plus question content
                QuizPlace.Controls.Add(Qlabel) 'add the label
                QuizPlace.Controls.Add(New LiteralControl(("<br />"))) 'add a new line in the browzer
                'store the rightAnswer as array
                rightAnswer(ct) = dataReader("QAnswer").ToString
                'count how many questions are there
                allQuestion = allQuestion + 1
            End If
            'add a new radio button
            Dim rB As New RadioButton
            rB.ID = ct.ToString + dataReader("Answer").ToString
            'if the question if T/F, we don't load the answer content
            If dataReader("Answer").ToString = "F" Or dataReader("Answer").ToString = "T" Then
                rB.Text = dataReader("AnswerContent").ToString
            Else
                rB.Text = dataReader("Answer").ToString + ". " + dataReader("AnswerContent").ToString
            End If
            'the group name will allow the user only select one radio from the group
            rB.GroupName = ct.ToString
            QuizPlace.Controls.Add(rB)    'add the new created radio button
            QuizPlace.Controls.Add(New LiteralControl(("<br />")))    'change to a new line
        End While
    End Sub


    Protected Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If selectAll() = True Then 'when all the questions are answered
            'compare the load question to the right answer
            If checkAnswer() = True Then
                messagelabel.Text = ""
                '*********************************************'
                '*********************************************'
                '*********************************************'
                '***    If the quiz passed,send email   ******'
                '*********************************************'
                '*********************************************'
                '*********************************************'
                '*********************************************'
            End If
        Else
            messagelabel.Text = "Please select all the question!"
            messagelabel.ForeColor = Drawing.Color.Black
            messagelabel.BackColor = Drawing.Color.Red
        End If
    End Sub

    'this will be fired when user submit the quiz, then check if every question is selected
    Public Function selectAll() As Boolean
        'clean the global stored array
        If Not selectedAnswer Is Nothing Then Array.Clear(selectedAnswer, 0, selectedAnswer.Length)
        'clean the textbox 
        messagelabel.Text = ""
        'loop through all the controls
        Dim selectQ As Integer = 0 'this will use to count selected question and compare to the global integer 'qCount', which is the total question
        For Each radionC As Control In Me.QuizPlace.Controls
            'if the control is a radio button
            If (radionC.GetType() Is GetType(RadioButton)) Then
                Dim rd As RadioButton = CType(radionC, RadioButton) 'cast this variable to a new radio butt to refer
                If rd.Checked = True Then
                    selectQ = selectQ + 1
                    'store the selected answer
                    selectedAnswer(selectQ) = Right(rd.ID(), 1)
                End If
            End If
        Next
        'if user select all the question, will return true, else return false
        If selectQ = allQuestion Then Return True Else Return False
    End Function

    'this function will check the answer and return if all the question are right
    Public Function checkAnswer() As Boolean
        Dim wrongAnswer As Integer = 0
        'add elements to the messagebox
        messagelabel.Text = "Please double check question: "
        messagelabel.ForeColor = Drawing.Color.Black
        messagelabel.BackColor = Drawing.Color.Red
        For value As Integer = 1 To allQuestion 'default number 1
            If rightAnswer(value) <> selectedAnswer(value) Then
                'jump to the successfull page
                messagelabel.Text = messagelabel.Text + " " + value.ToString
                wrongAnswer = wrongAnswer + 1
            End If
        Next
        If wrongAnswer = 0 Then Return True Else Return False
    End Function
End Class
