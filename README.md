# Sistema_Techno_1
Programa venta repuestos
Procedimientos Para Categorias
--Procedimiento Listar
create proc categoria_listar
as
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from Categoria
order by idcategoria desc
go

--Procedimiento buscar
create proc categoria_buscar
@valor varchar (50)
as
select idcategoria as ID,nombre as Nombre,descripcion as Descripcion,estado as Estado
from Categoria
where nombre like '%' + @valor + '%' Or descripcion like '%' + @valor +'%'
order by nombre asc
go

--Procedimiento Insertar
create proc categoria_insertar
@nombre varchar(50),
@descripcion varchar(255)
as
insert into Categoria (nombre,descripcion) values (@nombre,@descripcion)
go
--Procedimiento actualizar
create proc categoria_actualizar
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(255)
as
update Categoria set nombre=@nombre,descripcion=@descripcion
where idcategoria=@idcategoria
go

--Procedimiento Eliminar
create proc categoria_eliminar
@idcategoria int
as
delete from Categoria
where idcategoria=@idcategoria
go

--Procedimiento desactivar
create proc categoria_desactivar
@idcategoria int
as
update Categoria set estado=0
where idcategoria=@idcategoria
go

--Procedimiento Activar
create proc categoria_activar
@idcategoria int
as
update Categoria set estado=1
where idcategoria=@idcategoria
go

--Procedimiento Categoria_Existe
create proc categoria_existe
@valor varchar(100),
@existe bit output
as
	if exists( select nombre from Categoria where nombre = ltrim(rtrim(@valor))) --ltrim,rtrim borra los espacion derecha izquierda
		begin
		set @existe=1
		end
	else
		begin
		set @existe =0
		end
