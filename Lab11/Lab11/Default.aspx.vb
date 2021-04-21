'Programmer: Shekhar Pathak
'Date: 04/21/2021
'Description: Basic contact web form.
'Project: Lab 11
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' validate the page on the server
        Page.Validate()

        ' check for a valid page
        If Page.IsValid Then
            ' all the validators passed
            ' send an email
            SendMessages()

            ' prevent duplicates 
            PreventDuplicate()

            ' redirect to the thank you page
            Response.Redirect("ThankYOu.aspx")
        End If
    End Sub

    Sub SendMessages()
        ' create and send an email
        Dim objMessage As New System.Net.Mail.MailMessage
        Dim BodyString As String

        ' build message body 
        BodyString = "Name: " & NameTextBox.Text & vbCrLf
        BodyString &= "Email: " & EmailTextBox.Text & vbCrLf
        BodyString &= "Phone: " & PhoneTextBox.Text & vbCrLf
        BodyString &= "Contact Method: " & ContactMethodRadioButtonList.SelectedValue & vbCrLf
        BodyString &= "Comments: " & CommentsTextBox.Text

        ' Populate the message obj 
        With objMessage
            .From = New Net.Mail.MailAddress("ysu@ourvalleynow.com")
            .To.Add(New Net.Mail.MailAddress("shekharpathak47@gmail.com"))
            .Subject = "Contact form submission"
            .Body = BodyString
        End With

        ' send that message
        Using objClient As New System.Net.Mail.SmtpClient
            With objClient
                .Host = "mail.idmi.net"
                .Port = 587
                .EnableSsl = True
                .Credentials = New System.Net.NetworkCredential("ysu@ourvalleynow.com", "Penguins21!")

                Try
                    ' Send the message
                    objClient.Send(objMessage)

                Catch ex As System.Net.Mail.SmtpException

                End Try
            End With
        End Using
    End Sub

    Sub PreventDuplicate()
        ' set a cookie to prevent duplicate submissions
        Response.Cookies("IsDuplicate").Value = True
    End Sub

    Function CheckForDuplicate() As Boolean
        ' Check for the cookies to prevent duplicate submissions
        Dim IsDuplicateBoolean As Boolean = False

        ' check if the cookies exists
        If Request.Cookies("IsDuplicate") IsNot Nothing Then
            ' the cookie exists
            If Not Boolean.TryParse(Request.Cookies("IsDuplicate").Value, IsDuplicateBoolean) Then
                ' If I get here the parse failed
                ' think of this as the catch block above 
                IsDuplicateBoolean = False
            End If
        End If
        ' return the boolean
        Return IsDuplicateBoolean
    End Function

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Check for the duplicate entry
        If CheckForDuplicate() Then
            ' the cookie exists, dont allow new entries
            FormPanel.Visible = False
            DuplicatePanel.Visible = True
        Else
            ' the cookies doesnt exist, allow new entries
            FormPanel.Visible = True
            DuplicatePanel.Visible = False
        End If
    End Sub
End Class
