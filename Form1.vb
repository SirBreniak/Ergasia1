Imports System.Net
Public Class Form1

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_1(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".gr") Or TextBox1.Text.Contains(".net") Then
            Try
                WebControl3.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl3.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)
            End Try
        Else : WebControl3.Source = New Uri("https://www.google.gr/search?q=" & TextBox1.Text & "&ie=utf-8&oe=utf-8&client=firefox-b&gfe_rd=cr&ei=Hgk_WLDaGuHa8AeesJSYDg")
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebControl3.Reload(ignoreCache:=True)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".gr") Or TextBox1.Text.Contains(".net") Then
                Try
                    WebControl3.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl3.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else : WebControl3.Source = New Uri("https://www.google.gr/search?q=" & TextBox1.Text & "&ie=utf-8&oe=utf-8&client=firefox-b&gfe_rd=cr&ei=Hgk_WLDaGuHa8AeesJSYDg")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WebControl3.CanGoBack Then
            WebControl3.GoBack()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl3.CanGoForward Then
            WebControl3.GoForward()
        End If
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub



    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView_2(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl2.ShowCreatedWebView

    End Sub

    Private Sub MhjkjhkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MhjkjhkToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl3.ShowCreatedWebView

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
