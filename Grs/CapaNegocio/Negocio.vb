Imports CapaDatos
Imports Entidades

Public Class Negocio

    Private _datos As New Datos

    Public Function DevolverGrs() As List(Of Gr)

        Return _datos.Grs
    End Function
    Public Function AlberguesPorZona(idZona As String) As List(Of Albergue)

        Return _datos.AlberguesPorZona(idZona)
    End Function

    Public Function EtapasPorGr(idGr As String) As List(Of Etapa)
        Return _datos.EtapasPorGr(idGr)
    End Function

End Class