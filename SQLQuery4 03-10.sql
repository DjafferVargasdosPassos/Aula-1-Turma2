select count(mar.id) as totalregistros,usu.Usuario nomeUsuario 
from Marcas mar
inner join 
Usuarios --nome da tabela
usu ---apelido da tabela
on --- "WHERE" do meu inner join, condicao de IGUALDADE entre as tabelas
mar.UsuInc = usu.Id  -- CONDICAO LOGICA IGUAL ENTRE AS TABELAS
group by usu.Id,usu.Usuario -- 


select count(id) as ids from Marcas