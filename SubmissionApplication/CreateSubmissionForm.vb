Imports System.Windows.Forms

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Initialize stopwatch
        stopwatch.Start()
       
    End Sub

    Private Sub btnStartPauseResume_Click(sender As Object, e As EventArgs) Handles btnStartPauseResume.Click
        If stopwatch.IsRunning Then
            stopwatch.Pause()
        Else
            stopwatch.Resume()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Get form details
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim gitHubLink As String = txtGitHubLink.Text
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString()

        ' Implement API call to backend server to submit form
        SubmitFormToBackend(name, email, phone, gitHubLink, stopwatchTime)
    End Sub

    Private Sub SubmitFormToBackend(name As String, email As String, phone As String, gitHubLink As String, stopwatchTime As String)
        ' Implement API call to backend server to submit form
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatch = stopwatch.Add(TimeSpan.FromSeconds(1))
        btnStartPauseResume.Text = stopwatch.ToString("hh\:mm\:ss")
    End Sub
End Class
