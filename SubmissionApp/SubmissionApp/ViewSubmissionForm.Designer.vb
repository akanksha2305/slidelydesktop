<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForm
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
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithub = New Label()
        lblStopwatch = New Label()
        txtName = New TextBox()
        txtStopwatch = New TextBox()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(362, 19)
        Label1.TabIndex = 0
        Label1.Text = "Akanksha Gupta, Slidely Task 2 - View Submissions "' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(34, 85)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name"' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(34, 128)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(34, 177)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(71, 15)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone Num"' 
        ' lblGithub
        ' 
        lblGithub.AutoSize = True
        lblGithub.Location = New Point(34, 222)
        lblGithub.Name = "lblGithub"
        lblGithub.Size = New Size(43, 15)
        lblGithub.TabIndex = 4
        lblGithub.Text = "Github"' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(34, 267)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(66, 15)
        lblStopwatch.TabIndex = 5
        lblStopwatch.Text = "Stopwatch "' 
        ' txtName
        ' 
        txtName.Location = New Point(150, 82)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(184, 23)
        txtName.TabIndex = 6
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(150, 267)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(184, 23)
        txtStopwatch.TabIndex = 7
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(150, 223)
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(184, 23)
        txtGithub.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(150, 177)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(184, 23)
        txtPhone.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(184, 23)
        txtEmail.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.RosyBrown
        btnPrevious.Location = New Point(34, 329)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(141, 39)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(202, 329)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(141, 39)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(375, 411)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGithub)
        Controls.Add(txtStopwatch)
        Controls.Add(txtName)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGithub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionForm"
        Text = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
