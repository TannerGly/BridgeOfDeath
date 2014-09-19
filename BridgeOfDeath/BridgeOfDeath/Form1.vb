Public Class frmBridgeOfDeath

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim strGlynis, strGrail, strBlue As String
        strGlynis = "Glynis"
        strGrail = "To seek the Holy Grail."
        strBlue = "Blue"
        Dim strNameGuess As String = Me.txtName.Text
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strColorGuess As String = Me.txtColor.Text
        If strGlynis = strNameGuess Then
            Me.lblQ1Answer.Text = "You May Pass."
        Else
            Me.lblQ1Answer.Text = "*Cast Into The Pit of Eternal Peril*"
        End If
        If strGrail = strQuestGuess Then
            Me.lblQ2Answer.Text = "You May Pass."
        Else
            Me.lblQ2Answer.Text = "*Cast Into The Pit of Eternal Peril*"
        End If
        If strBlue = strColorGuess Then
            Me.lblQ3Answer.Text = "You May Pass."
        Else
            Me.lblQ3Answer.Text = "*Cast Into The Pit of Eternal Peril*"
        End If
    End Sub
End Class
