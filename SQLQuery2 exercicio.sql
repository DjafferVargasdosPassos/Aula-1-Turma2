INSERT INTO Tipos values(1,'Carro'),(2,'Moto')
GO
--ou
/*INSERT DAS INFORMAÇÕES DOS TIPOS*/
--INSERT INTO Tipos (Codigo,Nome) values(1,'Carro')
--INSERT INTO Tipos (Codigo,Nome) values(2,'Moto')
/*INSERT DAS INFORMÇÕES DE MARCAS*/
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (1,'BMW',1)
GO
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (2,'BMW',2)
GO
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (3,'KIA',1)
GO
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (4,'KAWASAKI',2)
GO
/*Insert das informações de Veiculos*/
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('M6',1)
GO
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('R 1200',2)
GO
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Besta',3)
Go
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Sportage',3)
Go
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Z 1000',4)
GO
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Z 900',4)
GO
