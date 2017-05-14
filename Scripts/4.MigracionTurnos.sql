-- Migracion Turnos

begin

insert into OLA_K_ASE.TURNOS(HORA_INICIO, HORA_FIN, DESCRIPCION, VALOR_KM, PRECIO_BASE)
select distinct Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Descripcion, Turno_Valor_Kilometro, Turno_Precio_Base from gd_esquema.Maestra

declare @cantidad_turnos int
declare @contador int
declare @id_turno int
declare @nombre_turno varchar(50)

set @cantidad_turnos = (select count(*) from OLA_K_ASE.TURNOS)
set @contador = 1

while @contador <= @cantidad_turnos
begin
set @nombre_turno = (select DESCRIPCION from OLA_K_ASE.TURNOS where ID_TURNO = @contador)

update OLA_K_ASE.Maestra_Stg1
set TURNO_ID = @contador
where Turno_Descripcion = @nombre_turno

set @contador = @contador + 1

end

end;

