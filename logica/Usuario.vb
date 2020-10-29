Public Class Usuario

    ' clase controlador de logica para modificar gemas de usuario

    Public Shared Property instancia As New Usuario
    Private Property gemasRestantes As Integer

    Private Sub New()
    End Sub

    Public Function GetGemasRestantes() As Integer
        Return Me.gemasRestantes
    End Function

    Public Sub SetGemasRestantes(gemasRestantes As Integer)
        If IsNothing(gemasRestantes) Then Throw New NullReferenceException("No se pudo obtener la cantidad de gemas restantes.")
        Me.gemasRestantes = gemasRestantes
    End Sub

End Class
