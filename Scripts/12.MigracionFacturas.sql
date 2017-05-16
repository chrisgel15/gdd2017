-- Migracion Facturas

begin

insert into OLA_K_ASE.FACTURAS(CLIENTE_ID, NUMERO, FECHA_FACT, FECHA_INICIO, FECHA_FIN, IMPORTE)
select Cliente_ID, Factura_Nro, Factura_Fecha, Factura_Fecha_Inicio, Factura_Fecha_Fin,
	sum(Turno_Precio_Base + Viaje_Cant_Kilometros*Turno_Valor_Kilometro) as Importe_Viaje
from OLA_K_ASE.Maestra_Stg1
where Factura_Nro is not null
group by Cliente_ID, Factura_Nro, Factura_Fecha, Factura_Fecha_Inicio, Factura_Fecha_Fin


update OLA_K_ASE.Maestra_stg1 
SET
	OLA_K_ASE.Maestra_stg1.FACTURA_ID = OLA_K_ASE.FACTURAS.ID_FACTURA

from OLA_K_ASE.Maestra_stg1 
	inner join OLA_K_ASE.FACTURAS
		on OLA_K_ASE.Maestra_stg1.CLIENTE_ID = OLA_K_ASE.FACTURAS.CLIENTE_ID and
		OLA_K_ASE.Maestra_stg1.Factura_Fecha_Inicio = OLA_K_ASE.FACTURAS.FECHA_INICIO and
		OLA_K_ASE.Maestra_stg1.Factura_Fecha_Fin = OLA_K_ASE.FACTURAS.FECHA_FIN and
		OLA_K_ASE.Maestra_stg1.Factura_Fecha = OLA_K_ASE.FACTURAS.FECHA_FACT and
		OLA_K_ASE.Maestra_stg1.Factura_Nro = OLA_K_ASE.FACTURAS.NUMERO
end
