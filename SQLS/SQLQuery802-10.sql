select * from Clientes;
select * from Pedidos;

select -- Iniciando o select
ped.* -- aqui temos todas as colunas da nossa tabela de pedidos
from Pedidos ped -- seleção da nossa tabela de pedido
inner join -- Terminador sql que junta as duas informações 
Clientes Cli on ped.ClienteId = cli.Id -- validamos o que conecta as informações 
where cli.Id = 2; -- aqui aplicamos um filtro para estas informações 

select SUM(ped.Valor) from Pedidos ped inner join Clientes Cli on ped.ClienteId = cli.Id
where cli.Id = 2;

select IIF -- Iniciamos um If dentro de um select o memso pode mostrar ou nao uma informação 
(SUM(ped.Valor) -- somamos os valores do pedido do cliente que temos em nossa base
> 300, -- aplicamos uma regra para sorteio do nosso brinde
'Brinde XIAOMI', -- caso positivo temos o brinde
'Não Ganhou nada') -- caso valor negativo nao ganha o brinde
as 'Resultado', -- damos um nome ao nosso resultado
SUM(ped.Valor) as 'Total' -- aqui apresentamos o valor toataldo pedido
from Pedidos ped -- tabelas de pedidos
inner join Clientes Cli on ped.ClienteId = cli.Id
where cli.Id = 2; -- nosso filtro

select IIF(SUM(ped.Valor) > 300,'Brinde XIAOMI','Não Ganhou nada') as 'Resultado',SUM(ped.Valor) as 'Total',Cli.Nome
from Pedidos ped inner join Clientes Cli on ped.ClienteId = cli.Id
group by cli.Nome;

select IIF(SUM(ped.Valor) > 300,'Brinde XIAOMI','Não Ganhou nada') as 'Resultado',SUM(ped.Valor) as 'Total',Cli.Nome
from Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId
group by cli.Nome;
