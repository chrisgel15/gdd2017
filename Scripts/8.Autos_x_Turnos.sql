-- Migracion Autos_X_Turnos

begin

insert into OLA_K_ASE.AUTOS_TURNOS(TURNO_ID, AUTO_ID)
select distinct TURNO_ID, AUTO_ID from OLA_K_ASE.Maestra_Stg1

end;