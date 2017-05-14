begin

insert into OLA_K_ASE.CHOFERES(NOMBRE, APELLIDO, DNI, DIRECCION, TELEFONO, MAIL, FECHA_NAC)
select distinct Chofer_Nombre, Chofer_Apellido, Chofer_Dni, Chofer_Direccion, Chofer_Telefono, Chofer_Mail, Chofer_Fecha_Nac from gd_esquema.Maestra

declare @cantidad_choferes int
declare @contador int
declare @id_chofer int
declare @dni_chofer varchar(50)

set @cantidad_choferes = (select count(*) from OLA_K_ASE.CHOFERES)
set @contador = 1

while @contador <= @cantidad_choferes
begin
set @dni_chofer = (select DNI from OLA_K_ASE.choferes where ID_CHOFER = @contador)

update OLA_K_ASE.Maestra_Stg1
set CHOFER_ID = @contador
where Chofer_Dni = @dni_chofer

set @contador = @contador + 1

end

end;