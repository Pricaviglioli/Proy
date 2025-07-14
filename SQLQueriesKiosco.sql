CREATE TABLE Usuarios(
id_usuario INT PRIMARY KEY,
username NVARCHAR(60),
password NVARCHAR(60),
rol NVARCHAR(15)
);

CREATE TABLE Productos(
id_prod INT PRIMARY KEY,
descripcion NVARCHAR(60),
precio_unitario DECIMAL(18,2)
);

CREATE TABLE Venta(
id_vta INT PRIMARY KEY IDENTITY(1,1),
tipo_pago NVARCHAR(13),
total DECIMAL(18,2)
);


CREATE TABLE DetalleVta(
id_detalleVta INT PRIMARY KEY IDENTITY(1,1),
id_vta INT FOREIGN KEY REFERENCES Venta(id_vta),
id_prod INT FOREIGN KEY REFERENCES Productos(id_prod),
cantidad DECIMAL(18,2),
fecha DATE,
subtotal DECIMAL(18,2)
);


INSERT INTO Productos
VALUES(3, 'Galletitas Diversión', 6500.00)


CREATE PROCEDURE spu_mostrar_prods
AS
SELECT * FROM Productos

CREATE PROCEDURE spu_buscarprod_nombre
@nombre_prod NVARCHAR(60)
AS
SELECT * FROM Productos WHERE descripcion = @nombre_prod


CREATE PROCEDURE spu_agregar_prod
@id_prod INT,
@descripcion NVARCHAR(60),
@precio_unitario DECIMAL(18,2)
AS
INSERT INTO Productos
VALUES(@id_prod, @descripcion, @precio_unitario);

CREATE PROCEDURE spu_modificar_prod
@id_prod INT,
@descripcion NVARCHAR(60),
@precio_unitario DECIMAL(18,2)
AS
UPDATE Productos SET descripcion = @descripcion, precio_unitario = @precio_unitario WHERE id_prod = @id_prod;

CREATE PROCEDURE spu_eliminar_prod
@id_prod INT
AS
DELETE FROM Productos WHERE id_prod = @id_prod

INSERT INTO Usuarios
VALUES(1, 'Eze', '1234', 'Administrador')


CREATE PROCEDURE spu_mostrar_usuarios
AS
SELECT * FROM Usuarios


CREATE PROCEDURE spu_agregar_user
@id_usuario INT,
@username NVARCHAR(60),
@password NVARCHAR(60),
@rol NVARCHAR(15)
AS
INSERT INTO Usuarios
VALUES(@id_usuario, @username, @password, @rol);

CREATE PROCEDURE spu_modificar_user
@id_usuario INT,
@username NVARCHAR(60),
@password NVARCHAR(60),
@rol NVARCHAR(15)
AS
UPDATE Usuarios SET username = @username, password = @password, rol = @rol WHERE id_usuario = @id_usuario;

CREATE PROCEDURE spu_eliminar_user
@id_usuario INT
AS
DELETE FROM Usuarios WHERE id_usuario = @id_usuario


CREATE PROCEDURE spu_registrar_detallevta
@id_vta INT,
@id_prod INT,
@cantidad DECIMAL(18,2),
@fecha DATETIME,
@subtotal DECIMAL(18,2)
AS
INSERT INTO DetalleVta
VALUES(@id_vta, @id_prod, @cantidad, @fecha, @subtotal)

CREATE PROCEDURE spu_registrar_vta
@tipo_pago NVARCHAR(13),
@total DECIMAL(18,2)
AS
INSERT INTO Venta
VALUES(@tipo_pago, @total)

DROP TABLE DetalleVta
DROP TABLE Venta
DROP PROCEDURE spu_registrar_detallevta
DROP PROCEDURE spu_registrar_vta

SELECT MAX(id_vta) FROM Venta

CREATE PROCEDURE spu_mostrar_vtas
AS
SELECT * FROM Venta

SELECT * FROM DetalleVta

SELECT
  DetalleVta.id_detalleVta   AS DetalleID,
  Venta.id_vta               AS VentaID,
  Productos.descripcion      AS Producto,
  DetalleVta.cantidad        AS Cantidad,
  DetalleVta.subtotal        AS Subtotal,
  DetalleVta.fecha           AS Fecha,
  Venta.tipo_pago            AS TipoPago,
  Venta.total                AS TotalVenta
FROM DetalleVta
INNER JOIN Venta
  ON DetalleVta.id_vta = Venta.id_vta
INNER JOIN Productos
  ON DetalleVta.id_prod = Productos.id_prod
ORDER BY
  Venta.id_vta,
  DetalleVta.id_detalleVta;


 CREATE PROCEDURE spu_mostrar_vtas
 AS
 SELECT
  DetalleVta.id_detalleVta   AS DetalleID,
  Venta.id_vta               AS VentaID,
  Productos.descripcion      AS Producto,
  DetalleVta.cantidad        AS Cantidad,
  DetalleVta.subtotal        AS Subtotal,
  DetalleVta.fecha           AS Fecha,
  Venta.tipo_pago            AS TipoPago,
  Venta.total                AS TotalVenta
FROM DetalleVta
INNER JOIN Venta
  ON DetalleVta.id_vta = Venta.id_vta
INNER JOIN Productos
  ON DetalleVta.id_prod = Productos.id_prod
ORDER BY
  Venta.id_vta,
  DetalleVta.id_detalleVta;


  CREATE PROCEDURE spu_buscar_ventas
  @fecha_inicio DATE         = NULL, 
  @fecha_fin    DATE         = NULL,
  @descripcion  NVARCHAR(60) = NULL,
  @tipo_pago    NVARCHAR(13) = NULL
AS
BEGIN
  SET NOCOUNT ON;

  SELECT
    Venta.id_vta,
    Venta.tipo_pago,
    Venta.total,
    DetalleVta.id_detalleVta,
    DetalleVta.fecha,
    Productos.descripcion      AS Producto,
    DetalleVta.cantidad,
    DetalleVta.subtotal
  FROM Venta
  INNER JOIN DetalleVta
    ON Venta.id_vta = DetalleVta.id_vta
  INNER JOIN Productos
    ON DetalleVta.id_prod = Productos.id_prod
  WHERE
    (@fecha_inicio IS NULL OR DetalleVta.fecha >= @fecha_inicio)
    AND (@fecha_fin    IS NULL OR DetalleVta.fecha <= @fecha_fin)
    AND (@descripcion IS NULL OR Productos.descripcion LIKE '%' + @descripcion + '%')
    AND (@tipo_pago   IS NULL OR Venta.tipo_pago = @tipo_pago)
  ORDER BY Venta.id_vta, DetalleVta.id_detalleVta;
END


EXEC spu_buscar_ventas

EXEC spu_buscar_ventas null, null, 'cerveza iguana', 'efectivo';


CREATE PROCEDURE mostrar_prod_eliminables
AS
SELECT
  Productos.id_prod,
  Productos.descripcion,
  Productos.precio_unitario
FROM Productos
LEFT JOIN DetalleVta
  ON Productos.id_prod = DetalleVta.id_prod
WHERE DetalleVta.id_prod IS NULL;
