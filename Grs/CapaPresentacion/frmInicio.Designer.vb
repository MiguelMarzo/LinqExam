<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGr = New System.Windows.Forms.Label()
        Me.cmbGr = New System.Windows.Forms.ComboBox()
        Me.lblNombreGr = New System.Windows.Forms.Label()
        Me.lblNombreGrMostrar = New System.Windows.Forms.Label()
        Me.lblDescripcionMostrar = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblKmTotalesMostrar = New System.Windows.Forms.Label()
        Me.lblKmTotales = New System.Windows.Forms.Label()
        Me.lblDesnivelMaximoMostrar = New System.Windows.Forms.Label()
        Me.lblDesnivelMaximo = New System.Windows.Forms.Label()
        Me.lblEtapas = New System.Windows.Forms.Label()
        Me.dgvEtapas = New System.Windows.Forms.DataGridView()
        Me.dgvAlbergues = New System.Windows.Forms.DataGridView()
        Me.lblAlbergues = New System.Windows.Forms.Label()
        CType(Me.dgvEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlbergues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGr
        '
        Me.lblGr.AutoSize = True
        Me.lblGr.Location = New System.Drawing.Point(200, 50)
        Me.lblGr.Name = "lblGr"
        Me.lblGr.Size = New System.Drawing.Size(33, 17)
        Me.lblGr.TabIndex = 0
        Me.lblGr.Text = "GR:"
        '
        'cmbGr
        '
        Me.cmbGr.FormattingEnabled = True
        Me.cmbGr.Location = New System.Drawing.Point(239, 47)
        Me.cmbGr.Name = "cmbGr"
        Me.cmbGr.Size = New System.Drawing.Size(183, 24)
        Me.cmbGr.TabIndex = 1
        '
        'lblNombreGr
        '
        Me.lblNombreGr.AutoSize = True
        Me.lblNombreGr.Location = New System.Drawing.Point(675, 54)
        Me.lblNombreGr.Name = "lblNombreGr"
        Me.lblNombreGr.Size = New System.Drawing.Size(78, 17)
        Me.lblNombreGr.TabIndex = 2
        Me.lblNombreGr.Text = "Nombre Gr"
        '
        'lblNombreGrMostrar
        '
        Me.lblNombreGrMostrar.AutoSize = True
        Me.lblNombreGrMostrar.BackColor = System.Drawing.Color.PaleGreen
        Me.lblNombreGrMostrar.Location = New System.Drawing.Point(793, 54)
        Me.lblNombreGrMostrar.MinimumSize = New System.Drawing.Size(300, 0)
        Me.lblNombreGrMostrar.Name = "lblNombreGrMostrar"
        Me.lblNombreGrMostrar.Size = New System.Drawing.Size(300, 17)
        Me.lblNombreGrMostrar.TabIndex = 3
        '
        'lblDescripcionMostrar
        '
        Me.lblDescripcionMostrar.AutoSize = True
        Me.lblDescripcionMostrar.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDescripcionMostrar.Location = New System.Drawing.Point(260, 89)
        Me.lblDescripcionMostrar.MinimumSize = New System.Drawing.Size(300, 0)
        Me.lblDescripcionMostrar.Name = "lblDescripcionMostrar"
        Me.lblDescripcionMostrar.Size = New System.Drawing.Size(300, 17)
        Me.lblDescripcionMostrar.TabIndex = 5
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(142, 89)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblKmTotalesMostrar
        '
        Me.lblKmTotalesMostrar.AutoSize = True
        Me.lblKmTotalesMostrar.BackColor = System.Drawing.Color.PaleGreen
        Me.lblKmTotalesMostrar.Location = New System.Drawing.Point(890, 93)
        Me.lblKmTotalesMostrar.MinimumSize = New System.Drawing.Size(150, 0)
        Me.lblKmTotalesMostrar.Name = "lblKmTotalesMostrar"
        Me.lblKmTotalesMostrar.Size = New System.Drawing.Size(150, 17)
        Me.lblKmTotalesMostrar.TabIndex = 7
        '
        'lblKmTotales
        '
        Me.lblKmTotales.AutoSize = True
        Me.lblKmTotales.Location = New System.Drawing.Point(771, 93)
        Me.lblKmTotales.Name = "lblKmTotales"
        Me.lblKmTotales.Size = New System.Drawing.Size(86, 17)
        Me.lblKmTotales.TabIndex = 6
        Me.lblKmTotales.Text = "Kms Totales"
        '
        'lblDesnivelMaximoMostrar
        '
        Me.lblDesnivelMaximoMostrar.AutoSize = True
        Me.lblDesnivelMaximoMostrar.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDesnivelMaximoMostrar.Location = New System.Drawing.Point(890, 130)
        Me.lblDesnivelMaximoMostrar.MinimumSize = New System.Drawing.Size(150, 0)
        Me.lblDesnivelMaximoMostrar.Name = "lblDesnivelMaximoMostrar"
        Me.lblDesnivelMaximoMostrar.Size = New System.Drawing.Size(150, 17)
        Me.lblDesnivelMaximoMostrar.TabIndex = 9
        '
        'lblDesnivelMaximo
        '
        Me.lblDesnivelMaximo.AutoSize = True
        Me.lblDesnivelMaximo.Location = New System.Drawing.Point(771, 130)
        Me.lblDesnivelMaximo.Name = "lblDesnivelMaximo"
        Me.lblDesnivelMaximo.Size = New System.Drawing.Size(113, 17)
        Me.lblDesnivelMaximo.TabIndex = 8
        Me.lblDesnivelMaximo.Text = "Desnivel Maximo"
        '
        'lblEtapas
        '
        Me.lblEtapas.AutoSize = True
        Me.lblEtapas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapas.Location = New System.Drawing.Point(168, 201)
        Me.lblEtapas.Name = "lblEtapas"
        Me.lblEtapas.Size = New System.Drawing.Size(145, 25)
        Me.lblEtapas.TabIndex = 10
        Me.lblEtapas.Text = "Etapas de GR"
        '
        'dgvEtapas
        '
        Me.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtapas.Location = New System.Drawing.Point(12, 261)
        Me.dgvEtapas.Name = "dgvEtapas"
        Me.dgvEtapas.RowTemplate.Height = 24
        Me.dgvEtapas.Size = New System.Drawing.Size(629, 353)
        Me.dgvEtapas.TabIndex = 11
        '
        'dgvAlbergues
        '
        Me.dgvAlbergues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlbergues.Location = New System.Drawing.Point(693, 261)
        Me.dgvAlbergues.Name = "dgvAlbergues"
        Me.dgvAlbergues.RowTemplate.Height = 24
        Me.dgvAlbergues.Size = New System.Drawing.Size(629, 353)
        Me.dgvAlbergues.TabIndex = 12
        '
        'lblAlbergues
        '
        Me.lblAlbergues.AutoSize = True
        Me.lblAlbergues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbergues.Location = New System.Drawing.Point(816, 201)
        Me.lblAlbergues.Name = "lblAlbergues"
        Me.lblAlbergues.Size = New System.Drawing.Size(110, 25)
        Me.lblAlbergues.TabIndex = 13
        Me.lblAlbergues.Text = "Albergues"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 646)
        Me.Controls.Add(Me.lblAlbergues)
        Me.Controls.Add(Me.dgvAlbergues)
        Me.Controls.Add(Me.dgvEtapas)
        Me.Controls.Add(Me.lblEtapas)
        Me.Controls.Add(Me.lblDesnivelMaximoMostrar)
        Me.Controls.Add(Me.lblDesnivelMaximo)
        Me.Controls.Add(Me.lblKmTotalesMostrar)
        Me.Controls.Add(Me.lblKmTotales)
        Me.Controls.Add(Me.lblDescripcionMostrar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblNombreGrMostrar)
        Me.Controls.Add(Me.lblNombreGr)
        Me.Controls.Add(Me.cmbGr)
        Me.Controls.Add(Me.lblGr)
        Me.Name = "frmInicio"
        Me.Text = "Form1"
        CType(Me.dgvEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlbergues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGr As Label
    Friend WithEvents cmbGr As ComboBox
    Friend WithEvents lblNombreGr As Label
    Friend WithEvents lblNombreGrMostrar As Label
    Friend WithEvents lblDescripcionMostrar As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblKmTotalesMostrar As Label
    Friend WithEvents lblKmTotales As Label
    Friend WithEvents lblDesnivelMaximoMostrar As Label
    Friend WithEvents lblDesnivelMaximo As Label
    Friend WithEvents lblEtapas As Label
    Friend WithEvents dgvEtapas As DataGridView
    Friend WithEvents dgvAlbergues As DataGridView
    Friend WithEvents lblAlbergues As Label
End Class
