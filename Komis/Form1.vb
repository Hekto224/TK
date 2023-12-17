Imports System.Net.Security

Public Class Form1
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Klasa A")
            ListBox2.Items.Add("Klasa C")
        ElseIf ListBox1.SelectedIndex = 1 Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("3")
            ListBox2.Items.Add("5")
        ElseIf ListBox1.SelectedIndex = 2 Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("RX7")
            ListBox2.Items.Add("RX8")
            ListBox2.Items.Add("6")
        ElseIf ListBox1.SelectedIndex = 3 Then
            ListBox2.Items.Clear()
            ListBox2.Items.Add("Octavia")
        End If

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged, ListBox2.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 And ListBox2.SelectedIndex = 0 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.4 Benzyna")
            ListBox3.Items.Add("2.0 Diesel")
        ElseIf ListBox1.SelectedIndex = 0 And ListBox2.SelectedIndex = 1 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.5 Benzyna")
            ListBox3.Items.Add("2.0 Diesel")
        ElseIf ListBox1.SelectedIndex = 1 And ListBox2.SelectedIndex = 0 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.8 Benzyna")
            ListBox3.Items.Add("2.0 Benzyna")
        ElseIf ListBox1.SelectedIndex = 1 And ListBox2.SelectedIndex = 1 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("2.0 Benzyna")
        ElseIf ListBox1.SelectedIndex = 2 And ListBox2.SelectedIndex = 0 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.3 Benzyna")
        ElseIf ListBox1.SelectedIndex = 2 And ListBox2.SelectedIndex = 1 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.3 Benzyna")
        ElseIf ListBox1.SelectedIndex = 2 And ListBox2.SelectedIndex = 2 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("2.0 Diesel")
            ListBox3.Items.Add("2.5 Diesel")
        ElseIf ListBox1.SelectedIndex = 3 And ListBox2.SelectedIndex = 0 Then
            ListBox3.Items.Clear()
            ListBox3.Items.Add("1.0 Benzyna")
            ListBox3.Items.Add("1.5 Benzyna")
            ListBox3.Items.Add("2.0 Diesel")
        End If
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        ListBox4.Items.Clear()
        ListBox4.Items.Add("Metalic")
        ListBox4.Items.Add("Mat")
        ListBox4.Items.Add("Chrome")
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndex = 0 Then
            ListBox5.Items.Clear()
            ListBox5.Items.Add("Czerwony")
            ListBox5.Items.Add("Bialy")
            ListBox5.Items.Add("Czarny")
        Else
            ListBox5.Items.Clear()
            ListBox5.Items.Add("Czerwony")
            ListBox5.Items.Add("Bialy")
            ListBox5.Items.Add("Czarny")
            ListBox5.Items.Add("Niebieski")
            ListBox5.Items.Add("Zielony")
        End If
    End Sub

    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        ListBox6.Items.Clear()
        ListBox6.Items.Add("Tempomat")
        ListBox6.Items.Add("System glosniomowiacy")
        ListBox6.Items.Add("Podgrzewany fotel")
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged
        'PictureBox1.Image = Image.FromFile("D:\Pawel\TK\Mercedes klasa A.jpg")
        If ListBox1.SelectedIndex = 0 And ListBox2.SelectedIndex = 0 Then
            PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Mercedes klasa A.jpg"))
        ElseIf ListBox1.SelectedIndex = 0 And ListBox2.SelectedIndex = 1 Then
            PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Mercedes klasa C.jpg"))
        ElseIf ListBox1.SelectedIndex = 1 And ListBox2.SelectedIndex = 0 Then
            PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "BMW 3.jpg"))
        ElseIf ListBox1.SelectedIndex = 1 And ListBox2.SelectedIndex = 1 Then
            PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "BMW 5.jpg"))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox6.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox6.Items(ListBox6.SelectedIndex) = TextBox1.Text
    End Sub
End Class
