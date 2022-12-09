CREATE TABLE conductores(
id_conductor int IDENTITY(1,1) PRIMARY KEY,
nombres varchar(30) NOT NULL,
apellidos varchar(30) NOT NULL, 
fechanacimiento Date NOT NULL,
añoexp int ,
)


