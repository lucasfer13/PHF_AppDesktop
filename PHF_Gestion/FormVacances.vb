Public Class FormVacances
    Public dataInici As Date
    Public dataFinal As Date

    Private Sub txtVacancesValidador_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVacancesValidador.Validating, txtVacancesValidador.Validating
        If dtpVacancesDataInici.Value > dtpVacancesDataFinal.Value Then
            e.Cancel = True
            erpVacancesErrors.SetError(dtpVacancesDataInici, My.Resources.DataIniciInferior)
        End If
        If Not e.Cancel Then
            erpVacancesErrors.SetError(dtpVacancesDataInici, "")
        End If
    End Sub

    Private Sub btnVacancesGuardar_Click(sender As Object, e As EventArgs) Handles btnVacancesGuardar.Click
        If Me.ValidateChildren Then
            dataInici = dtpVacancesDataInici.Value
            dataFinal = dtpVacancesDataFinal.Value
            Me.Close()
        End If
    End Sub

    Private Sub FormVacances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataInici = Nothing
        dataFinal = Nothing
    End Sub

End Class