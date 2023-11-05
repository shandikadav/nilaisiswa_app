Imports System.Data.SqlClient
Public Class loginform

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM Akun WHERE Username = '" + txt_uname.Text + "' AND Password = '" + txt_pass.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            If rd.Item(2).ToString = "Administrator" Then
                MessageBox.Show("Login Administrator Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AdminMenu.Show()
                Me.Hide()
            ElseIf rd.Item(2).ToString = "Siswa" Then
                MessageBox.Show("Login Siswa Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SiswaMenu.Show()
                Me.Hide()
            End If
        End If

    End Sub
End Class
