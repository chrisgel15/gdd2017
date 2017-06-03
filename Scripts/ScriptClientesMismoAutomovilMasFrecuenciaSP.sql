-- Cliente que utilizo más veces el mismo automóvil en los viajes que ha realizado 
CREATE PROCEDURE dbo.clientesMismoAutomovilMasFrecuenciaSP @Anio integer = Null, @Inicio integer = Null, @Fin integer = Null
as
select top 5 cli.nombre, cli.apellido, vi.AUTO_ID, au.PATENTE, count(vi.ID_VIAJE) as cantidad_viajes 
from OLA_K_ASE.viajes vi
left join OLA_K_ASE.CLIENTES cli on cli.ID_CLIENTE= vi.CLIENTE_ID
left join ola_K_ase.AUTOS au on au.ID_AUTO = vi.AUTO_ID
where year(vi.FECHA_INICIO) = @Anio and month(vi.FECHA_INICIO) between @Inicio and @Fin 
group by cli.nombre, cli.apellido, vi.AUTO_ID, au.PATENTE 
order by count(vi.ID_VIAJE) desc

--Para ejecutarlo y probarlo:
--EXEC dbo.clientesMismoAutomovilMasFrecuenciaSP @Anio = 2015, @Inicio = 01, @Fin = 03

-----------------------------
