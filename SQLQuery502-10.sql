INSERT INTO Clientes
values 
('Giomar',--nome
0,--Genero
75,-- Idade
1,--Ativo
0,--UsuarioCriacao
0,--UsuarioAlteracao
'10/02/2019',--DataCriacao
'10/02/2019')--DataAlteracao
GO
INSERT INTO Pedidos
(Numero,ClienteId,Valor) values ('N00000001',1,379.46);

select * from Clientes
