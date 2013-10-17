Imports System.Data.SqlClient
Imports System.Data
Partial Class Quiz_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If (IsPostBack = False) Then



            Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
            Dim cmd As SqlCommand = New SqlCommand
            Dim dataReader As SqlDataReader

            With cmd
                .Connection = conStr
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Ski_Pulling_Quiz"
                .Parameters.AddWithValue("@committeeName","AwardsCommittee")
            End With
            conStr.Open()
            dataReader = cmd.ExecuteReader
            Dim temID As String = ""
            'start

            While dataReader.Read

                If temID <> dataReader("QuestionID").ToString Then

                    Dim pan As New Panel    'create a new panel object

                    Dim Qlabel As New Label 'create a new lable oject to contain the question

                    temID = dataReader("QuestionID").ToString

                    pan.ID = temID

                    QuizPlace.Controls.Add(pan)
                    Qlabel.Text = dataReader("QuestionContent")
                    pan.Controls.Add(Qlabel)
                    pan.Controls.Add(New LiteralControl(("<br />")))

                End If

                'add new new radio button
                Dim rB As New RadioButton
                rB.ID = dataReader("QuestionCode").ToString + dataReader("Answer").ToString
                'if the question if T/F, we don't load the answer content
                If dataReader("Answer").ToString = "F" Or dataReader("Answer").ToString = "T" Then

                    rB.Text = dataReader("AnswerContent").ToString
                Else
                    rB.Text = dataReader("Answer").ToString + ". " + dataReader("AnswerContent").ToString
                End If

                rB.GroupName = dataReader("QuestionID").ToString 'the group name will allow the user only select one radio from the group

                Dim myPanel As Panel = QuizPlace.FindControl(dataReader("QuestionID").ToString) 'find the panel just created
                myPanel.Controls.Add(rB)    'add the new created radio button
                myPanel.Controls.Add(New LiteralControl(("<br />")))    'change to a new line

            End While



        End If

    End Sub


End Class
