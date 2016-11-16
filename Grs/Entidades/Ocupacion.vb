Public Class Ocupacion : Implements IEquatable(Of Ocupacion)

    Public Property DNI As String
    Public Property IdAlbergue As String
    Public Property Nombre As String
    Public Property Telefono As String


    Public Sub New()

    End Sub
    Public Sub New(dni As String, idAlbergue As String, nombre As String, telefono As String)
        Me.DNI = dni
        Me.Nombre = nombre
        Me.IdAlbergue = idAlbergue
        Me.Telefono = telefono
    End Sub

    Public Overloads Function Equals(other As Ocupacion) As Boolean Implements IEquatable(Of Ocupacion).Equals
        Return (DNI.ToUpper.Equals(other.DNI.ToUpper))
    End Function
End Class
