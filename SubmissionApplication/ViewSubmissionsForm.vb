Imports System.Windows.Forms
Public Class ViewSubmissionsForm


    Private submissions As List(Of Submission) = New List(Of Submission)()
    Private currentIndex As Integer = 0
    Private lblSubmissionDetails As Object

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Load submissions from backend server
        submissions = GetSubmissionsFromBackend()
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub DisplaySubmission()
        ' Display the current submission details
        lblSubmissionDetails.Text = submissions(currentIndex).ToString()
    End Sub

    Private Function GetSubmissionsFromBackend() As List(Of Submission)
        ' Implement API call to backend server to retrieve submissions
        ' Return a list of Submission objects
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class


