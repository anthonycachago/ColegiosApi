
-- Tabla COLEGIO
CREATE TABLE Colegios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(256) UNIQUE NOT NULL,
    TipoColegio VARCHAR(64) NOT NULL
);
GO

-- Tabla USUARIO
CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto VARCHAR(256) NOT NULL,
    Username VARCHAR(128) UNIQUE NOT NULL,
    Password VARCHAR(128) NOT NULL,
    CorreoElectronico VARCHAR(256) NOT NULL,
    Rol VARCHAR(32) NOT NULL
);
GO

-- Tabla MATERIA
CREATE TABLE Materias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdColegio INT NOT NULL,
    Nombre VARCHAR(256) UNIQUE NOT NULL,
    Area VARCHAR(128) NOT NULL,
    NumeroEstudiantes INT NOT NULL,
    DocenteAsignado VARCHAR(512) NOT NULL,
    Curso VARCHAR(64) NOT NULL,
    Paralelo VARCHAR(16) NOT NULL,
    FOREIGN KEY (IdColegio) REFERENCES Colegios(Id)
);
GO

-- Tabla CALIFICACIONES
CREATE TABLE Calificaciones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdColegio INT NOT NULL,
    IdMateria INT NOT NULL,
    IdUsuario INT NOT NULL,
    Calificaciones DECIMAL(5, 2) NOT NULL,
    FOREIGN KEY (IdColegio) REFERENCES Colegios(Id),
    FOREIGN KEY (IdMateria) REFERENCES Materias(Id),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id)
);
GO