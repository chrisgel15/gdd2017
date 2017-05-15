----CARGA USUARIOS CON CHOFERES ---

begin

insert into OLA_K_ASE.USUARIOS(NOMBRE, PASSWORD, CANT_FALLAS)
select distinct DNI, HashBytes('SHA2_256',convert(varchar(255), DNI)), 0 from OLA_K_ASE.choferes

declare @cantidad_usuarios int
declare @contador int
declare @id_usuario int
declare @nombre_usuario varchar(50)

set @cantidad_usuarios = (select count(*) from OLA_K_ASE.USUARIOS)
set @contador = 1

while @contador <= @cantidad_usuarios
begin
set @nombre_usuario = (select NOMBRE from OLA_K_ASE.USUARIOS where ID_USUARIO = @contador)

update OLA_K_ASE.CHOFERES
set USUARIO_ID = @contador
where DNI = @nombre_usuario

set @contador = @contador + 1

end

end

--- CARGA USUARIOS CON CLIENTES ---
begin

insert into OLA_K_ASE.USUARIOS(NOMBRE, PASSWORD, CANT_FALLAS)
select distinct DNI,HashBytes('SHA2_256',convert(varchar(255), DNI)), 0 from OLA_K_ASE.clientes

declare @cantidad_usuariosCL int
declare @contadorCL int
declare @id_usuarioCL int
declare @nombre_usuarioCL varchar(50)

set @cantidad_usuariosCL = (select count(*) from OLA_K_ASE.USUARIOS)
set @contadorCL = (select max(id_usuario) from OLA_K_ASE.USUARIOS)+1

while @contadorCL <= @cantidad_usuariosCL
begin
set @nombre_usuarioCL = (select NOMBRE from OLA_K_ASE.USUARIOS where ID_USUARIO = @contadorCL)

update OLA_K_ASE.CLIENTES
set USUARIO_ID = @contadorCL
where DNI = @nombre_usuarioCL

set @contadorCL = @contadorCL + 1

end


end;

