-- Clientes con mayor consumo
CREATE PROCEDURE dbo.clientesMayorConsumoSP @Anio integer = Null, @Inicio integer = Null, @Fin integer = Null
as
select top 5 year(fac.FECHA_FACT) as anio, month(fac.FECHA_FACT) as mes, cli.nombre, cli.apellido, sum(fac.importe) as consumo
from ola_k_ase.FACTURAS fac
left join OLA_K_ASE.CLIENTES cli on cli.ID_CLIENTE= fac.CLIENTE_ID
where year(fac.FECHA_FACT) = @Anio and month(fac.FECHA_FACT) between @Inicio and @Fin 
group by fac.FECHA_FACT, cli.nombre, cli.apellido 
order by sum(fac.importe) desc

--Para ejecutarlo y probarlo:
--EXEC dbo.clientesMayorConsumoSP @Anio = 2015, @Inicio = 01, @Fin = 03

-----------------------------