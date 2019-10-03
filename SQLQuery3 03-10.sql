select * from Usuarios;
select * from Marcas;

update Marcas
set 
UsuInc = 1
where UsuInc = 0 

Select mar.Nome
from Marcas mar inner join Usuarios usu on mar.Usuinc = usu.Id
where usu.Usuario like 'Felipe%'

select Nome from Marcas
where UsuInc = 1 

select Nome from Marcas
where UsuInc = 2

select Nome from Marcas
where UsuInc = 1
order by Id desc

select Nome from Marcas
where UsuInc = 2
order by Id desc

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Id = 1
order by Count(mar.UsuInc) desc;

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by Count(mar.UsuInc) desc;

select Count(mar.UsuInc) from Marcas mar inner join Usuarios Usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%'


Select car.Modelo
from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

-- somente carros cadastrados
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

