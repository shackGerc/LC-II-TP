--0.1

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


--0.2
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

--1
create proc pa_consultar_cubiertos_vendidos
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

--2
alter proc pa_ventas_vendedor
	@vendedor varchar(100),
	@minimo int,
	@fecha1 datetime,
	@fecha2 datetime
as
begin 
	select ape_empleado + ', ' + nom_empleado empleado,
	isnull(sum(r.gasto_total),0) importe_receta,
	sum(dv.gasto_total) importe_comun,
	sum(dv.gasto_total)+isnull(sum(r.gasto_total),0) importe_total,
	isnull(sum(r.cantidad_total),0) cantidad_receta,
	sum(dv.cantidad_total) cantidad_comun,
	sum(dv.cantidad_total)+isnull(sum(r.cantidad_total),0) cantidad_total
	from Empleados e
	join Ventas v on v.cod_empleado=e.cod_empleado
	left join (select nro_venta,sum(precio_venta*cantidad) gasto_total,
	sum(cantidad) cantidad_total from Detalles_ventas
	group by nro_venta) dv
	on v.nro_venta = dv.nro_venta
	left join (select nro_venta,
	sum(cantidad*precio_venta*(1-descuento*0.01)) gasto_total,
	sum(cantidad) cantidad_total from Recetas r
	join Cubiertos cu on cu.cod_cubierto = r.cod_cubierto
	group by nro_venta) r
	on v.nro_venta = r.nro_venta
	group by e.cod_empleado, ape_empleado + ', ' + nom_empleado
	having @minimo < (select count(distinct nro_venta) from ventas
	where fecha between @fecha1 and @fecha2 and e.cod_empleado=cod_empleado)
	and ape_empleado + ', ' + nom_empleado like '%'+@vendedor+'%'
end
go

exec pa_ventas_vendedor '', 0, '1/1/2000', '1/12/2022'
go

--3
alter procedure pa_reembolso_obrasocial

@fecha1 datetime,
@fecha2 datetime
as
 begin
if @fecha1 < @fecha2 
select year(fecha) anio, MONTH(fecha)mes, day(fecha)dia,
nom_obra_social obra_social,
count(r.cod_recetas) cantidad_recetas,
sum(precio_venta*(descuento*0.01))total_cobrado,
IIF(rembolsado=1,'Si', IIF(rembolsado=0,'No','Indefinido')) reembolso
from Lotes_Rembolso lr
join Recetas r on lr.cod_lote=r.cod_lote
join Cubiertos c on c.cod_cubierto=r.cod_cubierto
join Obras_sociales os on os.cod_obra_social=c.cod_obra_social
where  fecha between @fecha1 and @fecha2
group by fecha, nom_obra_social, rembolsado
order by fecha desc, nom_obra_social
end
go
exec pa_reembolso_obrasocial '1/1/2000', '1/12/2022'
go

--4
alter procedure pa_productos_fecha
as
begin
select s.cod_suministro Codigo, Descripcion, tipo_sum Tipo,
IIF(venta_libre=1,'Si', IIF(venta_libre=0,'No','Si')) 'Venta_Libre',
sum(cantidad)'Cantidad_total',
sum(cantidad*precio_venta) 'Gasto_total'
from Compras c join Detalles_compras dc on c.nro_compra=dc.nro_compra
join Suministros s on s.cod_suministro=dc.cod_suministro
join Tipos_suministros ts on s.cod_tipo_sum=ts.cod_tipo_sum
where month(fecha) between 1 and 6
and YEAR(fecha) = YEAR(getdate())
group by s.cod_suministro, descripcion, tipo_sum,venta_libre
order by 'Cantidad_total' desc
end
go

exec pa_productos_fecha
go

--7
CREATE PROCEDURE SP_SUMI_CLIENTES
@nombre_sum varchar(150)
AS
SET @nombre_sum='%'+@nombre_sum+'%'
SELECT descripcion 'Descripcion', tipo_sum 'TipoSuministro', nom_cliente+' '+ ape_cliente 'NombreCliente', 
sum(cantidad) 'Cantidad'
FROM Suministros s join Detalles_ventas dv on s.cod_suministro=dv.cod_suministro
join Ventas v on v.nro_venta=dv.nro_venta
join Clientes c on c.cod_cliente=v.cod_cliente
join Tipos_suministros ts on ts.cod_tipo_sum=s.cod_tipo_sum
WHERE descripcion like @nombre_sum
GROUP BY s.cod_suministro, descripcion, tipo_sum, c.cod_cliente, nom_cliente+' '+ ape_cliente
ORDER BY descripcion, 'NombreCliente'

--8

alter PROCEDURE SP_SUCURSALES_REEMBOLSOS
AS
SELECT calle+' '+cast(altura as varchar) 'Calle', barrio 'Barrio', nom_localidad 'Localidad', 
nom_provincia 'Provincia', count(lr.cod_lote) 'CantidadReembolsos'
FROM Sucursales s join Lotes_Rembolso lr 
on s.cod_sucursal=lr.cod_sucursal
join Calles c on c.cod_calle=s.cod_direccion
join Barrios b on b.cod_barrio=c.cod_barrio
join Localidades l on l.cod_localidad=b.cod_localidad
join Provincias p on p.id_provincia=l.id_provincia
WHERE datediff(year,fecha,getdate())=0 
GROUP BY s.cod_sucursal, calle+' '+cast(altura as varchar) , barrio, nom_localidad, nom_provincia
ORDER BY 'Calle'
go
exec SP_SUCURSALES_REEMBOLSOS
go

--
CREATE procedure pa_consutar_ventas_x_cliente_x_mes
@anio int
as
begin
	if(@anio is null)
		raiserror('No se ingreso el parametro año', 16, 1)
	else
		select ape_cliente + ', ' + nom_cliente 'Cliente',
		month(fecha) 'Mes',
		count(rv.nro_venta)'Cantidad_ventas_receta',
		count(dv.nro_venta) 'Cantidad_ventas_sin_receta',
		sum(rv.cantidad_total)'Cantidad_articulos_receta',
		sum(dv.cantidad_total) 'Cantidad_articulos_sin_receta'
		from Clientes c
		join Ventas v  on v.cod_cliente=c.cod_cliente
		left join (select nro_venta,sum(cantidad)cantidad_total from Detalles_ventas 
		group by nro_venta) dv
		on v.nro_venta = dv.nro_venta
		left join (select nro_venta,sum(cantidad) cantidad_total from Recetas 
		group by nro_venta) rv
		on  v.nro_venta = rv.nro_venta
		where year(fecha)=@anio
		group by c.cod_cliente, ape_cliente + ', ' + nom_cliente, month(fecha)
		order by 1, 2
end

go
exec pa_consutar_ventas_x_cliente_x_mes 2022

create proc pa_consultar_clientes_mas_sin_receta_que_con
@mes smallint,
@anio int
as
begin
	if(@anio is null or @mes is null)
	begin
		raiserror('No se ingresaron los parametros', 16, 1)
		return
	end
	if(@mes > 12 or @mes < 1)
	begin
		raiserror('El mes se ingreso en un formato incorrecto', 16, 1)
		return
	end

	select cod_cliente 'Codigo', ape_cliente + ', ' + nom_cliente 'Cliente', 
	nro_doc 'Nro_documento'
	from Clientes C
	where (select count(distinct v.nro_venta) 
		from Ventas v join Recetas r on v.nro_venta=r.nro_venta
		where cod_cliente=c.cod_cliente and month(fecha)=@mes and year(fecha)=@anio) <
	  (select count(distinct v.nro_venta) 
		from Ventas v join Detalles_ventas dv on v.nro_venta=dv.nro_venta
		where cod_cliente=c.cod_cliente and month(fecha)=@mes and year(fecha)=@anio)
end