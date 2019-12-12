USE [TarsiusWhite]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 11/12/2019 11:55:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]

GO

