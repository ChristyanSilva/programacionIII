CREATE TABLE vehiculo(
id_vehiculo int IDENTITY(1,1) PRIMARY KEY,
marca varchar(30),
placa varchar(30) NOT NULL, 
aniosdeUso int,
tipoGasolina varchar(20),
kilometraje float,
estadodelVehiculo varchar(20),
conductorAsignado int ,
CONSTRAINT vehiculos FOREIGN KEY(conductorAsignado) REFERENCES conductores(id_conductor)
);