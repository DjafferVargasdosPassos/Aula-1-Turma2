INSERT INTO Flores(Nome,Quantidade) values 
('Rosa',3),
('Margarida',4),
('Copo de Leite',2),
('11 horas',5),
('Violeta',4)

--1.3 - Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade para a menor
SELECT * from Flores ORDER BY Quantidade desc

--1.3 - Devemos retornar uma seleção com a quantidade total de flores que temos em nossa tabela
SELECT COUNT(*) FROM Flores

--