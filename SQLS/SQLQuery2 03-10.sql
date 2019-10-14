Select Nome, (Select sum(Valor) from Salarios where FuncionarioId = Funcionarios.Id)
from Funcionarios


--Aqui é um select para descobrir a soma de todos os salarios de cada funcionario
Select fun.Nome,
Sum(sal.Valor) as 'Total nos 3 meses'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome

--Aqui é um select para descobrir a Média de todos os salarios de cada funcionario
Select fun.Nome,
AVG(sal.Valor) as 'Média dos 3 meses'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome

--Aqui é um select para descobrir a Média(AVG) de todos os salarios e quantidade(COUNT) de pagamentos de cada funcionario
Select fun.Nome,
AVG(sal.Valor) as 'Média dos 3 meses',
COUNT(sal.Valor) as 'Quant Pagamentos'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome

--Aqui é um select para descobrir a Média(AVG) de todos os salarios e quantidade(COUNT) de pagamentos de cada funcionario
--e uma outra froma para fazer a media usando (SUM /COUNT)
Select fun.Nome,
AVG(sal.Valor) as 'Média dos 3 meses',
COUNT(sal.Valor) as 'Quant Pagamentos',
SUM(sal.Valor)/ COUNT(sal.Valor) as 'Nova Média'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome

--
Select  fun.Nome,
AVG(sal.Valor) as 'Média dos 3 meses',
COUNT(sal.Valor) as 'Quant Pagamentos',
SUM(sal.Valor)/ COUNT(sal.Valor) as 'Nova Média',
SUM(sal.Valor) as 'Total'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome
order by SUM(sal.Valor) asc

--aqui é um select para fazer um filtro entre(between) Ids
Select * from Salarios
where Id between 3 and 8

--outro tipo de select para fazer um filtro entre os Ids 3 e 8
Select * from Salarios
where Id >= 3 and Id <= 8


--aqui é um select para fazer um filtro entre(between) as Datas de Criação
Select * from Salarios
where DataCriacao between '07/06/2019' and '08/07/2019'

--aqui é um select que faz um filro dos maiores salarios e apresenta em ordem decrescente
select top 5 * from Salarios
order by Valor desc

--aqui usamos um update para desligar o funcionario
update Funcionarios
set 
DataSaida = '10/04/2019',
DataAlteracao = GETDATE(),
Ativo = 0
where Nome like 'Ri%' 

select * from Funcionarios -- filtro de procura % quando esta no final ele busca  palavras que comece com as letras informadas
where Nome like 'Ri%' 

select * from Funcionarios
where Nome like '%son' --% quando esta no final ele busca  palavras que termine com as letras informadas

select * from Funcionarios
where Nome like '%li%' --% quando esta no inicio e no fim ele busca palavras que contem as letras informadas

select 
Nome, 
CONVERT(VARCHAR(10),DataInicio,103) as 'Inicio',
CONVERT(VARCHAR(10),DataInicio,103) as 'Saida'
from Funcionarios



select count(*) from Marca