<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblName = New Label()
        lblGithubLink = New Label()
        lblPhoneNumber = New Label()
        lblEmail = New Label()
        txtName = New TextBox()
        txtGithubLink = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        btnStartStopwatch = New Button()
        lblStopwatchTime = New Label()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 19)
        Label1.TabIndex = 0
        Label1.Text = "Akanksha Gupta, Slidely task - 2, Create Submissions" ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(48, 89)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name" ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(48, 223)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(43, 15)
        lblGithubLink.TabIndex = 2
        lblGithubLink.Text = "Github" ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(48, 179)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(71, 15)
        lblPhoneNumber.TabIndex = 3
        lblPhoneNumber.Text = "Phone Num" ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(48, 134)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email" ' 
        ' txtName
        ' 
        txtName.Location = New Point(161, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(165, 23)
        txtName.TabIndex = 5
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(161, 223)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(165, 23)
        txtGithubLink.TabIndex = 6
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(161, 179)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(165, 23)
        txtPhoneNumber.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(161, 134)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(165, 23)
        txtEmail.TabIndex = 8
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.BackColor = Color.RosyBrown
        btnStartStopwatch.Location = New Point(12, 275)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(194, 37)
        btnStartStopwatch.TabIndex = 9
        btnStartStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStopwatchTime.Location = New Point(233, 275)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(121, 37)
        lblStopwatchTime.TabIndex = 10
        lblStopwatchTime.Text = "00:00:00" ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Location = New Point(74, 327)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(228, 39)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(375, 411)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnStartStopwatch)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtGithubLink)
        Controls.Add(txtName)
        Controls.Add(lblEmail)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblGithubLink)
        Controls.Add(lblName)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer

End Class
