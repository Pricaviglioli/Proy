CREATE TABLE Usuarios(
id_usuario INT PRIMARY KEY,
username NVARCHAR(60),
password NVARCHAR(60)
);

CREATE TABLE Productos(
id_prod INT PRIMARY KEY,
descripcion NVARCHAR(60),
precio_unitario DECIMAL(18,2)
);

CREATE TABLE Venta(
id_vta INT PRIMARY KEY,
tipo_pago NVARCHAR(13),
total DECIMAL(18,2)
);


CREATE TABLE DetalleVta(
id_detalleVta INT PRIMARY KEY,
id_vta INT FOREIGN KEY REFERENCES Venta(id_vta),
id_prod INT FOREIGN KEY REFERENCES Productos(id_prod),
cantidad DECIMAL(18,2),
fecha DATETIME,
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
