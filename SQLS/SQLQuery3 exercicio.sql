/*MOTO*/
select * from Tipos;
/*Marca*/
select * from Marcas;
/*Motos - Veiculos*/
select * from Veiculos;
/*select super bonus*/
select * from Veiculos vei inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
                           inner join Tipos tip on mar.TipoCodigo = tip.Codigo
GO
select
Vei.Id,
Vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
from Veiculos vei inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
                  inner join Tipos tip on mar.TipoCodigo = tip.Codigo
GO
select
Vei.Id,
Vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
from Veiculos vei 
inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
inner join Tipos tip on mar.TipoCodigo = tip.Codigo
where mar.Codigo = 4 /*Kawasaki*/
