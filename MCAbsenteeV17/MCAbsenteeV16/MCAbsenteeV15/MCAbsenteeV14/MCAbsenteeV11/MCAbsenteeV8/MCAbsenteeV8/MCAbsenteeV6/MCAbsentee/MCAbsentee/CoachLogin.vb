'Module Name: Login Screen (Coach)
'Authors Name: Michael Chow 
'Date: 9/8
'Dependencies: Login.vb
'Purpose: To all authorised users (teachers and coaches) to access the Admin Form
'Bibliography: https://www.youtube.com/watch?v=kC4-xavklpc&t=, https://www.youtube.com/watch?v=gvxrOU3RUwY
Imports System.Xml
Public Class CoachLogin
    Private myUserXMLFile = "users.xml"
    Dim xmlDoc As New XmlDocument

    Private Sub ReadXmlFile()
        ' checks if file exists
        Try
            If My.Computer.FileSystem.FileExists(myUserXMLFile) Then
                xmlDoc.Load(myUserXMLFile)
            Else
                MessageBox.Show("User IDs XML File Not Found", "File Read Error")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ReadXmlFile()
        'users out of the XML file until we find a users who matches the UserID And Password
        Dim UsersList As XmlNodeList = xmlDoc.SelectNodes(".//dtabUsers")
        Dim blnUserFound As Boolean = False

        For Each user As XmlElement In UsersList
            'looking at the inner text betwwen the userID field tags along with the password fields
            If (user("UserID").InnerText = txtUser.Text) And (user("Password").InnerText = txtPassword.Text) Then
                blnUserFound = True
                Exit For
            Else
                blnUserFound = False
            End If
        Next

        ' checks the results of the search
        If blnUserFound = True Then
            'coaches and teachers are takes to Form1, but the administrator to Admin
            If txtUser.Text <> "Admin" Then
                ' a check of whether login was successful through "MessageBox.Show("Login successful")"
                Login.Hide()
                Hide()
                Form1.Show()
            Else
                ' "Admin" UserID is logging in and has the correct Admin Password or take to AdminLogin
                Hide()
                AdminLogin.Show()
            End If
        Else
            MessageBox.Show("User details not found" & vbCrLf & "Please try again", "Login error")
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Show()
        Hide()
    End Sub
End Class