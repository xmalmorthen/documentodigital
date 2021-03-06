USE [Bd_Expedientes_Web]
GO
/****** Object:  Table [dbo].[ca_nodos]    Script Date: 27/10/2015 02:29:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_nodos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nodo] [varchar](200) NOT NULL,
	[url_servicio_rest] [varchar](8000) NOT NULL,
	[usuario] [varchar](100) NULL,
	[contrasenia] [varchar](100) NULL,
	[activo] [bit] NOT NULL CONSTRAINT [DF_ca_nodos_activo]  DEFAULT ((1)),
	[fecha_registro] [datetime] NOT NULL CONSTRAINT [DF_ca_nodos_fecha_registro]  DEFAULT (getdate()),
 CONSTRAINT [PK_dbo.ca_nodos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ca_usuarios]    Script Date: 27/10/2015 02:29:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ca_usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[curp] [varchar](18) NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellido1] [varchar](50) NOT NULL,
	[apellido2] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[cargo] [varchar](200) NULL,
	[activo] [bit] NOT NULL CONSTRAINT [DF_ca_usuarios_activo]  DEFAULT ((1)),
	[f_registro] [datetime] NOT NULL CONSTRAINT [DF_ca_usuarios_f_registro]  DEFAULT (getdate()),
	[es_administrador] [bit] NOT NULL CONSTRAINT [DF_ca_usuarios_es_administrador]  DEFAULT ((0)),
	[tocken] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.ca_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[re_nodos_usuarios]    Script Date: 27/10/2015 02:29:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[re_nodos_usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_nodo] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[activo] [bit] NOT NULL CONSTRAINT [DF_re_nodos_usuarios_activo]  DEFAULT ((1)),
	[f_registro] [datetime] NOT NULL CONSTRAINT [DF_re_nodos_usuarios_f_registro]  DEFAULT (getdate()),
 CONSTRAINT [PK_dbo.re_nodos_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[re_nodos_usuarios]  WITH CHECK ADD  CONSTRAINT [ca_nodos_re_nodos_usuarios] FOREIGN KEY([id_nodo])
REFERENCES [dbo].[ca_nodos] ([id])
GO
ALTER TABLE [dbo].[re_nodos_usuarios] CHECK CONSTRAINT [ca_nodos_re_nodos_usuarios]
GO
ALTER TABLE [dbo].[re_nodos_usuarios]  WITH CHECK ADD  CONSTRAINT [ca_usuarios_re_nodos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[ca_usuarios] ([id])
GO
ALTER TABLE [dbo].[re_nodos_usuarios] CHECK CONSTRAINT [ca_usuarios_re_nodos_usuarios]
GO
