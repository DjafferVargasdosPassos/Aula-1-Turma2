/*Realizar um update das informações que contem usuario de criação 0 para o Id do usuario Felipe*/
update Marcas
set 
UsuInc = 1
where UsuInc = 0 
/*Trazer somente as marcas que Felipe cadastrou*/
Select mar.Nome
from Marcas mar inner join Usuarios usu on mar.Usuinc = usu.Id
where usu.Usuario like 'Felipe%'
/*Trazer somente as marcas que Felipe cadastrou*/
/*select Nome from Marcas
where UsuInc = 1 */
/*Trazer somente as marcas que Giomar cadastrou*/
Select mar.Nome
from Marcas mar inner join Usuarios usu on mar.Usuinc = usu.Id
where usu.Usuario like 'Giomar%'

/*Trazer somente as marcas que Felipe cadastrou*/
/*select Nome from Marcas
where UsuInc = 1
order by Id desc*/

/*select Nome from Marcas
where UsuInc = 2
order by Id desc*/

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by Count(mar.UsuInc) desc;

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by Count(mar.UsuInc) desc;

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%'

Select car.Modelo
from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

Select car.Modelo
from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by Count(car.UsuInc) desc;

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by Count(car.UsuInc) asc;

select Count(car.UsuInc) from Carros car inner join Usuarios Usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%';

/*Trazer somente os carros das marcas que feipe cadastrou*/
select car.Modelo from Carros car inner join Marcas mar on car.Marca = mar.Id
                         inner join Usuarios usu on mar.Usuinc = usu.Id
						 where usu.Usuario like 'Felipe%'
						 
 /*select ca.Modelo from Carros ca inner join Usuarios us on ca.UsuInc = us.Id
                                 inner join Marcas ma on ma.Id = ca.Marca 
								 where us.Id =1 and ma.UsuInc =1*/

/*Trazer somente os carros das marcas que feipe cadastrou*/
select car.Modelo from Carros car inner join Marcas mar on car.Marca = mar.Id
                                  inner join Usuarios usu on mar.Usuinc = usu.Id
						          where usu.Usuario like 'Giomar%'

/*Trazer somente a quantidade de carros das marcas que felipe cadastrou maior para menor*/
select Count(Modelo) as 'Qnt' from Carros car inner join Marcas mar on car.Marca = mar.Id
						 inner join Usuarios usu on mar.Usuinc = usu.Id
						 where usu.Usuario like 'Felipe%'
						 order by count(Modelo) desc

/*Trazer somente a quantidade de carros das marcas que Giomar cadastrou maior para menor*/
select Count(car.Modelo) as 'Qnt' from Carros car inner join Marcas mar on car.Marca = mar.Id
						 inner join Usuarios usu on mar.Usuinc = usu.Id
						 where usu.Usuario like 'Giomar%'
						 order by count(car.Modelo) asc


/*Trazer o valor total de vendas 2019 isolado*/
select Sum(Valor) as 'valor total' from Vendas
where DatInc between '01/01/2019' and '12/31/2019'

/*também serve para buscar o valor total de vendas 209 isolado
select Sum(Valor) from Vendas
where DatInc like '%2019%'*/

/*também serve para buscar o valor total de vendas 209 isolado
select Count(Valor) from Vendas
where Year(DatInc) = '2019'*/

/*Trazer a quantidade total de vendas 2019 isolado*/
select Count(Valor) as 'Qtd Total' from Vendas
where Year(DatInc) = '2019'