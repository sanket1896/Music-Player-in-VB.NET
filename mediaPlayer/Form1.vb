Public Class Form1
    Dim loadedLocation1 As String = Nothing
    Dim loadedLocation2 As String = Nothing
    'first
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath

        ListBox1.Items.Clear()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(TextBox1.Text)
            If (foundFile.ToLower().EndsWith(".mp3")) Then
                ListBox1.Items.Add(foundFile.Split("\")(foundFile.Split("\").Count() - 1))
            End If
        Next
        loadedLocation1 = TextBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (Not ListBox1.SelectedItem = Nothing) Then
            AxWindowsMediaPlayer1.URL = TextBox1.Text & "\" & ListBox1.SelectedItem
            AxWindowsMediaPlayer1.settings.balance = -100
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Diagnostics.Process.Start(loadedLocation1)
    End Sub


    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.balance = TrackBar1.Value * 10
    End Sub

    'second
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (Not ListBox2.SelectedItem = Nothing) Then
            AxWindowsMediaPlayer2.URL = TextBox2.Text & "\" & ListBox2.SelectedItem
            AxWindowsMediaPlayer2.settings.balance = 100
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Diagnostics.Process.Start(loadedLocation2)
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FolderBrowserDialog2.ShowDialog()
        TextBox2.Text = FolderBrowserDialog2.SelectedPath


        ListBox2.Items.Clear()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(TextBox2.Text)
            If (foundFile.ToLower().EndsWith(".mp3")) Then
                ListBox2.Items.Add(foundFile.Split("\")(foundFile.Split("\").Count() - 1))
            End If
        Next
        loadedLocation2 = TextBox2.Text
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        AxWindowsMediaPlayer2.settings.balance = TrackBar2.Value * 10
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
