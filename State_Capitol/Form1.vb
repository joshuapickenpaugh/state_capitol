' Joshua Pickenpaugh
' September 10th, 2016
' "State Capitols", CPT 432, UNIT 4 

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'CLoses the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Select Case:
        Select Case True
            Case rdoAlabama.Checked AndAlso rdoMontgomery.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoAlaska.Checked AndAlso rdoJuneau.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoArizona.Checked AndAlso rdoPhoenix.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoArkansas.Checked AndAlso rdoLittleRock.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoCalifornia.Checked AndAlso rdoSacramento.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoColorado.Checked AndAlso rdoDenver.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoConnecticut.Checked AndAlso rdoHartford.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoDelaware.Checked AndAlso rdoDover.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoFlorida.Checked AndAlso rdoTallahassee.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case rdoGeorgia.Checked AndAlso rdoAtlanta.Checked
                lblResult.ForeColor = Color.Green
                lblResult.Text = "Correct!!!"

            Case Else
                lblResult.ForeColor = Color.Red
                lblResult.Text = "Try Again..."
        End Select

    End Sub
End Class
