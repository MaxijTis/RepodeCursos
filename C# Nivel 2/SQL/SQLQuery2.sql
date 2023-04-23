--Consultas SQL

--Leer 
--select * from TIPOSEDICION
select D.Titulo, D.CantidadCanciones, E.Descripcion from DISCOS D, ESTILOS E
where D.IdEstilo = E.Id

select * from ESTILOS
select * from DISCOS where IdEstilo = 2 and CantidadCanciones = 12

--Escribir
insert into DISCOS(Titulo, CantidadCanciones)
values('El titulo', 10)
--
insert into DISCOS values
('Titulo', getdate(), 10, 'URL', 1, 2)

--Modificar
update ESTILOS set Descripcion = 'Country' where Id = 1

--Eliminar
delete from DISCOS where id = 3 

delete from DISCOS where Id = 4 , 5 3j,