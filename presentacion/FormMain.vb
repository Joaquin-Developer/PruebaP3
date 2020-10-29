Imports logica

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosIniciales()
        CargarDataGrid()
        CargarComboBoxNombres()
        ' se carga la info de gemasRestantes del usuario:
        lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString

    End Sub

    Private Sub CargarDatosIniciales()
        ' en esta clase cargamos los datos iniciales de ambas clases de controladorLogica

        ' datos de Tienda:
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Crowe Shadow Hunter", Cosmeticos.TipoCosmetico.Skin, 800, False))
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Majus Eldritch Master", Cosmeticos.TipoCosmetico.Skin, 800, False))
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Humillaciòn", Cosmeticos.TipoCosmetico.Emote, 550, False))
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Provocacion", Cosmeticos.TipoCosmetico.Emote, 550, False))
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Soudtrack Adicional", Cosmeticos.TipoCosmetico.Audio, 630, False))
        Tienda.instancia.AgregarCosmetico(New Cosmeticos("Anunciador", Cosmeticos.TipoCosmetico.Audio, 630, False))

        ' datos de Usuario:
        Usuario.instancia.SetGemasRestantes(2000)

    End Sub

    Private Sub CargarDataGrid()
        Try
            Dim dataSet As New DataSet()
            Dim dataTable As DataTable = dataSet.Tables.Add()
            dataTable.Columns.Add("Nombre")
            dataTable.Columns.Add("Tipo")
            dataTable.Columns.Add("Precio")
            dataTable.Columns.Add("Stock")
            'Dim listaCosmeticos As List(Of Cosmeticos) = Tienda.instancia.GetListaCosmeticos
            For Each cosmetico As Cosmeticos In Tienda.instancia.GetListaCosmeticos
                If cosmetico.fueComprado Then
                    dataTable.Rows.Add(cosmetico.nombre, cosmetico.tipo.ToString, cosmetico.precio.ToString, "No")
                Else
                    dataTable.Rows.Add(cosmetico.nombre, cosmetico.tipo.ToString, cosmetico.precio.ToString, "Si")
                End If
            Next

            dgvListaCosmeticos.DataSource = dataTable
            dgvListaCosmeticos.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CargarComboBoxNombres()
        Try
            cBoxNombresCosmeticos.Items.Clear()
            For Each cosmetico As Cosmeticos In Tienda.instancia.GetListaCosmeticos
                cBoxNombresCosmeticos.Items.Add(cosmetico.nombre)
            Next
            cBoxNombresCosmeticos.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al cargar nombres de cosmeticos")
        End Try

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Try
            Dim cosmeticoComprar As Cosmeticos = Tienda.instancia.BuscarCosmeticoPorNombre(cBoxNombresCosmeticos.SelectedItem.ToString)
            'MsgBox(cosmeticoComprar.ToString)
            If cosmeticoComprar.fueComprado Then
                Throw New Exception("El cosmetico ya fue comprado.")
            ElseIf cosmeticoComprar.precio > Usuario.instancia.GetGemasRestantes Then
                Throw New Exception("No tienes suficientes gemas para comprar este cosmetico")
            Else
                ' si todo està bien, se procede a hacer la compra
                Usuario.instancia.SetGemasRestantes((Usuario.instancia.GetGemasRestantes - cosmeticoComprar.precio))
                cosmeticoComprar.fueComprado = True
                Tienda.instancia.ModificarCompraCosmetico(cosmeticoComprar)

                ' luego, se actualizan todos los datos:
                CargarDataGrid()
                CargarComboBoxNombres()
                lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al realizar la compra.")
        End Try

    End Sub

    Private Sub btnComprar500gemas_Click(sender As Object, e As EventArgs) Handles btnComprar500gemas.Click
        Usuario.instancia.SetGemasRestantes((Usuario.instancia.GetGemasRestantes + 500))
        lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString
    End Sub

    Private Sub btnComprar1200gemas_Click(sender As Object, e As EventArgs) Handles btnComprar1200gemas.Click
        Usuario.instancia.SetGemasRestantes((Usuario.instancia.GetGemasRestantes + 1200))
        lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString
    End Sub

    Private Sub btnComprar2750gemas_Click(sender As Object, e As EventArgs) Handles btnComprar2750gemas.Click
        Usuario.instancia.SetGemasRestantes((Usuario.instancia.GetGemasRestantes + 2750))
        lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString
    End Sub

    Private Sub btnComprar11000gemas_Click(sender As Object, e As EventArgs) Handles btnComprar11000gemas.Click
        Usuario.instancia.SetGemasRestantes((Usuario.instancia.GetGemasRestantes + 11000))
        lblGemasDisponibles.Text = Usuario.instancia.GetGemasRestantes.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
