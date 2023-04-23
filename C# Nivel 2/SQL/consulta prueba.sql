select * from discos
select * from ESTILOS
select * from TIPOSEDICION

--Escribir
select D.Titulo, D.FechaLanzamiento, E.Descripcion from DISCOS D, ESTILOS E
where D.IdEstilo = E.Id

--insertar
insert into ESTILOS(Descripcion)
values ('Reggaeton')

insert into ESTILOS(Descripcion)
values ('Reggae')

insert into TIPOSEDICION(Descripcion)
values ('Dvd')
insert into DISCOS values
('Black Album', '1991-08-13', 12,'url', 3, 4 )

insert into DISCOS values 
('Iowa', '2002-08-10', 14, 'url', 3 , 5)


--Modificar
update DISCOS set FechaLanzamiento = '2000-05-13' where Id = 4

--borrar
delete from DISCOS where Id = 4
delete from DISCOS where Id = 6
delete from DISCOS where Id = 8
delete from DISCOS where Id = 11
delete from DISCOS where Id = 14
delete from ESTILOS where Id = 5
delete from ESTILOS where Id = 6
delete from ESTILOS where Id = 7
delete from ESTILOS where Id = 8

----------------------------------
select E.Descripcion from Discos D, ESTILOS E
where D.IdEstilo = E.Id

---------------------------------
select D.Titulo , E.Descripcion , T.Descripcion from DISCOS D , ESTILOS E , TIPOSEDICION T
where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id
-------------------------------------------------
select * from discos
where titulo like '%ho%';