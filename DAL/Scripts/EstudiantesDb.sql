USE EstudiantesDb
GO
CREATE TABLE Estudiantes
(
	EstudianteId int primary key identity(1,1),
	Matricula varchar(9),
	Nombres varchar(30),
	Apellidos varchar(30),
	Cedula varchar(13),
	Telefono varchar(12),
	Celular varchar(12),
	Email varchar(30),
	FechaNacimiento date,
	Sexo int,
	Balance decimal(9,2)
);
GO
Create Table Inscripciones(
	InscripcionId int primary key identity(1,1),
	Fecha date,
	EstudianteId int,
	Comentario varchar(200),
	Monto decimal(9,2),
	Deposito decimal(9,2),
	Balance decimal(9,2) ,
	CONSTRAINT fk_EstudianteId FOREIGN KEY (EstudianteId) REFERENCES Estudiantes (EstudianteId),
);

