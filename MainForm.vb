Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTN_HOMBRES_Click(sender As Object, e As EventArgs) Handles BTN_HOMBRES.Click
        BTN_HOMBRES.ForeColor = Color.SteelBlue
        BTN_MUJERES.ForeColor = Color.Black
        BTN_CALZADO.ForeColor = Color.Black
        BTN_ACCESORIOS.ForeColor = Color.Black

        BTN_XS.Text = "XL"
        BTN_XS.ForeColor = Color.Plum
        BTN_S.Text = "S"
        BTN_S.ForeColor = Color.Black
        BTN_M.Text = "M"
        BTN_M.ForeColor = Color.Black
        BTN_L.Text = "L"
        BTN_L.ForeColor = Color.Black
        BTN_XL.Text = "XL"
        BTN_XL.ForeColor = Color.Plum


        PictureBox1.ImageLocation =
        PictureBox2.ImageLocation =
            PictureBox3.ImageLocation = 2
        PictureBox4.ImageLocation = 3







    End Sub

    Private Sub BTN_MUJERES_Click(sender As Object, e As EventArgs) Handles BTN_MUJERES.Click
        BTN_MUJERES.ForeColor = Color.SteelBlue
        BTN_HOMBRES.ForeColor = Color.Black
        BTN_CALZADO.ForeColor = Color.Black
        BTN_ACCESORIOS.ForeColor = Color.Black

        BTN_XS.Text = "XL"
        BTN_XS.ForeColor = Color.Plum
        BTN_S.Text = "S"
        BTN_S.ForeColor = Color.Black
        BTN_M.Text = "M"
        BTN_M.ForeColor = Color.Black
        BTN_L.Text = "L"
        BTN_L.ForeColor = Color.Black
        BTN_XL.Text = "XL"
        BTN_XL.ForeColor = Color.Plum


    End Sub

    Private Sub BTN_CALZADO_Click(sender As Object, e As EventArgs) Handles BTN_CALZADO.Click
        BTN_CALZADO.ForeColor = Color.SteelBlue
        BTN_HOMBRES.ForeColor = Color.Black
        BTN_MUJERES.ForeColor = Color.Black
        BTN_ACCESORIOS.ForeColor = Color.Black

        BTN_XS.Text = "37"
        BTN_XS.ForeColor = Color.Plum
        BTN_S.Text = "38"
        BTN_S.ForeColor = Color.Black
        BTN_M.Text = "40"
        BTN_M.ForeColor = Color.Black
        BTN_L.Text = "41"
        BTN_L.ForeColor = Color.Black
        BTN_XL.Text = "42"
        BTN_XL.ForeColor = Color.Plum
    End Sub

    Private Sub BTN_ACCESORIOS_Click(sender As Object, e As EventArgs) Handles BTN_ACCESORIOS.Click
        BTN_ACCESORIOS.ForeColor = Color.SteelBlue
        BTN_HOMBRES.ForeColor = Color.Black
        BTN_MUJERES.ForeColor = Color.Black
        BTN_CALZADO.ForeColor = Color.Black

        BTN_XS.Text = ""

        BTN_S.Text = ""

        BTN_M.Text = ""

        BTN_L.Text = ""

        BTN_XL.Text = ""


    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

    End Sub

    Private Sub tblNavigation_Paint(sender As Object, e As PaintEventArgs) Handles tblNavigation.Paint

        ToString()

    End Sub
End Class