<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBridgeOfDeath
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
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblQuestionOne = New System.Windows.Forms.Label()
        Me.lblQuestionTwo = New System.Windows.Forms.Label()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblQ1Answer = New System.Windows.Forms.Label()
        Me.lblQ2Answer = New System.Windows.Forms.Label()
        Me.lblQ3Answer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(109, 227)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 0
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblQuestionOne
        '
        Me.lblQuestionOne.AutoSize = True
        Me.lblQuestionOne.Location = New System.Drawing.Point(12, 71)
        Me.lblQuestionOne.Name = "lblQuestionOne"
        Me.lblQuestionOne.Size = New System.Drawing.Size(101, 13)
        Me.lblQuestionOne.TabIndex = 2
        Me.lblQuestionOne.Text = "What is your name?"
        '
        'lblQuestionTwo
        '
        Me.lblQuestionTwo.AutoSize = True
        Me.lblQuestionTwo.Location = New System.Drawing.Point(12, 123)
        Me.lblQuestionTwo.Name = "lblQuestionTwo"
        Me.lblQuestionTwo.Size = New System.Drawing.Size(101, 13)
        Me.lblQuestionTwo.TabIndex = 3
        Me.lblQuestionTwo.Text = "What is your quest?"
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(172, 123)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(100, 20)
        Me.txtQuest.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "What is your favorite color?"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(172, 177)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 6
        '
        'lblQ1Answer
        '
        Me.lblQ1Answer.AutoSize = True
        Me.lblQ1Answer.Location = New System.Drawing.Point(30, 97)
        Me.lblQ1Answer.Name = "lblQ1Answer"
        Me.lblQ1Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ1Answer.TabIndex = 7
        '
        'lblQ2Answer
        '
        Me.lblQ2Answer.AutoSize = True
        Me.lblQ2Answer.Location = New System.Drawing.Point(30, 150)
        Me.lblQ2Answer.Name = "lblQ2Answer"
        Me.lblQ2Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ2Answer.TabIndex = 8
        '
        'lblQ3Answer
        '
        Me.lblQ3Answer.AutoSize = True
        Me.lblQ3Answer.Location = New System.Drawing.Point(30, 204)
        Me.lblQ3Answer.Name = "lblQ3Answer"
        Me.lblQ3Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ3Answer.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Who would cross the Bridge of Death"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Must answer me"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "These questions three"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ere the other side he see."
        '
        'frmBridgeOfDeath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQ3Answer)
        Me.Controls.Add(Me.lblQ2Answer)
        Me.Controls.Add(Me.lblQ1Answer)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.lblQuestionTwo)
        Me.Controls.Add(Me.lblQuestionOne)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAnswer)
        Me.Name = "frmBridgeOfDeath"
        Me.Text = "Bridge Of Death"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestionOne As System.Windows.Forms.Label
    Friend WithEvents lblQuestionTwo As System.Windows.Forms.Label
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblQ1Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ2Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ3Answer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
