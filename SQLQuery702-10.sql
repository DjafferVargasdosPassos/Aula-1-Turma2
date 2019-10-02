INSERT INTO Clientes (Nome,Genero,Idade) values ('Fernando',0,36);
INSERT INTO	Clientes (Nome,Genero,Idade) values ('Djaffer',0,31);
INSERT INTO Clientes (Nome,Genero,Idade) values ('Daniela',1,33);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000002',2,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000003',2,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000004',2,100.00);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000005',3,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000006',3,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000007',3,100.00);

INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000008',4,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000009',4,100.00);
INSERT INTO Pedidos (Numero,ClienteId,Valor) values ('N00000010',4,100.00);

select * from Pedidos