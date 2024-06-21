Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    ' Define a class to hold submission data
    Private Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MoveToPreviousSubmission()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        MoveToNextSubmission()
    End Sub

    ' Move to the previous submission and update display
    Private Sub MoveToPreviousSubmission()
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        Else
            MessageBox.Show("You are at the first submission.")
        End If
    End Sub

    ' Move to the next submission and update display
    Private Sub MoveToNextSubmission()
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        Else
            MessageBox.Show("You are at the last submission.")
        End If
    End Sub

    ' Display the current submission details
    Private Sub DisplayCurrentSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim currentSubmission As Submission = submissions(currentIndex)
            txtName.Text = currentSubmission.Name
            txtEmail.Text = currentSubmission.Email
            txtPhone.Text = currentSubmission.Phone
            txtGithub.Text = currentSubmission.GithubLink
            txtStopwatch.Text = currentSubmission.StopwatchTime
        Else
            MessageBox.Show("No submissions found.")
        End If

        UpdateNavigationButtons()
    End Sub

    ' Update the navigation buttons state
    Private Sub UpdateNavigationButtons()
        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < submissions.Count - 1
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            MoveToPreviousSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            MoveToNextSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the initial set of submissions when the form loads
        FetchSubmissions()

        ' Enable the form to capture key events
        Me.KeyPreview = True
    End Sub

    ' Fetch submissions - initial implementation only fetches once
    Private Sub FetchSubmissions()
        ' Replace this method with your actual implementation to fetch data from your server
        ' For demonstration purposes, let's simulate fetching data
        submissions = New List(Of Submission) From {
            New Submission With {
                .Name = "John Doe",
                .Email = "john.doe@example.com",
                .Phone = "1234567890",
                .GithubLink = "https://github.com/johndoe",
                .StopwatchTime = "00:00:00"
            },
            New Submission With {
                .Name = "Jane Smith",
                .Email = "jane.smith@example.com",
                .Phone = "0987654321",
                .GithubLink = "https://github.com/janesmith",
                .StopwatchTime = "00:00:01"
            }
        }

        DisplayCurrentSubmission()
    End Sub
End Class
