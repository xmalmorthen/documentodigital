USE [Bd_Expedientes_Digitales]
GO
/****** Object:  Table [dbo].[ca_acciones]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_CA_ACCIONES_INSERT ON ca_acciones;
GO
SET IDENTITY_INSERT [dbo].[ca_acciones] ON
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (1, N'Alta')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (2, N'Baja')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (4, N'Consulta')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (3, N'Modificaciòn')
INSERT [dbo].[ca_acciones] ([id], [Descripcion]) VALUES (5, N'Reporte')
SET IDENTITY_INSERT [dbo].[ca_acciones] OFF
GO
ENABLE TRIGGER TR_CA_ACCIONES_INSERT ON ca_acciones;

/****** Object:  Table [dbo].[ca_origenes]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_origenes_INSERT ON ca_origenes;
GO
SET IDENTITY_INSERT [dbo].[ca_origenes] ON
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (2, N'Externo')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (1, N'Interno')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (4, N'Proveedor')
INSERT [dbo].[ca_origenes] ([id], [Descripcion]) VALUES (3, N'Usuario')
SET IDENTITY_INSERT [dbo].[ca_origenes] OFF
GO
ENABLE TRIGGER TR_ca_origenes_INSERT ON ca_origenes;

/****** Object:  Table [dbo].[ca_modulos]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_modulos_INSERT ON ca_modulos;
GO
SET IDENTITY_INSERT [dbo].[ca_modulos] ON
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (1, N'Registro y seguimiento', 2, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (2, N'Deshacer registro', 2, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (3, N'Blquear/Desbloquear', 2, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (4, N'Roles', 3, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (5, N'Usuarios', 3, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (6, N'Preferencias', 3, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (7, N'Expedientes', 1, 1)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (8, N'Campos trazables', 1, 2)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (9, N'Clasificación de trámites', 1, 4)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (10, N'Trámites', 1, 5)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (11, N'Clasificación de documentos', 1, 6)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (12, N'Documentos', 1, 7)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (13, N'Asignar campos trazables a un expediente', 1, 3)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (14, N'Clasificar documentos', 1, 8)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (15, N'Asignar clasificación de documentos a un trámite', 1, 9)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (16, N'Cargo/Puesto', 3, 4)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (17, N'Típo de formatos para documentos', 1, 10)
INSERT [dbo].[ca_modulos] ([id], [Modulo], [id_menu], [id_submenu]) VALUES (18, N'Asignar Trámites a Expedientes', 1, 11)
SET IDENTITY_INSERT [dbo].[ca_modulos] OFF
GO
ENABLE TRIGGER TR_ca_modulos_INSERT ON ca_modulos;

/****** Object:  Table [dbo].[ca_roles]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_roles_INSERT ON ca_roles;
GO
SET IDENTITY_INSERT [dbo].[ca_roles] ON
INSERT [dbo].[ca_roles] ([id], [Descripcion]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[ca_roles] OFF
GO
ENABLE TRIGGER TR_ca_roles_INSERT ON ca_roles;

/****** Object:  Table [dbo].[ca_estatus]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_estatus_INSERT ON ca_estatus;
GO
SET IDENTITY_INSERT [dbo].[ca_estatus] ON
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (1, N'Activo')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (4, N'Bloqueado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (5, N'Desbloqueado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (9, N'Desechado')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (2, N'Inactivo')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (7, N'Invisible')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (3, N'Suspendido')
INSERT [dbo].[ca_estatus] ([id], [Descripcion]) VALUES (6, N'Visible')
SET IDENTITY_INSERT [dbo].[ca_estatus] OFF
GO
ENABLE TRIGGER TR_ca_estatus_INSERT ON ca_estatus;

/****** Object:  Table [dbo].[ca_tiposbloqueos]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_tiposbloqueos_INSERT ON ca_tiposbloqueos;
GO
SET IDENTITY_INSERT [dbo].[ca_tiposbloqueos] ON
INSERT [dbo].[ca_tiposbloqueos] ([id], [Descripcion]) VALUES (2, N'Bloquear despues de determinado tiempo')
INSERT [dbo].[ca_tiposbloqueos] ([id], [Descripcion]) VALUES (3, N'Bloquear manualmente')
SET IDENTITY_INSERT [dbo].[ca_tiposbloqueos] OFF
GO
ENABLE TRIGGER TR_ca_tiposbloqueos_INSERT ON ca_tiposbloqueos;

/****** Object:  Table [dbo].[ca_tablas]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_tablas_INSERT ON ca_tablas;
GO
SET IDENTITY_INSERT [dbo].[ca_tablas] ON
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (2, N'ca_acciones', N'catálogo de acciones')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (3, N'ca_campostrazables', N'catálogo de campos trazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (4, N'ca_clasificaciondocumentos', N'ca_clasificaciondocumentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (5, N'ca_clasificaciontramites', N'ca_clasificaciontramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (6, N'ca_documentos', N'ca_documentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (7, N'ca_estatus', N'ca_estatus')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (8, N'ca_expedientes', N'ca_expedientes')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (9, N'ca_formatos', N'ca_formatos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (10, N'ca_modulos', N'ca_modulos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (11, N'ca_origenes', N'ca_origenes')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (12, N'ca_roles', N'ca_roles')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (13, N'ca_tablas', N'ca_tablas')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (14, N'ca_tiposbloqueos', N'ca_tiposbloqueos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (15, N'ca_tramites', N'ca_tramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (16, N'ca_usuarios', N'ca_usuarios')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (17, N'de_acciones_modulo', N'de_acciones_modulo')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (18, N'de_digital', N'de_digital')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (19, N'de_digital_campostrazables', N'de_digital_campostrazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (20, N'hco_cambios', N'hco_cambios')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (21, N'ma_digital', N'ma_digital')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (22, N're_clasificaciondocumentos_documentos', N're_clasificaciondocumentos_documentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (23, N're_expedientes_campostrazables', N're_expedientes_campostrazables')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (24, N're_expedientes_tramites', N're_expedientes_tramites')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (25, N're_expedientestramites_tiposbloqueos', N're_expedientestramites_tiposbloqueos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (26, N're_roles_modulos', N're_roles_modulos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (27, N're_tramites_clasificaciondocumentos', N're_tramites_clasificaciondocumentos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (28, N're_usuarios_roles_permisos', N're_usuarios_roles_permisos')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (29, N'tbl_configuraciones', N'tbl_configuraciones')
INSERT [dbo].[ca_tablas] ([id], [nombre], [descripcion]) VALUES (30, N'ca_cargo_puesto', N'ca_cargo_puesto')
SET IDENTITY_INSERT [dbo].[ca_tablas] OFF
GO
ENABLE TRIGGER TR_ca_tablas_INSERT ON ca_tablas;

/****** Object:  Table [dbo].[tbl_configuraciones]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_tbl_configuraciones_INSERT ON tbl_configuraciones;
GO
SET IDENTITY_INSERT [dbo].[tbl_configuraciones] ON
INSERT [dbo].[tbl_configuraciones] ([id], [Descripcion], [Valor]) VALUES (1, N'Tramite por default', N'1')
SET IDENTITY_INSERT [dbo].[tbl_configuraciones] OFF
GO
ENABLE TRIGGER TR_tbl_configuraciones_INSERT ON tbl_configuraciones;


/****** Object:  Table [dbo].[ca_cargo_puesto]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_cargo_puesto_INSERT ON ca_cargo_puesto;
GO
SET IDENTITY_INSERT [dbo].[ca_cargo_puesto] ON
INSERT [dbo].[ca_cargo_puesto] ([id], [Descripcion]) VALUES (1, N'Administrador del sistema')
SET IDENTITY_INSERT [dbo].[ca_cargo_puesto] OFF
GO
ENABLE TRIGGER TR_ca_cargo_puesto_INSERT ON ca_cargo_puesto;

/****** Object:  Table [dbo].[re_roles_modulos]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_re_roles_modulos_INSERT ON re_roles_modulos;
GO
SET IDENTITY_INSERT [dbo].[re_roles_modulos] ON
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (1, 1, 1)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (2, 1, 2)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (3, 1, 3)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (4, 1, 4)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (5, 1, 5)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (6, 1, 6)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (7, 1, 7)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (8, 1, 8)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (9, 1, 9)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (10, 1, 10)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (11, 1, 11)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (12, 1, 12)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (13, 1, 13)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (14, 1, 15)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (15, 1, 14)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (16, 1, 16)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (17, 1, 17)
INSERT [dbo].[re_roles_modulos] ([id], [id_rol], [id_modulo]) VALUES (18, 1, 18)
SET IDENTITY_INSERT [dbo].[re_roles_modulos] OFF
GO
ENABLE TRIGGER TR_re_roles_modulos_INSERT ON re_roles_modulos;

/****** Object:  Table [dbo].[ca_usuarios]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_ca_usuarios_INSERT ON ca_usuarios;
GO
SET IDENTITY_INSERT [dbo].[ca_usuarios] ON
INSERT [dbo].[ca_usuarios] ([id], [usuario], [contrasenia], [CURP], [Nombres], [Apellido1], [Apellido2], [Telefono], [id_cargo]) VALUES (1, N'admin', N'21232f297a57a5a743894a0e4a801fc3', NULL, N'Administrador', N'del Sistema', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[ca_usuarios] OFF
GO
ENABLE TRIGGER TR_ca_usuarios_INSERT ON ca_usuarios;

/****** Object:  Table [dbo].[re_usuarios_roles_permisos]    Script Date: 01/22/2014 11:47:26 ******/
DISABLE TRIGGER TR_re_usuarios_roles_permisos_INSERT ON re_usuarios_roles_permisos;
GO
SET IDENTITY_INSERT [dbo].[re_usuarios_roles_permisos] ON
INSERT [dbo].[re_usuarios_roles_permisos] ([id], [id_usuario], [id_rol]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[re_usuarios_roles_permisos] OFF
GO
DISABLE TRIGGER TR_re_usuarios_roles_permisos_INSERT ON re_usuarios_roles_permisos;