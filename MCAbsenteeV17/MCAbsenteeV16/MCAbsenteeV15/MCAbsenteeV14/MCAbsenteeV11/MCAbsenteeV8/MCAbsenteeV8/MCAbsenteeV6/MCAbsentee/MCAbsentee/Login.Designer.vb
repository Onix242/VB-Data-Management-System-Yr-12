<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblCoach = New System.Windows.Forms.Label()
        Me.btnCoach = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCoach
        '
        Me.lblCoach.AutoSize = True
        Me.lblCoach.Location = New System.Drawing.Point(100, 81)
        Me.lblCoach.Name = "lblCoach"
        Me.lblCoach.Size = New System.Drawing.Size(120, 13)
        Me.lblCoach.TabIndex = 3
        Me.lblCoach.Text = "For Teachers/ Coaches"
        '
        'btnCoach
        '
        Me.btnCoach.Location = New System.Drawing.Point(19, 76)
        Me.btnCoach.Name = "btnCoach"
        Me.btnCoach.Size = New System.Drawing.Size(75, 23)
        Me.btnCoach.TabIndex = 2
        Me.btnCoach.Text = "Login"
        Me.btnCoach.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(19, 115)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(100, 120)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(96, 13)
        Me.lblAdmin.TabIndex = 5
        Me.lblAdmin.Text = "For Heads of Sport"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(266, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.btnCoach)
        Me.Controls.Add(Me.lblCoach)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCoach As Label
    Friend WithEvents btnCoach As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Label1 As Label
End Class
