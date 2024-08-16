'Telegram: @MONSTERMC
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' تأكد من أن TextBox1 يحتوي على رابط
        If TextBox1.Text.Contains("details?id=") Then
            ' استخراج الجزء بعد "details?id="
            Dim extractedPart As String = TextBox1.Text.Split(New String() {"details?id="}, StringSplitOptions.None)(1)

            ' إنشاء الرابط الجديد
            Dim newUrl As String = "https://apps.evozi.com/apk-downloader/?id=" & extractedPart

            ' وضع الرابط الجديد في TextBox2
            TextBox2.Text = newUrl
            Process.Start(TextBox2.Text)
        Else
            MessageBox.Show("الرابط غير صحيح. تأكد من احتوائه على 'details?id='")
        End If
        'اتمنى من الجميع التوفيق في كل شيئ
    End Sub
End Class
