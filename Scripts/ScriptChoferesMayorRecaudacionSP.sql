-- Choferes con mayor recaudación
CREATE PROCEDURE dbo.choferesMayorRecaudacionSP @Anio integer = Null, @Inicio integer = Null, @Fin integer = Null
as
select top 5 year(ren.fecha) as anio , month(ren.fecha) as mes, chof.NOMBRE, CHOF.APELLIDO,  sum(ren.importe) as RECAUDACION from ola_k_ase.RENDICIONES ren
left join ola_k_ase.choferes chof on ren.CHOFER_ID= chof.ID_CHOFER
where year(ren.FECHA) = @Anio and month(ren.FECHA) between @Inicio and @Fin 
group by ren.fecha,chof.NOMBRE, CHOF.APELLIDO order by sum(ren.importe) desc

--Para ejecutarlo y probarlo:
--EXEC dbo.choferesMayorRecaudacionSP @Anio = 2015, @Inicio = 01, @Fin = 03

-----------------------------