Public Class Gr : Implements IEquatable(Of Gr)

    Public Property Id As String
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property KmsTotales As Integer
    Public Property DesnivelMaximo As Integer


    Public Sub New()

    End Sub
    Public Sub New(id As String, nombre As String, descripcion As String, kmsTotales As Integer, desnivelMax As Integer)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.KmsTotales = kmsTotales
        Me.DesnivelMaximo = desnivelMax
    End Sub



    Public Overloads Function Equals(other As Gr) As Boolean Implements IEquatable(Of Gr).Equals
        Return (Id.ToUpper.Equals(other.Id.ToUpper))
    End Function
End Class
