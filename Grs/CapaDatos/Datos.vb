Imports Entidades
Public Class Datos

    Private dsGrs As DSGrs
    Public Sub New()
        CrearDataSetCompleto()
    End Sub
    Private Sub CrearDataSetCompleto()
        dsGrs = New DSGrs

        Dim daGrs As New DSGrsTableAdapters.GrsTableAdapter
        ' Adaptador para poder traer la table gr a la memoria de visual
        daGrs.Fill(dsGrs.Grs)
        ' El metodo fill llena mediante el adaptador la tabla etapa.
        Dim daEtapas As New DSGrsTableAdapters.EtapasTableAdapter
        daEtapas.Fill(dsGrs.Etapas)
        ' Hacemos los mismo para la tabla zonas.
        Dim daZonas As New DSGrsTableAdapters.ZonasTableAdapter
        daZonas.Fill(dsGrs.Zonas)
        'Lo mismo con albergue
        Dim daAlbergue As New DSGrsTableAdapters.AlberguesTableAdapter
        daAlbergue.Fill(dsGrs.Albergues)

        Dim daOcupacion As New DSGrsTableAdapters.OcupacionesTableAdapter
        daOcupacion.Fill(dsGrs.Ocupaciones)
    End Sub

    Public Function Grs() As List(Of Gr)
        Dim grandesRecorridos = From drg In dsGrs.Grs
                                Order By drg.Id Ascending
                                Select New Gr(drg.Id, drg.Nombre,
                                    drg.Descripcion,
                                    (Aggregate km In dsGrs.Etapas Where km.Gr = drg.Id Into Sum(km.Km)),
                                    (Aggregate des In dsGrs.Etapas Where des.Gr = drg.Id Into Max(des.Desnivel)))

        Return grandesRecorridos.ToList

    End Function


    Public Function AlberguesPorZona(idZona As String) As List(Of Albergue)
        Dim albergues = From dra In dsGrs.Albergues
                        Where dra.IdZona = idZona
                        Order By dra.Nombre Ascending
                        Select New Albergue(dra.Id, dra.IdZona, dra.Nombre, dra.TotalPlazas, dra.Precio,
                            ((From drz In dsGrs.Zonas Where drz.Id = idZona Select drz.Nombre).SingleOrDefault),
                            (Aggregate dro In dsGrs.Ocupaciones Where dro.IdAlbergue = dra.Id Into Count()))

        Return albergues.ToList
    End Function

    Public Function EtapasPorGr(idGr As String) As List(Of Etapa)
        Dim etapas = From dre In dsGrs.Etapas
                     Join drz In dsGrs.Zonas
                         On dre.IdZona Equals drz.Id
                     Where dre.Gr = idGr
                     Select New Etapa(dre.NumEtapa, dre.Gr, drz.Id, dre.Km, dre.Desnivel)

        Return etapas.ToList
    End Function

End Class
