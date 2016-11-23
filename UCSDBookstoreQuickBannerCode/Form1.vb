Public Class Form1

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Bookstore Slider Images, HTML Generator"
        Label1.Text = "File name (Example.png):"
        Label2.Text = "Link (Optional)"
        Label3.Text = "Code for the advanced browser division: "
        Label4.Text = "Code for IE division: "
        TextBox2.Text = " "
        Button1.Text = "Generate Code"
        Me.BackColor = Color.FloralWhite
        TabControl1.Dock = DockStyle.Fill
        TabControl1.TabPages(0).Text = "Code generator"
        TabControl1.TabPages(1).Text = "Image preview"
        TabControl1.TabPages(2).Text = "Upload Images"
        WebBrowser2.Navigate("https://ucsandiegobookstore.com/aspdnsf_admin/topics.aspx")
        Label5.ForeColor = Color.Green
        Label5.Visible = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If TextBox2.Text = " " Then
            RichTextBox1.Text = "<img style=" + Chr(34) + "width: 100%;" + Chr(34) + " src=" + Chr(34) + "/Images/" + TextBox1.Text + Chr(34) + " class=" + Chr(34) + "mySlides" + Chr(34) + "/>"
        Else
            RichTextBox1.Text = "<a href=" + Chr(34) + TextBox2.Text + Chr(34) + "> <img style=" + Chr(34) + "width: 100%;" + Chr(34) + " src=" + Chr(34) + "/Images/" + TextBox1.Text + Chr(34) + " class=" + Chr(34) + "mySlides" + Chr(34) + "/> </a>"
        End If

        If TextBox2.Text = " " Then
            RichTextBox2.Text = "<li style=" + Chr(34) + "position: absolute; top: 0px; left: 0px;" + Chr(34) + "><img src=" + Chr(34) + "/Images/" + TextBox1.Text + Chr(34) + " /></li>"
        Else
            RichTextBox2.Text = "<li style=" + Chr(34) + "position: absolute; top: 0px; left: 0px;" + Chr(34) + "><a href=" + Chr(34) + TextBox2.Text + Chr(34) + "><img src=" + Chr(34) + "/Images/" + TextBox1.Text + Chr(34) + " /></li></a>"
        End If

        WebBrowser1.Navigate("https://ucsandiegobookstore.com/Images/" + TextBox1.Text)


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.DocumentTitle = "404 - File or directory not found." Then
            Label5.Text = "ERROR: Image not found on the server. Please upload it for the code to work."
            Label5.ForeColor = Color.Red
            Label5.Visible = True

        ElseIf WebBrowser1.DocumentTitle = "403 - Forbidden: Access is denied." Then
            Label5.Text = "ERROR: Image not found on the server. Please upload it for the code to work."
            Label5.ForeColor = Color.Red
            Label5.Visible = True
        Else
            Label5.Text = "SUCCESS: Code generated successfully."
            Label5.ForeColor = Color.Green
            Label5.Visible = True
        End If
    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
