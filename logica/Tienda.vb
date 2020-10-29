Public Class Tienda

    ' clase de controlador de logica de cosmeticos

    Public Shared Property instancia As New Tienda
    Private Property listaCosmeticos As New List(Of Cosmeticos)

    Private Sub New()
    End Sub

    Public Sub AgregarCosmetico(cosmeticos As Cosmeticos)
        Me.listaCosmeticos.Add(cosmeticos)
    End Sub

    Public Function BuscarCosmeticoPorNombre(nombre As String) As Cosmeticos
        For Each cosmetico As Cosmeticos In Me.listaCosmeticos
            If cosmetico.nombre.Equals(nombre) Then
                Return cosmetico
            End If
        Next
        Throw New Exception("No se encontrò el cosmètico ")

    End Function

    Public Function GetListaCosmeticos() As List(Of Cosmeticos)
        Return Me.listaCosmeticos
    End Function

    Public Sub ModificarCompraCosmetico(cosmeticoModificar As Cosmeticos)

        For i As Integer = 0 To Me.listaCosmeticos.Count - 1
            If listaCosmeticos(i).nombre.Equals(cosmeticoModificar.nombre) Then
                listaCosmeticos.Item(i) = cosmeticoModificar
            End If
        Next

    End Sub


End Class
