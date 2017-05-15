-- Migracion Rendiciones

begin

insert into OLA_K_ASE.RENDICIONES(TURNO_ID, NUMERO, FECHA, IMPORTE, CHOFER_ID)
select turno_id , rendicion_nro, rendicion_fecha, sum(rendicion_importe), chofer_id
from OLA_K_ASE.Maestra_stg1 where rendicion_nro is not null
group by chofer_id, turno_id, Rendicion_Nro, Rendicion_Fecha


update OLA_K_ASE.Maestra_stg1 
SET
	OLA_K_ASE.Maestra_stg1.RENDICION_ID = OLA_K_ASE.RENDICIONES.ID_RENDICION

from OLA_K_ASE.Maestra_stg1 
	inner join OLA_K_ASE.RENDICIONES
		on OLA_K_ASE.Maestra_stg1.TURNO_ID = OLA_K_ASE.RENDICIONES.TURNO_ID and
		OLA_K_ASE.Maestra_stg1.Rendicion_Nro = OLA_K_ASE.RENDICIONES.NUMERO and
		OLA_K_ASE.Maestra_stg1.Rendicion_Fecha = OLA_K_ASE.RENDICIONES.FECHA and
		OLA_K_ASE.Maestra_stg1.Chofer_ID = OLA_K_ASE.RENDICIONES.CHOFER_ID
end
