Public Class Form1
    Dim a, b, v As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
         
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text > 0 Or TextBox2.Text > 0 Or TextBox4.Text > 0 Then


                b = CSng(TextBox2.Text * 60) + TextBox4.Text
                v = TextBox1.Text / b
                Form3.TextBox1.Text = v * 60
                Form3.Show()
                Me.Close()
            End If
            Catch ex As Exception
            MessageBox.Show(ex.Message, "กรุณาใส่ตัวเลข", MessageBoxButtons.OK)

        End Try

        Try


        Catch ex As Exception
            MessageBox.Show(ex.Message, "กรุณาใส่ตัวเลข", MessageBoxButtons.OK)
            Form3.TextBox1.Text = 0
            Form3.Show()
        End Try


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
            Form3.Close()
            Form2.Close()

        End If


        
    End Sub
End Class
