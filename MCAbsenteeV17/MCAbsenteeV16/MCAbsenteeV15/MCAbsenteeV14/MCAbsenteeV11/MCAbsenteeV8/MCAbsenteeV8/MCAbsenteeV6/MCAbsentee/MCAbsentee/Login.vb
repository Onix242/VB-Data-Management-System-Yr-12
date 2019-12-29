'Module Name: Main Login Screen
'Authors Name: Michael Chow 
'Date: 9/8
'Dependencies:
'Purpose: Main applicacation front end intro screen which has a menu to go to the respective login screen depending on the user
'Bibliography: https://www.youtube.com/watch?v=kC4-xavklpc&t=, https://www.youtube.com/watch?v=gvxrOU3RUwY
Public Class Login
    Private Sub btnCoach_Click(sender As Object, e As EventArgs) Handles btnCoach.Click
        CoachLogin.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminLogin.Show()
    End Sub
End Class