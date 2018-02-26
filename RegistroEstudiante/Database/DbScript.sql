create database EstudianteDb
go
use EstudianteDb;
go

CREATE TABLE Estudiantes(
	EstudianteId int primary key IDENTITY(1,1) NOT NULL,
	Nombres varchar(40) NULL,
	Apellidos varchar(30) NULL,
	NombreCarrera varchar(20) NULL,
	Matricula varchar(15) NULL,
	Edad int NULL,
	Direccion varchar(70) NULL,
	MontoEstudiante float NULL
)
go
create table Becas(

NotaId int primary key identity(1,1),
Fecha varchar(12),
Observaciones  varchar(300),
 MontoaAsignatura float,
 PctBeca float,
 Monto float,
 EstudianteId int references Estudiantes(EstudianteId)
 )


go
 create table Inscripciones(
 InscripcionId int primary key identity(1,1),
 Fecha varchar(12),
 EstudianteId int references Estudiantes(EstudianteId),
 Monto float,
 Balance float
 )
go

  create table Pagos(
  IdPago int  primary key identity(1,1),
  IdEstudiante int ,
  Monto float,
  Balance float,
  Pago float,
  Observaciones varchar(300),
  Fecha varchar(12)
  )

go
  create table TipoTelefonos(
  TipoId int  primary key identity(1,1),
  Celular varchar(14),
  Telefono varchar (14),
  Descripcion varchar (300)
  )









