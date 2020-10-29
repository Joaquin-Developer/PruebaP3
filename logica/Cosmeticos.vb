Public Class Cosmeticos

    Public Property nombre As String
    Public Property tipo As TipoCosmetico
    Public Property precio As Integer
    Public Property fueComprado As Boolean

    Public Enum TipoCosmetico
        Skin
        Emote
        Audio
    End Enum

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, tipo As String, precio As Integer, fueComprado As Boolean)
        Me.nombre = nombre
        Me.tipo = tipo
        Me.precio = precio
        Me.fueComprado = fueComprado
    End Sub

    Public Overrides Function ToString() As String
        Return "Nombre: " & Me.nombre & ", Tipo: " & Me.tipo.ToString()
    End Function

End Class
