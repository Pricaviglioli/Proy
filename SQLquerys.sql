CREATE TABLE Ventas(
idVta INT PRIMARY KEY IDENTITY(1,1),
fechaVta DATE,
totalVta INT,
TipoPago NVARCHAR(13),
);

CREATE TABLE Productos(
idProd INT PRIMARY KEY IDENTITY(1,1),
descriProd NVARCHAR(100),
PrecioUnitario INT,
);

CREATE TABLE DetallesVenta(
ID INT PRIMARY KEY IDENTITY(1,1),
IDVenta INT FOREIGN KEY REFERENCES Ventas(idVta),
IDProd INT FOREIGN KEY REFERENCES Productos(idProd),
subtotal INT,
);

select * from Productos
select * from DetallesVenta
select * from Ventas

INSERT INTO Productos
VALUES('Cerveza Brahama', 2800)