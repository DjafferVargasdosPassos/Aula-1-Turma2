select
car.Modelo, --Coluna da nossa tabela Carros Modelo
mar.Nome, --Coluna da nossa tabela marcas Nome
car.Placa,-- Coluna da nossa tabela Carros Placa
car.Ano -- Coluna da nossa tabela Carro Ano
from -- Indicador que vamos selecionar uma tabela
Carros -- Tabela que vamos selecionar
car-- Abreviamos e criamos um alias para chamar e ficar mais facil
inner-- Indicador que ambas as tabelas devem estar relacionadas com os dados 
join --Indicador do banco que junta uma tabela a outra 
Marcas--Nossa tabela que vamos juntar a Carros
mar-- abreviação da nossa tabela de Marcas para facilitar as referencias
on-- indicador que vamos mostrar como vamos relacionar as informações
car.MarcaCodigo = mar.Codigo --Aqui informamos que carros tem um codigo iguao a=em marcas e portanto a referencia de marca
--seria a coluna codigo com isso ele nos tras a linha que temos essa referencia  e 
--podemos utilizar todas as colunas da linha com informação


select car.Modelo,mar.Nome,car.Placa,car.Ano from Carros car inner join marcas mar on car.MarcaCodigo = mar.Codigo