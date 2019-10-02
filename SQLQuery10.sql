﻿CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis

CREATE TABLE TIPOS
(
Id INT IDENTITY(1,1) NOT NULL,
CODIGO	INT NOT NULL,
TIPO NCHAR(30) NOT NULL
PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

CREATE TABLE MARCAS
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CODIGO INT NOT NULL,
	MARCA Nvarchar(60) NOT NULL
)
GO
CREATE TABLE MODELOS
(
Id INT IDENTITY(1,1) NOT NULL,
MODELO INT NOT NULL
PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO





