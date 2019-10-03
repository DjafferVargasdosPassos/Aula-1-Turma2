INSERT INTO Funcionarios(Nome,DataInicio) values ('Robervaldo','06/08/2019');
INSERT INTO Funcionarios(Nome,DataInicio) values ('Ricleidson','06/02/2019');
INSERT INTO Funcionarios(Nome,DataInicio) values ('Jucalico','06/04/2019');

update Funcionarios set Ativo = 1;

INSERT INTO Salarios (FuncionarioId,Valor,DataCriacao) values
(1,1800,'07/05/2019'),
(1,2213,'08/07/2019'),
(1,1900,'09/06/2019'),
(2,2100,'07/05/2019'),
(2,2183,'08/07/2019'),
(2,1913.54,'09/06/2019'),
(3,2200,'07/05/2019'),
(3,1600,'08/07/2019'),
(3,2420,'09/06/2019');

select * from Funcionarios;
select * from Salarios