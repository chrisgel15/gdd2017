-- Choferes con el viaje más largo realizado
CREATE PROCEDURE dbo.choferesViajeMasLargoSP @Anio integer = Null, @Inicio integer = Null, @Fin integer = Null
as
select top 5 year(vi.FECHA_INICIO) as anio , month(vi.FECHA_INICIO) as mes, chof.NOMBRE, 
CHOF.APELLIDO, DATEDIFF(minute,isnull(vi.FECHA_FIN,0),vi.FECHA_INICIO) as DURACION_VIAJE
from ola_k_ase.viajes vi
left join ola_k_ase.choferes chof on vi.CHOFER_ID= chof.ID_CHOFER
where year(vi.FECHA_INICIO) = @Anio and month(vi.FECHA_INICIO) between @Inicio and @Fin
group by vi.FECHA_INICIO, vi.fecha_fin, chof.NOMBRE, CHOF.APELLIDO 
order by DATEDIFF(minute,vi.FECHA_INICIO,isnull(vi.FECHA_FIN,0)) desc
GO

--Para ejecutarlo y probarlo:
--EXEC dbo.choferesViajeMasLargoSP @Anio = 2015, @Inicio = 01, @Fin = 03

-----------------------------