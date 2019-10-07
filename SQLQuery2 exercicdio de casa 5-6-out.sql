--2.2  - Agora devemos inserir 2 funcionarios diferentes
INSERT INTO Funcionarios (Nome) values
('Felipe'),
('Giomar')

--2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
INSERT INTO Produtos (Nome,Valor) values 
('Skol Beats Senses 313ml',5.49),
('Budweiser 550lm',6.99),
('Stella Artois 275ml',3.49),
('Patagonia Bohemis Pil 740ml',15.90),
('Corona Extra 355ml',4.99)

--select para visualizar a lista de funcionarios e de produtos
select * from Funcionarios
select * from Produtos

--2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo
	--   lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5 
INSERT INTO Pedidos (FuncionariosID,ProdutosID,Quantidade) values 
(1,4,5),
(1,3,2),
(2,2,4)


--2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
Select * From Funcionarios ORDER BY Nome 

--2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
Select * From Produtos ORDER BY Valor Desc

--2.7  - Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
Select ped.Id,fun.Nome,ped.ProdutosID,ped.Quantidade From Pedidos ped inner join Funcionarios fun on ped.FuncionariosID = fun.Id

--2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
Select fun.Nome,Sum(ped.Quantidade) as 'Quantidade' From Pedidos ped inner join Funcionarios fun on ped.FuncionariosID = fun .Id
Group By fun.Nome

--2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total
	   --lembrando que o valor total e a a "quantidade * valor"
select fun.Nome, Sum(ped.Quantidade * pro.Valor) as 'Total' from Pedidos ped inner join Funcionarios fun on ped.FuncionariosID = fun.Id
inner join Produtos pro on ped.ProdutosID = pro.Id
Group By fun.Nome
select * from Produtos;
select * from Pedidos;

--2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
Select top 1 pro.Nome, Sum(ped.Quantidade) as 'Quantidade' from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutosID
group by pro.Nome
order by Sum(ped.Quantidade) desc

--2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
select top 1 pro.Nome, SUm(ped.Quantidade * pro.Valor) as 'Receita Total' from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutosID
group by pro.Nome
order by 'Receita Total' desc

--2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado
select * from Produtos where Id not in (Select ped.ProdutosID from Funcionarios fun inner join Pedidos ped on fun.Id = ped.FuncionariosID
where fun.Nome like 'Felipe%')

-- Aqui tras os que não foram comprados apenas
/*select * from Produtos pro left join Pedidos ped on pro.Id = ped.ProdutosID
where ped.ProdutosID is null*/

--2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado
Select pro.Nome,Count(ped.ProdutosID) as 'Quantidade'from Produtos pro left join Pedidos ped on pro.Id = ped.ProdutosId
group by pro.Nome
order by 'Quantidade' desc