Imports System.Diagnostics
Imports System.Net.Http

Public Class CreateSubmissionForm

    Private stopwatch As Stopwatch
    Private isStopwatchRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize stopwatch
        stopwatch = New Stopwatch()
        UpdateStopwatchDisplay()
    End Sub

    Private Sub BtnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        ' Start or pause/resume stopwatch
        If Not isStopwatchRunning Then
            stopwatch.Start()
            isStopwatchRunning = True
            btnStartStopwatch.Text = "Pause"
        Else
            stopwatch.Stop()
            isStopwatchRunning = False
            btnStartStopwatch.Text = "Resume"
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Async Function SubmitFormAsync(name As String, email As String, phoneNumber As String, gitHubRepo As String, stopwatchTime As String) As Task
        Dim apiUrl As String = "http://localhost:3000/submit"

        Try
            Using client As New HttpClient()
                Dim reqContent As New FormUrlEncodedContent(New Dictionary(Of String, String) From {
                {"name", name},
                {"email", email},
                {"phone", phoneNumber},
                {"github_link", gitHubRepo},
                {"stopwatch_time", stopwatchTime}
            })

                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, reqContent)
                response.EnsureSuccessStatusCode()

                Dim responseString As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Form submitted successfully!")
                ResetForm()
            End Using
        Catch ex As HttpRequestException
            MessageBox.Show($"HTTP Request Error: {ex.Message}{Environment.NewLine}Stack Trace: {ex.StackTrace}")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}{Environment.NewLine}Stack Trace: {ex.StackTrace}")
        End Try
    End Function


    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim gitHubRepo As String = txtGithubLink.Text
        Dim stopwatchTime As String = lblStopwatchTime.Text

        Await SubmitFormAsync(name, email, phoneNumber, gitHubRepo, stopwatchTime)
    End Sub

    Private Sub ResetForm()
        ' Clear form fields
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtGithubLink.Text = ""

        ' Reset stopwatch
        stopwatch.Reset()
        isStopwatchRunning = False
        btnStartStopwatch.Text = "Start"
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        ' Update stopwatch time display
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Handle keyboard shortcuts
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick() ' Simulate click on Submit button
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
