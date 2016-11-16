Imports CapaNegocio
Imports Entidades
Public Class frmInicio

    Private _negocio As New Negocio
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each gr In _negocio.DevolverGrs
            cmbGr.Items.Add(gr)
            cmbGr.DisplayMember = "id"
        Next

    End Sub

    Private Sub cmbGr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGr.SelectedIndexChanged
        Dim gr As Gr = cmbGr.SelectedItem
        lblDescripcionMostrar.Text = gr.Descripcion
        lblDesnivelMaximoMostrar.Text = gr.DesnivelMaximo
        lblKmTotalesMostrar.Text = gr.KmsTotales
        lblNombreGrMostrar.Text = gr.Nombre
        dgvEtapas.DataSource = _negocio.EtapasPorGr(gr.Id)
        lblEtapas.Text = "Etapas del " & gr.Id
    End Sub


    Private Sub ddgvEtapas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEtapas.CellEnter
        If _negocio.AlberguesPorZona(dgvEtapas.CurrentRow.Cells(2).Value).Count = 0 Then
            dgvAlbergues.Hide()
            lblAlbergues.Text = "Albergues de " & dgvEtapas.CurrentRow.Cells(2).Value & " NO HAY ALBERGUES"
        Else
            dgvAlbergues.Show()
            dgvAlbergues.DataSource = _negocio.AlberguesPorZona(dgvEtapas.CurrentRow.Cells(2).Value)
            lblAlbergues.Text = "Albergues de " & dgvEtapas.CurrentRow.Cells(2).Value
        End If


    End Sub

End Class
