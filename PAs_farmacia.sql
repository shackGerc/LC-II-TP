create proc pa_consultar_ventas 
	@fecha1 datetime,
	@fecha2 datetime
as
begin
	if @fecha1 < @fecha2
	begin
		select v.nro_venta,
		fecha,
		sum(dv.cantidad) cantidad_comun,
		sum(r.cantidad) cantidad_reseta,
		sum(dv.cantidad * dv.precio_venta) importe_comun,
		sum(r.cantidad * r.precio_OS) importe_reseta_real
		from Ventas v
		join Detalles_ventas dv on v.nro_venta = dv.nro_venta
		left join Recetas r on v.nro_venta = r.nro_venta
		where fecha between @fecha1 and @fecha2
		group by v.nro_venta,fecha
		order by 1, 2
	end
	else
	begin
		raiserror('Valores incorrectos',16,1)
	end
end
go

exec pa_consultar_ventas '1/1/2000', '10/12/2022'

select * from Ventas
where fecha between '1/1/2000' and '10/12/2022'


--Compras
create proc pa_consultar_compras
	@fecha1 datetime,
	@fecha2 datetime 
as
begin
	if @fecha1 < @fecha2
	begin
		select c.nro_compra,
		fecha,
		nom_repartidor,
		sum(dv.cantidad) cantidad,
		sum(dv.cantidad * dv.precio_venta) importe_total		
		from Compras c
		join Detalles_compras dv on c.nro_compra = dv.nro_compra
		where fecha between @fecha1 and @fecha2
		group by c.nro_compra,fecha, nom_repartidor
		order by 1, 2
	end
	else
	begin
		raiserror('Valores incorrectos',16,1)
	end
end
go

exec pa_consultar_compras'1/1/2000', '10/12/2022'
