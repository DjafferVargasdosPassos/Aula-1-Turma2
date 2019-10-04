('Bro Hymm','Pennywise','Hard Core'),
('Fuck Authority','Pennywise','Hard Core'),
('Linoleum','NOFX','Hard Core'),
('Jesus of Suburbian','Green Day','Hard Core'),
('Sonho Médio','Dead Fish','Hard Core'),
('Higway to Hell','ACDC','Hard Rock'),
('Thunderstruck','ACDC','Hard Rock'),
('The Kids Aren´t Alright','Offstring','Hard Core'),
('Dani California','Red Hot Chili Peppers','Rock'),
('Can´t Stop','Red Hot Chili Peppers','Rock')

Insert into Generos values ('Hard Core'),('Hard Rock'),('Rock')
select * from Generos

Insert into Artistas (GeneroId,Nome) values(1,'Pennywiase'),
										   (1,'NOFX'),
										   (1,'Green Day'),
										   (1,'Dead Fish'),
										   (1,'Offspring'),
										   (2,'ACDC'),										   
										   (3,'Red Hot Chili Pppers')									  

select * from Artistas
		
Insert into Cancoes (ArtistaId,Nome) values (1,'Bro Hymm'),
                                            (1,'Fuck Authority'),
											(2,'Linoleum'),
											(3,'Jesus of Suburbian'),
											(4,'Sonho Médio'),
											(5,'The Kids Aren´t Alright'),
											(6,'Higway to Hell'),
											(6,'Thunderstruck'),
											(8,'Dani California'),
											(8,'Can´t Stop')

select gen.Nome as 'Genero', art.Nome as 'Artistas', can.Nome as 'Cancao' from Generos gen inner join Artistas art on gen.Id = art.GeneroId
										   inner join Cancoes can on art.Id = can.ArtistaId

select gen.Nome as 'Genero', Count(art.Nome) as 'Qtd Artistas' from Generos gen inner join Artistas art on gen.Id = art.GeneroId
group by gen.Nome


select gen.Nome as 'Genero', count(can.Nome) as 'Qtd de Cancoes' from Generos gen inner join Artistas art on gen.Id = art.GeneroId
                                             inner join Cancoes can on art.Id = can.ArtistaId
											 group by gen.Nome