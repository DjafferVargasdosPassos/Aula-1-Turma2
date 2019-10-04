INSERT INTO PlayList Values ('Another Brick in the Wall','Pink Floyd','Rock')

select Genero, count(Artista) from PlayList
group by Genero

select * from PlayList

select Artista,Count(Nome) from PlayList
group by Artista

select DISTINCT Genero from PlayList