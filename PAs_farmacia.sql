create proc pa_consultar_ventas 
	@fecha1 datetime,
	@fecha2 datetime
as
begin
	if @fecha1 < @fecha2
	begin
		select v.nro_venta,
		fecha,
		ape_cliente + ', ' + nom_cliente cliente,
		ape_empleado + ', ' + nom_empleado empleado,
		forma_pago forma_pago,
		sum(dv.cantidad)+
		sum(iif(r.cantidad is null, 0, r.cantidad))  cantidad,
		sum(dv.cantidad * dv.precio_venta)+
		sum(iif(r.cantidad * r.precio_venta is null, 0, r.cantidad * r.precio_venta)) importe_total
		from Ventas v
		join Clientes c on v.cod_cliente = c.cod_cliente
		join Empleados e on v.cod_empleado = e.cod_empleado
		join Formas_pago f on v.cod_forma_pago = f.cod_forma_pago
		join Detalles_ventas dv on v.nro_venta = dv.nro_venta
		left join Recetas r on v.nro_venta = r.nro_venta
		where fecha between @fecha1 and @fecha2
		group by v.nro_venta,fecha,
		ape_cliente ,nom_cliente ,
		ape_empleado ,nom_empleado ,
		forma_pago 
		order by 2
	end
	else
	begin
		raiserror('Valores incorrectos',16,1)
	end
end
go

exec pa_consultar_ventas '1/1/2000', '10/12/2022'
go


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
		nom_repartidor repartidor,
		nombre proveedor,
		ape_empleado + ', ' + nom_empleado empleado,
		forma_pago,
		sum(dv.cantidad) cantidad,
		sum(dv.cantidad * dv.precio_venta) importe_total		
		from Compras c
		join Detalles_compras dv on c.nro_compra = dv.nro_compra
		join Proveedores p on c.cod_proveedor = p.cod_proveedor
		join Empleados e on c.cod_empleado = e.cod_empleado
		join Formas_pago f on c.cod_forma_pago = f.cod_forma_pago
		where fecha between @fecha1 and @fecha2
		group by c.nro_compra,fecha,
		nom_repartidor,
		nombre,
		ape_empleado, nom_empleado,
		forma_pago
		order by 2
	end
	else
	begin
		raiserror('Valores incorrectos',16,1)
	end
end
go

exec pa_consultar_compras'1/1/2000', '10/12/2022'
go

alter proc pa_consultar_cubiertos_vendidos
	@fecha1 datetime,
	@fecha2 datetime,
	@descuento1 int,
	@descuento2 int,
	@no_vendidos int
as
begin
	Select cod_cubierto,
	os.nom_obra_social obra_social,
	su.descripcion suministro,
	descuento descuento,
	l.nom_localidad+', '+p.nom_provincia localidad,
	'Si' vendido
	from Cubiertos cu
	join Obras_sociales os on os.cod_obra_social=cu.cod_obra_social
	join Suministros su on su.cod_suministro=cu.cod_suministro
	join Localidades l on l.cod_localidad=cu.cod_localidad
	join Provincias p on p.id_provincia=l.id_provincia
	where descuento between @descuento1 and @descuento2
	and cu.cod_cubierto in
	(select cod_cubierto
	from Recetas r join Ventas v on v.nro_venta=r.nro_venta and
	fecha between @fecha1 and @fecha2)
	union
	Select cod_cubierto ,
	os.nom_obra_social ,
	su.descripcion ,
	descuento ,
	l.nom_localidad+', '+p.nom_provincia ,
	'No'
	from Cubiertos cu
	join Obras_sociales os on os.cod_obra_social=cu.cod_obra_social
	join Suministros su on su.cod_suministro=cu.cod_suministro
	join Localidades l on l.cod_localidad=cu.cod_localidad
	join Provincias p on p.id_provincia=l.id_provincia
	where descuento between @descuento1 and @descuento2
	and @no_vendidos = 1
	and cu.cod_cubierto not in
	(select cod_cubierto from Recetas)
	order by vendido desc, nom_obra_social, descripcion
end
go
exec pa_consultar_cubiertos_vendidos '1/5/2022', '30/6/2022', 0, 100, 0
go