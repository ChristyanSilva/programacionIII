CREATE TABLE [dbo].[conductores] (
    [id_conductor]    INT          NOT NULL,
    [nombres]         VARCHAR (30) NOT NULL,
    [apellidos]       VARCHAR (30) NOT NULL,
    [fechanacimiento] DATE         NOT NULL,
    [anioexp]         INT          NULL,
    [nombreUsuario] VARCHAR(30) NOT NULL, 
    [contrasenia] VARCHAR(30) NOT NULL, 
    [direccion] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id_conductor] )
);

