-- Migracion Autos

begin

insert into OLA_K_ASE.AUTOS (MARCA_ID, MODELO, PATENTE, LICENCIA, RODADO, CHOFER_ID)
select distinct MARCA_ID, Auto_MODELO, Auto_PATENTE, Auto_LICENCIA, Auto_RODADO, CHOFER_ID from OLA_K_ASE.Maestra_Stg1

declare @cantidad_autos int
declare @contador int
declare @id_auto int
declare @patente_auto varchar(50)

set @cantidad_autos = (select count(*) from OLA_K_ASE.AUTOS)
set @contador = 1

while @contador <= @cantidad_autos
begin
set @patente_auto = (select patente from OLA_K_ASE.AUTOS where ID_AUTO = @contador)

update OLA_K_ASE.Maestra_Stg1
set AUTO_ID = @contador
where Auto_Patente = @patente_auto

set @contador = @contador + 1

end

end;