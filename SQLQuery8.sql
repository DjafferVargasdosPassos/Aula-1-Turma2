create database BaseSistemaLocacao -- criamos nossa base de dados
GO 
use BaseSistemaLocacao -- indicamos que estamos utilizando ela para os comandos logo abaixo

GO
--Criação da nossa primeira tabela no banco de dados
create table Usuarios
(
    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
Go
create table Marcas
(
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)

GO
create table Carros
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo ]          NCHAR (50) NOT NULL,
    [MarcaCodigo]      INT        NOT NULL,
    [Placa]            NCHAR (7)  NOT NULL,
    [Ano ]             INT        NOT NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
create table Locacao
(
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT        NOT NULL,
    [CarroId]          NCHAR (10) NOT NULL,
    [Valor]            MONEY      NOT NULL,
    [DataInicial]      DATETIME   DEFAULT (getdate()) NOT NULL,
    [DataFinal]        DATETIME   DEFAULT (dateadd(day,(5),getdate())) NOT NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
insert into Usuarios (Nome,login,Senha) values('Administrador','admin','admin')
GO
INSERT INTO [dbo].[Marcas] ([Codigo], [Nome]) VALUES (1, 'Chevrolet')
GO
INSERT INTO [dbo].[Marcas] ( [Codigo], [Nome]) VALUES ( 2, 'Volkswagen')