USE [Bd_Expedientes_Digitales]
GO
/****** Object:  View [dbo].[vw_ListaTramitesActivos]    Script Date: 01/22/2014 11:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_ListaTramitesActivos]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vw_ListaTramitesActivos]
AS
SELECT     TOP (100) PERCENT dbo.re_expedientes_tramites.id_expediente, dbo.ca_expedientes.Descripcion AS Descripcion_Expediente, 
                      dbo.ca_clasificaciontramites.id AS id_clasificaciontramite, dbo.ca_clasificaciontramites.Descripcion AS Descripcion_clasificaciontramite, 
                      dbo.ca_tramites.id AS id_tramite, dbo.ca_tramites.Nombre AS Nombre_tramite, dbo.ca_tramites.Descripcion AS Descripcion_tramite, 
                      dbo.ca_tramites.Descripcion_Breve AS Descripcion_Breve_tramite, dbo.ca_tramites.Alcance_Inicial AS Alcance_Inicial_tramite, 
                      dbo.ca_tramites.Alcance_Final AS Alcance_Final_tramite, dbo.ca_tramites.id_estatus AS id_estatus_tramite, 
                      dbo.ca_estatus.Descripcion AS Descripcion_estatus_tramite, dbo.re_expedientes_tramites.id AS id_re_expedientes_tramites, 
                      dbo.re_expedientestramites_tiposbloqueos.id_tipobloqueo, dbo.ca_tiposbloqueos.Descripcion AS descripcion_bloqueo, 
                      dbo.re_expedientestramites_tiposbloqueos.no_horas AS no_horas_bloqueo, dbo.re_expedientestramites_tiposbloqueos.no_dias AS no_dias_bloqueo
FROM         dbo.ca_tiposbloqueos INNER JOIN
                      dbo.re_expedientestramites_tiposbloqueos ON dbo.ca_tiposbloqueos.id = dbo.re_expedientestramites_tiposbloqueos.id_tipobloqueo RIGHT OUTER JOIN
                      dbo.ca_clasificaciontramites INNER JOIN
                      dbo.ca_tramites ON dbo.ca_clasificaciontramites.id = dbo.ca_tramites.id_ClasificacionTramite INNER JOIN
                      dbo.ca_estatus ON dbo.ca_tramites.id_estatus = dbo.ca_estatus.id INNER JOIN
                      dbo.re_expedientes_tramites ON dbo.ca_tramites.id = dbo.re_expedientes_tramites.id_tramite INNER JOIN
                      dbo.ca_expedientes ON dbo.re_expedientes_tramites.id_expediente = dbo.ca_expedientes.id ON 
                      dbo.re_expedientestramites_tiposbloqueos.id_re_expediente_tramite = dbo.re_expedientes_tramites.id
WHERE     (dbo.ca_tramites.id_estatus = 1)
ORDER BY dbo.ca_tramites.id_ClasificacionTramite, id_tramite
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vw_ListaTramitesActivos', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[34] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ca_clasificaciontramites"
            Begin Extent = 
               Top = 183
               Left = 284
               Bottom = 324
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_tramites"
            Begin Extent = 
               Top = 167
               Left = 513
               Bottom = 406
               Right = 711
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_expedientes"
            Begin Extent = 
               Top = 88
               Left = 39
               Bottom = 207
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "re_expedientestramites_tiposbloqueos"
            Begin Extent = 
               Top = 11
               Left = 558
               Bottom = 161
               Right = 771
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_tiposbloqueos"
            Begin Extent = 
               Top = 41
               Left = 857
               Bottom = 130
               Right = 1055
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ca_estatus"
            Begin Extent = 
               Top = 172
               Left = 741
               Bottom = 291
               Right = 939
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "re_expedientes_tramites"
            Begin Extent = 
               Top = 27
               Left = 285
               Bo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vw_ListaTramitesActivos', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ttom = 169
               Right = 483
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 2730
         Width = 1950
         Width = 2445
         Width = 1500
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3840
         Alias = 2640
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vw_ListaTramitesActivos', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaTramitesActivos'
GO
/****** Object:  View [dbo].[vw_ListaExpedientes]    Script Date: 01/22/2014 11:07:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_ListaExpedientes]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vw_ListaExpedientes]
AS
SELECT     id, Descripcion
FROM         dbo.ca_expedientes
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vw_ListaExpedientes', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ca_expedientes"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 95
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaExpedientes'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vw_ListaExpedientes', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_ListaExpedientes'
GO
