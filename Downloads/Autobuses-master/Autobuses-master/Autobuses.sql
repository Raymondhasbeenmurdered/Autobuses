-- Creación de la BDD --

GO
CREATE DATABASE Autobuses;

GO
USE Autobuses;

-- Ajustes de fecha: Se introduce asi '15-11-1999' --

SET DATEFORMAT DMY;

-- Creación de las tablas --

CREATE TABLE Usuarios(
ID_Usuario INT IDENTITY PRIMARY KEY,
Cod_Usuario AS ('U-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Usuario), (3))),
Nombre NVARCHAR(25),
Contraseña NVARCHAR(25),
Rol NVARCHAR(25)
)

CREATE TABLE Ciudades(
ID_Ciudad INT IDENTITY PRIMARY KEY,
Cod_Ciudad AS ('C-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Ciudad), (3))),
Nombre NVARCHAR(30),
Region NVARCHAR(30),
);

CREATE TABLE Paradas(
ID_Parada INT PRIMARY KEY IDENTITY (1,1),
Cod_Parada AS ('P-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Parada), (3))),
ID_Ciudad INT,
Nombre NVARCHAR(40),
Direccion NVARCHAR(100),

CONSTRAINT FK_Ciudad_PARADAS FOREIGN KEY (ID_Ciudad) REFERENCES Ciudades(ID_Ciudad)
);

CREATE TABLE Sucursales(
ID_Sucursal INT PRIMARY KEY IDENTITY (1,1),
Cod_Sucursal AS ('S-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Sucursal), (3))),
ID_Ciudad INT,
Direccion NVARCHAR(100)

CONSTRAINT FK_Ciudad_SUCURSALES FOREIGN KEY (ID_Ciudad) REFERENCES Ciudades(ID_Ciudad)
);

CREATE TABLE Conductores(
ID_Conductor INT PRIMARY KEY IDENTITY (1,1),
Cod_Conductor AS ('CO-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Conductor), (3))),
Cedula NVARCHAR(20),
Nombre NVARCHAR(50),
Apellidos NVARCHAR(50),
Telefono NVARCHAR(50),
F_Nacimiento DATE,
Direccion NVARCHAR(100),
Sexo CHAR(1),
Sueldo FLOAT
);

CREATE TABLE Asistentes(
ID_Asistente INT PRIMARY KEY IDENTITY (1,1),
Cod_Asistente AS ('A-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Asistente), (3))),
Cedula NVARCHAR(20),
Nombre NVARCHAR(50),
Apellidos NVARCHAR(50),
Telefono NVARCHAR(50),
F_Nacimiento DATE,
Direccion NVARCHAR(100),
Sexo CHAR(1),
Sueldo FLOAT
);

CREATE TABLE Paradas_Intermedias(
ID_ParadaINTER INT PRIMARY KEY IDENTITY (1,1),
Cod_ParadasINTER AS ('PI-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_ParadaINTER), (3))),
Nombre NVARCHAR(50),
Direccion NVARCHAR(100),
Tipo NVARCHAR(20),
);

CREATE TABLE Autobuses(
ID_Autobus INT IDENTITY PRIMARY KEY,
Cod_Autobus AS ('AU-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Autobus), (3))),
Matricula NVARCHAR(18),
ID_Conductor INT,
ID_Asistente INT,
Marca NVARCHAR(25),
Modelo NVARCHAR(25),

CONSTRAINT FK_Conductor_AUTOBUSES FOREIGN KEY (ID_Conductor) REFERENCES Conductores(ID_Conductor),
CONSTRAINT FK_Asistente_AUTOBUSES FOREIGN KEY (ID_Asistente) REFERENCES Asistentes(ID_Asistente)
);

CREATE TABLE Rutas(
ID_Ruta INT PRIMARY KEY IDENTITY,
Cod_Rutas AS ('R-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Ruta), (3))),
Nombre NVARCHAR(75),
Partida NVARCHAR(75),
Destino NVARCHAR(75),
ID_ParadaINTER INT,
ID_Ciudad INT,
ID_Autobus INT,

CONSTRAINT FK_ParadaINTER_Ruta FOREIGN KEY (ID_ParadaINTER) REFERENCES Paradas_Intermedias(ID_ParadaINTER),
CONSTRAINT FK_Ciudad_Ruta FOREIGN KEY (ID_Ciudad) REFERENCES Ciudades(ID_Ciudad),
CONSTRAINT FK_Autobus_Ruta FOREIGN KEY (ID_Autobus) REFERENCES Autobuses(ID_Autobus)
);

CREATE TABLE Boletos(
ID_Boletos INT IDENTITY PRIMARY KEY,
Cod_Boletos AS ('B-' + RIGHT ('00' + CONVERT(NVARCHAR, ID_Boletos), (3))),
ID_Ruta INT,
Precio FLOAT,
Fecha AS CONVERT(date, GETDATE()),
Hora AS CONVERT(time, GETDATE()),

CONSTRAINT FK_Ruta_Boletos FOREIGN KEY (ID_Ruta) REFERENCES Rutas(ID_Ruta)
);

-- Procedimientos Almacenados: Usuarios --

GO
CREATE PROC SP_BUSCAR_USUARIOS
@BUSCAR NVARCHAR(20)
AS
SELECT *
FROM Usuarios
WHERE Cod_Usuario Like '%' + @BUSCAR + '%'
   OR ID_Usuario Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Contraseña  Like '%' + @BUSCAR + '%'
   OR Rol Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_USUARIOS
@Nombre NVARCHAR(25),
@Contraseña NVARCHAR(25),
@Rol NVARCHAR(25)
AS
INSERT INTO Usuarios VALUES (@Nombre, @Contraseña, @Rol)

GO
CREATE PROC SP_EDITAR_USUARIOS
@Cod_Usuario NVARCHAR(22),
@Nombre NVARCHAR(25),
@Contraseña NVARCHAR(25),
@Rol NVARCHAR(25)
AS
UPDATE Usuarios SET Nombre = @Nombre, Contraseña = @Contraseña, Rol = @Rol
WHERE Cod_Usuario = @Cod_Usuario;

GO
CREATE PROC SP_ELIMINAR_USUARIO
@Cod_Usuario NVARCHAR(22)
AS
DELETE FROM Usuarios
WHERE Cod_Usuario = @Cod_Usuario;

-- Procedimientos Almacenados: Paradas --

GO
CREATE PROC SP_BUSCAR_PARADAS 
@BUSCAR NVARCHAR(20) 
AS 
SELECT *
FROM Paradas 
WHERE Cod_Parada Like '%' + @BUSCAR + '%'
   OR ID_Ciudad Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Direccion Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_PARADAS 
@ID_Ciudad INT,
@Nombre NVARCHAR(40),
@Direccion NVARCHAR(100)
AS
INSERT INTO Paradas
VALUES (@ID_Ciudad, @Nombre, @Direccion);

GO
CREATE PROC SP_EDITAR_PARADAS
@Cod_Parada NVARCHAR(22),
@ID_Ciudad INT,
@Nombre NVARCHAR(40),
@Direccion NVARCHAR(100) 
AS
UPDATE Paradas
SET ID_Ciudad = @ID_Ciudad, Nombre = @Nombre, Direccion = @Direccion
WHERE Cod_Parada = @Cod_Parada;

GO
CREATE PROC SP_ELIMINAR_PARADAS 
@Cod_Parada NVARCHAR(22)
AS
DELETE FROM Paradas 
WHERE Cod_Parada = @Cod_Parada;

-- Procedimientos Almacenados: Sucursales --

GO
CREATE PROC SP_BUSCAR_SUCURSALES
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Sucursales 
WHERE Cod_Sucursal Like '%' +  @BUSCAR + '%'
   OR ID_Ciudad Like '%' + @BUSCAR + '%'
   OR Direccion Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_SUCURSALES 
@ID_Ciudad INT,
@Direccion NVARCHAR(100)
AS
INSERT INTO Sucursales
VALUES (@ID_Ciudad, @Direccion);

GO
CREATE PROC SP_EDITAR_SUCURSALES
@Cod_Sucursal NVARCHAR(22),
@ID_Ciudad INT,
@Direccion NVARCHAR(100) 
AS
UPDATE Sucursales
SET ID_Ciudad = @ID_Ciudad, Direccion = @Direccion 
WHERE Cod_Sucursal = @Cod_Sucursal;

GO
CREATE PROC SP_ELIMINAR_SUCURSALES 
@Cod_Sucursal NVARCHAR(22)
AS
DELETE FROM Sucursales 
WHERE Cod_Sucursal = @Cod_Sucursal;

-- Procedimientos Almacenados: Conductores --

GO
CREATE PROC SP_BUSCAR_CONDUCTORES
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Conductores 
WHERE Cod_Conductor Like '%' + @BUSCAR + '%'
   OR Cedula Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Apellidos Like '%' + @BUSCAR + '%'
   OR Telefono Like '%' + @BUSCAR + '%'
   OR F_Nacimiento Like '%' + @BUSCAR + '%'
   OR Direccion Like '%' + @BUSCAR + '%'
   OR Sexo Like '%' + @BUSCAR + '%'
   OR Sueldo Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_CONDUCTORES 
@Cedula NVARCHAR(22),
@Nombre NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Telefono NVARCHAR(50),
@Nac DATE,
@Direccion NVARCHAR(100),
@Sexo CHAR(1),
@Sueldo FLOAT
AS
INSERT INTO Conductores
VALUES (@Cedula, @Nombre, @Apellidos, @Telefono, @Nac, @Direccion, @Sexo, @Sueldo);

GO
CREATE PROC SP_EDITAR_CONDUCTORES
@Cod_Conductor NVARCHAR(22),
@Cedula NVARCHAR(22),
@Nombre NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Telefono NVARCHAR(50),
@Nac DATE,
@Direccion NVARCHAR(100),
@Sexo CHAR(1),
@Sueldo FLOAT
AS
UPDATE Conductores
SET Cedula = @Cedula, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, F_Nacimiento = @Nac, Direccion = @Direccion, Sexo = @Sexo, Sueldo = @Sueldo
WHERE Cod_Conductor = @Cod_Conductor;

GO
CREATE PROC SP_ELIMINAR_CONDUCTORES 
@Cod_Conductor NVARCHAR(22)
AS
DELETE FROM Conductores 
WHERE Cod_Conductor = @Cod_Conductor;

-- Procedimientos Almacenados: Asistentes --

GO
CREATE PROC SP_BUSCAR_ASISTENTES
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Asistentes 
WHERE Cod_Asistente Like '%' + @BUSCAR + '%'
   OR Cedula Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Apellidos Like '%' + @BUSCAR + '%'
   OR Telefono Like '%' + @BUSCAR + '%'
   OR F_Nacimiento Like '%' + @BUSCAR + '%'
   OR Direccion Like '%' + @BUSCAR + '%'
   OR Sexo Like '%' + @BUSCAR + '%'
   OR Sueldo Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_ASISTENTES 
@Cedula NVARCHAR(22),
@Nombre NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Telefono NVARCHAR(50),
@Nac DATE,
@Direccion NVARCHAR(100),
@Sexo CHAR(1),
@Sueldo FLOAT
AS
INSERT INTO Asistentes
VALUES (@Cedula, @Nombre, @Apellidos, @Telefono, @Nac, @Direccion, @Sexo, @Sueldo);

GO
CREATE PROC SP_EDITAR_ASISTENTES
@Cod_Asistente NVARCHAR(22),
@Cedula NVARCHAR(22),
@Nombre NVARCHAR(50),
@Apellidos NVARCHAR(50),
@Telefono NVARCHAR(50),
@Nac DATE,
@Direccion NVARCHAR(100),
@Sexo CHAR(1),
@Sueldo FLOAT
AS
UPDATE Asistentes
SET Cedula = @Cedula, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, F_Nacimiento = @Nac, Direccion = @Direccion, Sexo = @Sexo, Sueldo = @Sueldo
WHERE Cod_Asistente = @Cod_Asistente;

GO
CREATE PROC SP_ELIMINAR_ASISTENTES 
@Cod_Asistente NVARCHAR(22)
AS
DELETE FROM Asistentes 
WHERE Cod_Asistente = @Cod_Asistente;

-- Procedimientos Almacenados: Paradas intermedias --

GO
CREATE PROC SP_BUSCAR_PARADASINTER 
@BUSCAR NVARCHAR(20) 
AS 
SELECT *
FROM Paradas_Intermedias 
WHERE Cod_ParadasINTER Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Direccion Like '%' + @BUSCAR + '%'
   OR Tipo Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_PARADASINTER
@Nombre NVARCHAR(22),
@Direccion NVARCHAR(100),
@Tipo NVARCHAR(22)
AS
INSERT INTO Paradas_Intermedias
VALUES (@Nombre, @Direccion, @Tipo);

GO
CREATE PROC SP_EDITAR_PARADASINTER
@Cod_ParadasINTER NVARCHAR(22),
@Nombre NVARCHAR(40),
@Direccion NVARCHAR(100), 
@Tipo NVARCHAR (22)
AS
UPDATE Paradas_Intermedias
SET Nombre = @Nombre, Direccion = @Direccion, Tipo = @Tipo 
WHERE Cod_ParadasINTER = @Cod_ParadasINTER;

GO
CREATE PROC SP_ELIMINAR_PARADASINTER
@Cod_ParadasINTER NVARCHAR(22)
AS
DELETE FROM Paradas_Intermedias
WHERE Cod_ParadasINTER = @Cod_ParadasINTER;

-- Procedimientos Almacenados: Autobuses --

GO
CREATE PROC SP_BUSCAR_AUTOBUSES
@BUSCAR NVARCHAR(20)
AS 
SELECT * 
FROM Autobuses
WHERE Cod_Autobus Like '%' + @BUSCAR + '%'
   OR Matricula Like '%' + @BUSCAR + '%'
   OR ID_Conductor Like '%' + @BUSCAR + '%'
   OR ID_Asistente Like '%' + @BUSCAR + '%'
   OR Marca Like '%' + @BUSCAR + '%'
   OR Modelo Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_AUTOBUSES 
@Matricula NVARCHAR(22),
@ID_Conductor INT,
@ID_Asistente INT,
@Marca NVARCHAR(22),
@Modelo NVARCHAR(22)
AS
INSERT INTO Autobuses
VALUES (@Matricula, @ID_Conductor, @ID_Asistente, @Marca, @Modelo);

GO
CREATE PROC SP_EDITAR_AUTOBUSES
@Cod_Autobus NVARCHAR(22),
@Matricula NVARCHAR(22),
@ID_Conductor INT,
@ID_Asistente INT,
@Marca NVARCHAR(22),
@Modelo NVARCHAR(22)
AS
UPDATE Autobuses 
SET Matricula = @Matricula, ID_Conductor = @ID_Conductor, ID_Asistente = @ID_Asistente, Marca = @Marca, Modelo = @Modelo
WHERE Cod_Autobus = @Cod_Autobus;

GO
CREATE PROC SP_ELIMINAR_AUTOBUSES 
@Cod_Autobus NVARCHAR(22) 
AS
DELETE FROM Autobuses 
WHERE Cod_Autobus = @Cod_Autobus;

-- Procedimientos Almacenados: Ciudades --

GO
CREATE PROC SP_BUSCAR_CIUDADES
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Ciudades 
WHERE Cod_Ciudad Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Region Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_CIUDADES
@Nombre NVARCHAR(30),
@Region NVARCHAR(30)
AS
INSERT INTO Ciudades 
VALUES (@Nombre, @Region);

GO
CREATE PROC SP_EDITAR_CIUDADES
@Cod_Ciudad NVARCHAR(22),
@Nombre NVARCHAR(30),
@Region NVARCHAR(30)
AS 
UPDATE Ciudades SET Nombre = @Nombre, Region = @Region
WHERE Cod_Ciudad = @Cod_Ciudad;

GO
CREATE PROC SP_ELIMINAR_CIUDADES 
@Cod_Ciudad NVARCHAR(22)
AS 
DELETE FROM Ciudades 
WHERE Cod_Ciudad = @Cod_Ciudad;

-- Procedimientos Almacenados: Ruta --

GO
CREATE PROC SP_BUSCAR_RUTAS 
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Rutas 
WHERE Cod_Rutas Like '%' + @BUSCAR + '%'
   OR Nombre Like '%' + @BUSCAR + '%'
   OR Partida Like '%' + @BUSCAR + '%'
   OR Destino Like '%' + @BUSCAR + '%'
   OR ID_ParadaINTER Like '%' + @BUSCAR + '%'
   OR ID_Ciudad Like '%' + @BUSCAR + '%'
   OR ID_Autobus Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_RUTAS
@Nombre NVARCHAR(75),
@Partida NVARCHAR(75),
@Destino NVARCHAR(75),
@ID_ParadaINTER INT,
@ID_Ciudad INT,
@ID_Autobus INT
AS
INSERT INTO Rutas 
VALUES (@Nombre, @Partida, @Destino, @ID_ParadaINTER, @ID_Ciudad, @ID_Autobus);

GO
CREATE PROC SP_EDITAR_RUTAS
@Cod_Ruta NVARCHAR(22),
@Nombre NVARCHAR(75),
@Partida NVARCHAR(75),
@Destino NVARCHAR(75),
@ID_ParadaINTER INT,
@ID_Ciudad INT,
@ID_Autobus INT 
AS
UPDATE Rutas SET Nombre = @Nombre, Partida = @Partida, Destino = @Destino, ID_ParadaINTER = @ID_ParadaINTER, ID_Ciudad = @ID_Ciudad, ID_Autobus = @ID_Autobus 
WHERE Cod_Rutas = @Cod_Ruta;

GO
CREATE PROC SP_ELIMINAR_RUTAS 
@Cod_Rutas NVARCHAR(22)
AS
DELETE FROM Rutas 
WHERE Cod_Rutas = @Cod_Rutas;

--Procedimientos Almacenados: Boletos --

GO
CREATE PROC SP_BUSCAR_BOLETOS
@BUSCAR NVARCHAR(20)
AS
SELECT * 
FROM Boletos 
WHERE Cod_Boletos Like '%' + @BUSCAR + '%'
   OR ID_Ruta Like '%' + @BUSCAR + '%'
   OR Precio Like '%' + @BUSCAR + '%'
   OR Fecha Like '%' + @BUSCAR + '%'
   OR Hora Like '%' + @BUSCAR + '%';

GO
CREATE PROC SP_INSERTAR_BOLETOS
@ID_Ruta INT,
@Precio FLOAT
AS
INSERT INTO Boletos (ID_Ruta, Precio)
VALUES (@ID_Ruta, @Precio);

GO
CREATE PROC SP_EDITAR_BOLETOS
@Cod_Boletos NVARCHAR(22),
@Precio FLOAT,
@ID_Ruta INT
AS
UPDATE Boletos SET Precio = @Precio, ID_Ruta = @ID_Ruta
WHERE Cod_Boletos = @Cod_Boletos;

GO
CREATE PROC SP_ELIMINAR_BOLETOS 
@Cod_Boletos NVARCHAR(22) 
AS
DELETE FROM Boletos 
WHERE Cod_Boletos = @Cod_Boletos;

-- Inserción de datos --

/*INSERT INTO ... 
VALUES();

-- Actualización de datos --

UPDATE ...
SET ...
WHERE ... = ...;

-- Eliminación de datos --

DELETE FROM ...
WHERE ... = ...;*/

-- Inserción de datos --

GO
INSERT INTO Usuarios Values ('Admin', '1234', 'Admin');
INSERT INTO Asistentes VALUES ('402-2939372-9', 'Bryan', 'Moreno', '829-842-0568', '19-03-2005', 'C/Las Palmas Edif. HLC III', 'M', 120000);
INSERT INTO Conductores VALUES ('001-9856478-1', 'Aidan', 'Pereira', '849-656-5163', '14-06-2005', 'C/Charles de Gaulle Torre X', 'M', 50000);
INSERT INTO Autobuses VALUES ('RD98452', 1, 1, 'Toyota', 'Camry');
INSERT INTO Sucursales VALUES (1, 'Prados del Cachon, casi Charles');
INSERT INTO Paradas_Intermedias VALUES ('Jacaranda', 'Av. Las Americas', 'Parador');
INSERT INTO Paradas VALUES (1, 'Prados del Cachon', 'Cancino');
INSERT INTO Ciudades VALUES ('Santiago', 'Norte');
INSERT INTO Rutas VALUES ('Ruta 8', 'Santiago', 'Cancino', 1, 1, 1);
INSERT INTO Boletos VALUES (1, 650);

GO
INSERT INTO Asistentes VALUES ('987-5959472-1', 'Dariel', 'Jerez', '809-984-7845', '27-09-2005', 'C/37 Villa Carmen', 'M', 100000);
INSERT INTO Conductores VALUES ('003-4844894-1', 'Jean', 'Peguero', '849-987-4478', '22-04-2006', 'C/Felipito 42', 'M', 30000);
INSERT INTO Autobuses VALUES ('RD45789', 2, 2, 'Hyundai', 'Sonata');
INSERT INTO Ciudades VALUES ('La Altagracia', 'Este');
INSERT INTO Sucursales VALUES (2, 'Frente a La Basílica Catedral');
INSERT INTO Paradas VALUES (2, 'La Basílica', 'En mi casa');
INSERT INTO Paradas_Intermedias VALUES ('El Paradito', 'Av. Pepe Reina #65', 'Comedor');
INSERT INTO Rutas VALUES ('Ruta 10', 'La Altagracia', 'En mi casa', 2, 2, 2);
INSERT INTO Boletos VALUES (2, 250);

-- Consultas varias --

/*SELECT * FROM Usuarios;
SELECT * FROM Paradas;
SELECT * FROM Sucursales;
SELECT * FROM Conductores;
SELECT * FROM Asistentes;
SELECT * FROM Ciudades;
SELECT * FROM Autobuses;
SELECT * FROM Paradas_Intermedias;
SELECT * FROM Rutas;
SELECT * FROM Boletos;

-- Reiniciar IDENTITY --

DBCC CHECKIDENT ('[dbo].[Sucursales]', RESEED, 0);

DELETE FROM Sucursales WHERE ID_Sucursal = 2;*/
