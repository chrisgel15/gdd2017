begin

insert into OLA_K_ASE.CLIENTES(NOMBRE, APELLIDO, DNI, DIRECCION, MAIL, TELEFONO, FECHA_NAC)
select distinct Cliente_Nombre, Cliente_Apellido, Cliente_Dni, Cliente_Direccion, Cliente_Mail, Cliente_Telefono, Cliente_Fecha_Nac from gd_esquema.Maestra

declare @cantidad_clientes int
declare @contador int
declare @id_cliente int
declare @dni_cliente varchar(50)

set @cantidad_clientes = (select count(*) from OLA_K_ASE.CLIENTES)
set @contador = 1

while @contador <= @cantidad_clientes
begin
set @dni_cliente = (select DNI from OLA_K_ASE.clientes where ID_cliente = @contador)

update OLA_K_ASE.Maestra_Stg1
set CLIENTE_ID = @contador
where Cliente_Dni = @dni_cliente

set @contador = @contador + 1

end

end;