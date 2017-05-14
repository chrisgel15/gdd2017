-- Migracion Marcas

begin

insert into OLA_K_ASE.MARCAS (nombre)
select distinct AUTO_MARCA from gd_esquema.Maestra

declare @cantidad_marcas int
declare @contador int
declare @id_marca int
declare @nombre_marca varchar(50)

set @cantidad_marcas = (select count(*) from OLA_K_ASE.MARCAS)
set @contador = 1

while @contador <= @cantidad_marcas 
begin
set @nombre_marca = (select nombre from OLA_K_ASE.MARCAS where ID_MARCA = @contador)

update OLA_K_ASE.Maestra_Stg1
set MARCA_ID = @contador
where Auto_Marca = @nombre_marca

set @contador = @contador + 1

end

end;