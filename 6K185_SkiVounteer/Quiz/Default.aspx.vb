
Partial Class Quiz_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (IsPostBack = False) Then
            Dim ct As Integer = 1 ' this is the question counter
            Dim i As Integer
            For i = ct To 10
                'this is the new radiobutton
                Dim arrRButton(3) As RadioButton
                Dim Pan As New Panel
                'add on panel
                Pan.ID = "ha" + Convert.ToString(ct)

                Me.Controls.Add(Pan)
                With Panel1
                    arrRButton(0) = New RadioButton
                    arrRButton(1) = New RadioButton
                    arrRButton(2) = New RadioButton
                    arrRButton(3) = New RadioButton
                    .Controls.Add(arrRButton(0))
                    .Controls.Add(New LiteralControl(("<br />"))) 'this is a line breaker between controls
                    .Controls.Add(arrRButton(1))
                    .Controls.Add(New LiteralControl(("<br />"))) 'this is a line breaker between controls
                    .Controls.Add(arrRButton(2))
                    .Controls.Add(New LiteralControl(("<br />"))) 'this is a line breaker between controls
                    .Controls.Add(arrRButton(3))
                    .Controls.Add(New LiteralControl(("<br />"))) 'this is a line breaker between controls
                End With
                'add one more panel
            Next
        End If
    End Sub
End Class
