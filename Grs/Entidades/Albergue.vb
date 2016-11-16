Public Class Albergue : Implements IEquatable(Of Albergue)

    Public Property Id As String
    Public Property idZona As String
    Public Property Nombre As String
    Public Property TotalPlazas As Integer
    Public Property Precio As Integer
    Public Property NombreZona As String
    Public Property PlazasOcupadas As Integer


    Public Sub New()

    End Sub
    Public Sub New(id As String, idZona As String, nombre As String, totalPlazas As Integer, precio As Integer, nombreZona As String, plazasOcupadas As Integer)
        Me.Id = id
        Me.Nombre = nombre
        Me.idZona = idZona
        Me.TotalPlazas = totalPlazas
        Me.Precio = precio
        Me.NombreZona = nombreZona
        Me.PlazasOcupadas = plazasOcupadas
    End Sub

    Public Overloads Function Equals(other As Albergue) As Boolean Implements IEquatable(Of Albergue).Equals
        Return (Id.ToUpper.Equals(other.Id.ToUpper))
    End Function
End Class
