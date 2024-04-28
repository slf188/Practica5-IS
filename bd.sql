-- Crear la tabla Categoria
CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(50)
);

-- Crear la tabla Cliente
CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY,
    cedula VARCHAR(50),
    nombre VARCHAR(50),
    direccion VARCHAR(50),
    telefono VARCHAR(50),
    idCategoria INT, -- Esta será la clave foránea
    FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);

-- Crear la tabla Factura
CREATE TABLE Factura (
    numero_factura INT PRIMARY KEY IDENTITY,
    fecha DATE,
    idCliente INT, -- Esta será la clave foránea
    FOREIGN KEY (idCliente) REFERENCES Cliente(id)
);

-- Crear la tabla Productos
CREATE TABLE Productos (
    idProducto INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(50),
    precio_unitario DECIMAL(10, 2),
    iva TINYINT
);

-- Crear la tabla DetalleFactura
CREATE TABLE DetalleFactura (
    id INT PRIMARY KEY IDENTITY,
    idFactura INT,
    idProducto INT,
    cantidad INT,
    precio DECIMAL(10, 2),
    FOREIGN KEY (idFactura) REFERENCES Factura(numero_factura),
    FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
);



-- Insertar datos en la tabla Categoria
INSERT INTO Categoria (nombre) VALUES ('Electrónica');
INSERT INTO Categoria (nombre) VALUES ('Ropa');
INSERT INTO Categoria (nombre) VALUES ('Hogar');

-- Insertar datos en la tabla Cliente
INSERT INTO Cliente (cedula, nombre, direccion, telefono, idCategoria) VALUES ('123456789', 'Juan Perez', 'Calle 123', '555-1234', 1);
INSERT INTO Cliente (cedula, nombre, direccion, telefono, idCategoria) VALUES ('987654321', 'Maria Lopez', 'Avenida Principal', '555-5678', 2);
INSERT INTO Cliente (cedula, nombre, direccion, telefono, idCategoria) VALUES ('456789123', 'Carlos Ramirez', 'Calle 456', '555-9012', 3);




-- Datos de ejemplo para la tabla Factura
INSERT INTO Factura (fecha, idCliente)
VALUES ('2024-04-24', 1),
       ('2024-04-23', 2),
       ('2024-04-22', 3);

-- Datos de ejemplo para la tabla Productos
INSERT INTO Productos (nombre, precio_unitario, iva)
VALUES ('Producto 1', 10.99, 10),
       ('Producto 2', 20.50, 8),
       ('Producto 3', 15.75, 12);

-- Datos de ejemplo para la tabla DetalleFactura
-- Supongamos que la factura número 1 incluye el producto 1 en cantidad 2
INSERT INTO DetalleFactura (idFactura, idProducto, cantidad, precio)
VALUES (1, 1, 2, 21.98),
-- La factura número 2 incluye el producto 2 en cantidad 1
       (2, 2, 1, 20.50),
-- La factura número 3 incluye el producto 1 en cantidad 1 y el producto 3 en cantidad 2
       (3, 1, 1, 10.99),
       (3, 3, 2, 31.50);
