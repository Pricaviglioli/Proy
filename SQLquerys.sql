CREATE TABLE Ventas(
idVta INT PRIMARY KEY IDENTITY(1,1),
fechaVta DATE,
totalVta INT,
TipoPago NVARCHAR(13)
);

CREATE TABLE Productos(
idProd INT PRIMARY KEY IDENTITY(1,1),
descriProd NVARCHAR(100),
PrecioUnitario INT
);

CREATE TABLE DetallesVenta(
ID INT PRIMARY KEY IDENTITY(1,1),
IDVenta INT FOREIGN KEY REFERENCES Ventas(idVta),
IDProd INT FOREIGN KEY REFERENCES Productos(idProd),
subtotal INT
);

select * from Productos
select * from DetallesVenta
select * from Ventas

INSERT INTO Productos
VALUES('Cerveza Quilmes', 2800)


CREATE PROCEDURE sp_InsertarDetalleVenta
    @IDVenta INT,
    @IDProd INT,
    @Cantidad INT
AS
BEGIN
    DECLARE @PrecioUnitario INT;
    DECLARE @Subtotal INT;

    -- Obtener el precio unitario del producto
    SELECT @PrecioUnitario = PrecioUnitario FROM Productos WHERE idProd = @IDProd;

    -- Calcular subtotal
    SET @Subtotal = @Cantidad * @PrecioUnitario;

    -- Insertar el detalle con subtotal calculado
    INSERT INTO DetallesVenta (IDVenta, IDProd, subtotal)
    VALUES (@IDVenta, @IDProd, @Subtotal);
END

CREATE PROCEDURE sp_RegistrarVta
    @fechaVta DATE,
    @totalVta INT,
    @TipoPago NVARCHAR(13)
AS
BEGIN
    INSERT INTO Ventas (fechaVta, totalVta, TipoPago)
    VALUES (@fechaVta, @totalVta, @TipoPago);
END