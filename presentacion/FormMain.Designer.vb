<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gBoxCosmeticosDisponibles = New System.Windows.Forms.GroupBox()
        Me.dgvListaCosmeticos = New System.Windows.Forms.DataGridView()
        Me.gBoxCompraCosmeticos = New System.Windows.Forms.GroupBox()
        Me.lblInfoTotalGemas = New System.Windows.Forms.Label()
        Me.lblGemasDisponibles = New System.Windows.Forms.Label()
        Me.lblNombreCosmetico = New System.Windows.Forms.Label()
        Me.cBoxNombresCosmeticos = New System.Windows.Forms.ComboBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.gBoxComprarGemas = New System.Windows.Forms.GroupBox()
        Me.btnComprar500gemas = New System.Windows.Forms.Button()
        Me.btnComprar1200gemas = New System.Windows.Forms.Button()
        Me.btnComprar2750gemas = New System.Windows.Forms.Button()
        Me.btnComprar11000gemas = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gBoxCosmeticosDisponibles.SuspendLayout()
        CType(Me.dgvListaCosmeticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxCompraCosmeticos.SuspendLayout()
        Me.gBoxComprarGemas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBoxCosmeticosDisponibles
        '
        Me.gBoxCosmeticosDisponibles.Controls.Add(Me.dgvListaCosmeticos)
        Me.gBoxCosmeticosDisponibles.Location = New System.Drawing.Point(12, 12)
        Me.gBoxCosmeticosDisponibles.Name = "gBoxCosmeticosDisponibles"
        Me.gBoxCosmeticosDisponibles.Size = New System.Drawing.Size(480, 277)
        Me.gBoxCosmeticosDisponibles.TabIndex = 0
        Me.gBoxCosmeticosDisponibles.TabStop = False
        Me.gBoxCosmeticosDisponibles.Text = "Lista de Cosmeticos "
        '
        'dgvListaCosmeticos
        '
        Me.dgvListaCosmeticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCosmeticos.Location = New System.Drawing.Point(6, 19)
        Me.dgvListaCosmeticos.Name = "dgvListaCosmeticos"
        Me.dgvListaCosmeticos.Size = New System.Drawing.Size(460, 228)
        Me.dgvListaCosmeticos.TabIndex = 0
        '
        'gBoxCompraCosmeticos
        '
        Me.gBoxCompraCosmeticos.Controls.Add(Me.btnComprar)
        Me.gBoxCompraCosmeticos.Controls.Add(Me.cBoxNombresCosmeticos)
        Me.gBoxCompraCosmeticos.Controls.Add(Me.lblNombreCosmetico)
        Me.gBoxCompraCosmeticos.Controls.Add(Me.lblGemasDisponibles)
        Me.gBoxCompraCosmeticos.Controls.Add(Me.lblInfoTotalGemas)
        Me.gBoxCompraCosmeticos.Location = New System.Drawing.Point(12, 295)
        Me.gBoxCompraCosmeticos.Name = "gBoxCompraCosmeticos"
        Me.gBoxCompraCosmeticos.Size = New System.Drawing.Size(480, 208)
        Me.gBoxCompraCosmeticos.TabIndex = 1
        Me.gBoxCompraCosmeticos.TabStop = False
        Me.gBoxCompraCosmeticos.Text = "COMPRAR UN COSMETICO"
        '
        'lblInfoTotalGemas
        '
        Me.lblInfoTotalGemas.AutoSize = True
        Me.lblInfoTotalGemas.Location = New System.Drawing.Point(15, 39)
        Me.lblInfoTotalGemas.Name = "lblInfoTotalGemas"
        Me.lblInfoTotalGemas.Size = New System.Drawing.Size(207, 13)
        Me.lblInfoTotalGemas.TabIndex = 0
        Me.lblInfoTotalGemas.Text = "Total de gemas disponibles en su Cuenta: "
        '
        'lblGemasDisponibles
        '
        Me.lblGemasDisponibles.AutoSize = True
        Me.lblGemasDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGemasDisponibles.Location = New System.Drawing.Point(228, 37)
        Me.lblGemasDisponibles.Name = "lblGemasDisponibles"
        Me.lblGemasDisponibles.Size = New System.Drawing.Size(47, 15)
        Me.lblGemasDisponibles.TabIndex = 1
        Me.lblGemasDisponibles.Text = "00000"
        '
        'lblNombreCosmetico
        '
        Me.lblNombreCosmetico.AutoSize = True
        Me.lblNombreCosmetico.Location = New System.Drawing.Point(15, 84)
        Me.lblNombreCosmetico.Name = "lblNombreCosmetico"
        Me.lblNombreCosmetico.Size = New System.Drawing.Size(207, 13)
        Me.lblNombreCosmetico.TabIndex = 2
        Me.lblNombreCosmetico.Text = "Nombre de cosmetico que desea comprar:"
        '
        'cBoxNombresCosmeticos
        '
        Me.cBoxNombresCosmeticos.FormattingEnabled = True
        Me.cBoxNombresCosmeticos.Location = New System.Drawing.Point(231, 81)
        Me.cBoxNombresCosmeticos.Name = "cBoxNombresCosmeticos"
        Me.cBoxNombresCosmeticos.Size = New System.Drawing.Size(171, 21)
        Me.cBoxNombresCosmeticos.TabIndex = 3
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(18, 112)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(384, 23)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "COMPRAR"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'gBoxComprarGemas
        '
        Me.gBoxComprarGemas.Controls.Add(Me.btnComprar11000gemas)
        Me.gBoxComprarGemas.Controls.Add(Me.btnComprar2750gemas)
        Me.gBoxComprarGemas.Controls.Add(Me.btnComprar1200gemas)
        Me.gBoxComprarGemas.Controls.Add(Me.btnComprar500gemas)
        Me.gBoxComprarGemas.Location = New System.Drawing.Point(520, 12)
        Me.gBoxComprarGemas.Name = "gBoxComprarGemas"
        Me.gBoxComprarGemas.Size = New System.Drawing.Size(330, 213)
        Me.gBoxComprarGemas.TabIndex = 2
        Me.gBoxComprarGemas.TabStop = False
        Me.gBoxComprarGemas.Text = "COMPRAR GEMAS"
        '
        'btnComprar500gemas
        '
        Me.btnComprar500gemas.Location = New System.Drawing.Point(15, 29)
        Me.btnComprar500gemas.Name = "btnComprar500gemas"
        Me.btnComprar500gemas.Size = New System.Drawing.Size(110, 37)
        Me.btnComprar500gemas.TabIndex = 0
        Me.btnComprar500gemas.Text = "500 GEMAS"
        Me.btnComprar500gemas.UseVisualStyleBackColor = True
        '
        'btnComprar1200gemas
        '
        Me.btnComprar1200gemas.Location = New System.Drawing.Point(179, 29)
        Me.btnComprar1200gemas.Name = "btnComprar1200gemas"
        Me.btnComprar1200gemas.Size = New System.Drawing.Size(113, 37)
        Me.btnComprar1200gemas.TabIndex = 1
        Me.btnComprar1200gemas.Text = "1200 GEMAS"
        Me.btnComprar1200gemas.UseVisualStyleBackColor = True
        '
        'btnComprar2750gemas
        '
        Me.btnComprar2750gemas.Location = New System.Drawing.Point(15, 81)
        Me.btnComprar2750gemas.Name = "btnComprar2750gemas"
        Me.btnComprar2750gemas.Size = New System.Drawing.Size(110, 37)
        Me.btnComprar2750gemas.TabIndex = 2
        Me.btnComprar2750gemas.Text = "2750 GEMAS"
        Me.btnComprar2750gemas.UseVisualStyleBackColor = True
        '
        'btnComprar11000gemas
        '
        Me.btnComprar11000gemas.Location = New System.Drawing.Point(179, 81)
        Me.btnComprar11000gemas.Name = "btnComprar11000gemas"
        Me.btnComprar11000gemas.Size = New System.Drawing.Size(113, 37)
        Me.btnComprar11000gemas.TabIndex = 3
        Me.btnComprar11000gemas.Text = "11000 GEMAS"
        Me.btnComprar11000gemas.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(775, 504)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "SALIR"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 539)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gBoxComprarGemas)
        Me.Controls.Add(Me.gBoxCompraCosmeticos)
        Me.Controls.Add(Me.gBoxCosmeticosDisponibles)
        Me.Name = "FormMain"
        Me.Text = "Formulario Principal - Compra de Cosmeticos"
        Me.gBoxCosmeticosDisponibles.ResumeLayout(False)
        CType(Me.dgvListaCosmeticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxCompraCosmeticos.ResumeLayout(False)
        Me.gBoxCompraCosmeticos.PerformLayout()
        Me.gBoxComprarGemas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gBoxCosmeticosDisponibles As GroupBox
    Friend WithEvents dgvListaCosmeticos As DataGridView
    Friend WithEvents gBoxCompraCosmeticos As GroupBox
    Friend WithEvents btnComprar As Button
    Friend WithEvents cBoxNombresCosmeticos As ComboBox
    Friend WithEvents lblNombreCosmetico As Label
    Friend WithEvents lblGemasDisponibles As Label
    Friend WithEvents lblInfoTotalGemas As Label
    Friend WithEvents gBoxComprarGemas As GroupBox
    Friend WithEvents btnComprar11000gemas As Button
    Friend WithEvents btnComprar2750gemas As Button
    Friend WithEvents btnComprar1200gemas As Button
    Friend WithEvents btnComprar500gemas As Button
    Friend WithEvents btnExit As Button
End Class
