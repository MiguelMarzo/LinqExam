Public Class Zona : Implements IEquatable(Of Zona)

    Public Property Id As String
    Public Property Nombre As String

    Public Sub New()

    End Sub
    Public Sub New(id As String, nombre As String, descripcion As String)
        Me.Id = id
        Me.Nombre = nombre
    End Sub

    Public Overloads Function Equals(other As Zona) As Boolean Implements IEquatable(Of Zona).Equals
        Return (Id.ToUpper.Equals(other.Id.ToUpper))
    End Function
End Class
