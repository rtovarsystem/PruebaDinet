--Base de datos pruebaDinet
--tabla: dbo.Productos
--usuario: sa
--Password: artytech



USE [pruebaDinet]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 22/12/2024 19:34:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

create procedure [dbo].[sp_productos_insert](
@Nombre varchar(100),
@Precio decimal(18,2),
@FechaCreacion datetime)
as

begin

insert into Productos (Nombre,Precio, FechaCreacion) values (@Nombre,@Precio,@FechaCreacion)

end 

go

create procedure [dbo].[sp_productos_listar]

as

begin

select Id ,Nombre,Precio , FechaCreacion, format(FechaCreacion,'dd/MM/yyyy') vFechaCreacion from Productos 

end 

go