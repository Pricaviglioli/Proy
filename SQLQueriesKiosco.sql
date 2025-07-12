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