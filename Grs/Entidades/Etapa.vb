Imports Entidades

Public Class Etapa : Implements IEquatable(Of Etapa)

    Public Property NumEtapa As Integer
    Public Property Gr As String
    Public Property IdZona As String
    Public Property Kms As Integer
    Public Property Desnivel As Integer

    Public Sub New()

    End Sub

    Public Sub New(numEtapa As Integer, gr As String, idZona As String, kms As Integer, desnivel As Integer)
        Me.NumEtapa = numEtapa
        Me.Gr = gr
        Me.IdZona = idZona
        Me.Kms = kms
        Me.Desnivel = desnivel
    End Sub

    Public Function Equals(other As Etapa) As Boolean Implements IEquatable(Of Etapa).Equals
        Return (Gr.ToUpper.Equals(other.Gr.ToUpper) AndAlso (NumEtapa.Equals(other.NumEtapa)))
    End Function
End Class
