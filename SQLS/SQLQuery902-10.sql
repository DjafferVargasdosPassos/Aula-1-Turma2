select * from Clientes;
select * from Pedidos;



select * from Pedidos ped 
where ped.ClienteId in (select cli.Id from CLientes cli
inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N00000001','N00000004','N00000009'));

select * from Cliente cli inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N00000001','N00000004','N00000009');

select * from Pedidos ped 
where ped.ClienteId in (select cli.Id from CLientes cli
inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N00000001','N00000004','N00000009'))
order by ped.Valor Desc;
