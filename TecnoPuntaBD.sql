CREATE DATABASE TecnoPuntaBD

--Crear Tablas
USE TecnoPuntaBD;
GO

-- Crear la tabla Clientes
CREATE TABLE Clientes (
    DNI_Cliente INT NOT NULL,
    Nombre_Cliente VARCHAR(100) NOT NULL,
    Apellido_Cliente VARCHAR(100) NOT NULL,
    Telefono_Cliente VARCHAR(20) NOT NULL,
    Correo_Cliente VARCHAR(150) NOT NULL,
    Direccion_Cliente VARCHAR(150) NOT NULL,
    CONSTRAINT PK_Clientes PRIMARY KEY (DNI_cliente),
    CONSTRAINT UQ_Cliente_Correo UNIQUE (Correo_Cliente)
);
GO

-- Crear la tabla Productos
CREATE TABLE Productos (
    Modelo_Producto VARCHAR(100) NOT NULL,
    Marca_Producto VARCHAR(100) NOT NULL,
    Nombre_Producto VARCHAR(100) NOT NULL,
    SistemaOperativo_Producto VARCHAR(100) NOT NULL,
    Almacenamiento_Producto VARCHAR(100) NOT NULL,
    Ram_Producto VARCHAR(100) NOT NULL,
    Stock_Producto INT NOT NULL CHECK (Stock_Producto >= 0),
    Precio_Producto DECIMAL(10, 2) NOT NULL,
    Estado_Producto VARCHAR(100) NOT NULL,
    CONSTRAINT PK_Productos PRIMARY KEY (Modelo_Producto)
);
GO

-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    DNI_Usuario INT NOT NULL,
    Puesto_Usuario VARCHAR(100) NOT NULL,
    Usuario VARCHAR(100) NOT NULL,           
    Nombre_Usuario VARCHAR(100) NOT NULL,                             
    Apellido_Usuario VARCHAR(100) NOT NULL,                      

    Correo_Usuario VARCHAR(150) NOT NULL, 
    Sexo_Usuario VARCHAR(100) NOT NULL,
    Sueldo_Usuario DECIMAL(10, 2) NOT NULL,            
    Telefono_Usuario VARCHAR(20) NOT NULL,                                       
    Contraseña VARCHAR(100) NOT NULL, 
    CONSTRAINT PK_Usuarios PRIMARY KEY (DNI_Usuario), 
    CONSTRAINT UQ_Usuario_Name UNIQUE (Usuario),                 
    CONSTRAINT UQ_Usuario_Email UNIQUE (Correo_Usuario)                  
);
GO

-- Crear la tabla Factura
CREATE TABLE Factura (
    ID_Factura INT CONSTRAINT PK_Factura PRIMARY KEY IDENTITY(1,1),
    DNI_Cliente INT NOT NULL,                                     
    DNI_Vendedor INT NOT NULL,                                 
    FechaFactura DATE NOT NULL,                                     
    MedioPago VARCHAR(100) NOT NULL,                               
    Total DECIMAL(10, 2) NOT NULL,
    CONSTRAINT FK_Factura_Cliente FOREIGN KEY (DNI_Cliente) REFERENCES Clientes(DNI_cliente),
    CONSTRAINT FK_Factura_Vendedor FOREIGN KEY (DNI_Vendedor) REFERENCES Usuarios(DNI_Usuario)
);
GO

-- Crear la tabla Detalle_Factura
CREATE TABLE Detalle_Factura (
    ID_Detalle INT CONSTRAINT PK_Detalle_Factura PRIMARY KEY IDENTITY(1,1),
    DNI_Vendedor INT NOT NULL,                                 
    DNI_Cliente INT NOT NULL,                                       
    Modelo VARCHAR(100) NOT NULL,                       
    Cantidad INT NOT NULL CHECK (Cantidad >= 0),                                 
    Precio DECIMAL(10, 2) NOT NULL,                          
    ID_Factura INT NOT NULL,
    CONSTRAINT FK_Detalle_Vendedor FOREIGN KEY (DNI_Vendedor) REFERENCES Usuarios(DNI_Usuario),
    CONSTRAINT FK_Detalle_Cliente FOREIGN KEY (DNI_Cliente) REFERENCES Clientes(DNI_cliente),
    CONSTRAINT FK_Detalle_Producto FOREIGN KEY (Modelo) REFERENCES Productos(Modelo_Producto),
    CONSTRAINT FK_DetalleFactura_Factura FOREIGN KEY (ID_Factura) REFERENCES Factura(ID_Factura)
);

GO


--SEGUNDA PARTE. DALE BOLA DESDE ACA 


CREATE DATABASE TecnoPuntaBD

USE TecnoPuntaBD;
GO

CREATE TABLE Estado (
    Id_Estado INT NOT NULL,
    Descripcion_Estado VARCHAR(50) NOT NULL
	CONSTRAINT PK_Estado PRIMARY KEY (Id_Estado),
);

CREATE TABLE Sexo (
    Id_Sexo INT NOT NULL,
    Descripcion_Sexo VARCHAR(50) NOT NULL
	CONSTRAINT PK_Sexo PRIMARY KEY (Id_Sexo),
);
GO

CREATE TABLE Roles (
    Id_Rol INT NOT NULL ,
    Descripcion_Rol VARCHAR(50) NOT NULL
	CONSTRAINT PK_Roles PRIMARY KEY (Id_Rol),
);
GO

-- Crear la tabla Clientes
CREATE TABLE Clientes (
    DNI_Cliente INT NOT NULL,
    Nombre_Cliente VARCHAR(100) NOT NULL,
    Apellido_Cliente VARCHAR(100) NOT NULL,
    Telefono_Cliente VARCHAR(20) NOT NULL,
    Correo_Cliente VARCHAR(150) NOT NULL,
    Direccion_Cliente VARCHAR(150) NOT NULL,
    CONSTRAINT PK_Clientes PRIMARY KEY (DNI_cliente),
    CONSTRAINT UQ_Cliente_Correo UNIQUE (Correo_Cliente)
);
GO

-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    DNI_Usuario INT NOT NULL,
    Usuario VARCHAR(100) NOT NULL,           
    Nombre_Usuario VARCHAR(100) NOT NULL,                             
    Apellido_Usuario VARCHAR(100) NOT NULL,                      
    Correo_Usuario VARCHAR(150) NOT NULL, 
    
    Sueldo_Usuario DECIMAL(10, 2) NOT NULL,            
    Telefono_Usuario VARCHAR(100) NOT NULL,                                       
    Contraseña VARCHAR(100) NOT NULL, 
	Sexo_Usuario int NOT NULL,
	Rol_Usuario int NOT NULL,
	--Estado_Usuario int NOT NULL,

    CONSTRAINT PK_Usuarios PRIMARY KEY (DNI_Usuario), 
    CONSTRAINT UQ_Usuario_Name UNIQUE (Usuario),                 
    CONSTRAINT UQ_Usuario_Email UNIQUE (Correo_Usuario),      
	
	CONSTRAINT FK_Usuarios_Sexo FOREIGN KEY (Sexo_Usuario) REFERENCES Sexo(Id_Sexo),
	CONSTRAINT FK_Usuarios_Rol FOREIGN KEY (Rol_Usuario) REFERENCES Roles(Id_Rol),
	--CONSTRAINT FK_Estado_Usuario FOREIGN KEY (Estado_Usuario) REFERENCES Estado(Id_Estado)
);

--Producto
USE TecnoPuntaBD;
CREATE TABLE Marcas (
    Id_Marca INT IDENTITY(1,1) NOT NULL,
    Nombre_Marca VARCHAR(100) NOT NULL,
    PRIMARY KEY (Id_Marca)
);

CREATE TABLE Condicion (
    Id_Condicion INT IDENTITY(1,1) NOT NULL,
    Descripcion_Estado VARCHAR(100) NOT NULL,
    PRIMARY KEY (Id_Condicion)
);

CREATE TABLE Productos (
    Modelo_Producto VARCHAR(100) NOT NULL,
    Nombre_Producto VARCHAR(100) NOT NULL,
    SistemaOperativo_Producto VARCHAR(100) NOT NULL,
    Almacenamiento_Producto VARCHAR(100) NOT NULL,
    Ram_Producto VARCHAR(100) NOT NULL,
    Stock_Producto INT NOT NULL CHECK (Stock_Producto >= 0),
    Precio_Producto DECIMAL(10, 2) NOT NULL,
    Id_Marca INT,
    Id_Condicion INT,
    PRIMARY KEY (Modelo_Producto),
    CONSTRAINT FK_Marca FOREIGN KEY (Id_Marca) REFERENCES Marcas(Id_Marca),
    CONSTRAINT FK_Condicion FOREIGN KEY (Id_Condicion) REFERENCES Condicion(Id_Condicion)
);



USE TecnoPuntaBD;
select * from Condicion

INSERT INTO Productos (Modelo_Producto, Nombre_Producto, SistemaOperativo_Producto, Almacenamiento_Producto, Ram_Producto, Stock_Producto, Precio_Producto, Id_Marca, Id_Condicion) VALUES
('SM-G991B', 'Samsung Galaxy S21', 'Android', '128GB', '8GB', 50, 799.99, 1, 1),  -- Samsung, Nuevo
('MGH03LL/A', 'Apple iPhone 13', 'iOS', '256GB', '6GB', 30, 999.99, 2, 1),      -- Apple, Nuevo
('M2101K7AG', 'Xiaomi Redmi Note 10', 'Android', '64GB', '4GB', 100, 199.99, 3, 1),  -- Xiaomi, Nuevo
('CPH2159', 'Oppo Reno 5', 'Android', '128GB', '8GB', 20, 299.99, 4, 1),       -- Oppo, Nuevo
('XT2041-4', 'Motorola Moto G Power', 'Android', '64GB', '4GB', 75, 249.99, 5, 1),  -- Motorola, Nuevo
('ELS-NX9', 'Huawei P40', 'Android', '128GB', '8GB', 40, 499.99, 6, 1),        -- Huawei, Nuevo
('RMX3085', 'Realme 8', 'Android', '128GB', '8GB', 60, 199.99, 7, 1),          -- Realme, Nuevo
('COR-L29', 'Honor View 20', 'Android', '128GB', '6GB', 25, 399.99, 8, 1),     -- Honor, Nuevo
('MGH03LL/A-U', 'Apple iPhone 12', 'iOS', '128GB', '4GB', 10, 699.99, 2, 2),   -- Apple, Usado
('SM-G980F-U', 'Samsung Galaxy S20', 'Android', '128GB', '8GB', 5, 599.99, 1, 2); 

INSERT INTO Condicion (Descripcion_Estado) VALUES
('Nuevo'),
('Usado'),
('Reacondicionado');

INSERT INTO Marcas (Nombre_Marca) VALUES
('Samsung'),
('Apple'),
('Xiaomi'),
('Oppo'),
('Motorola'),
('Huawei'),
('Realme'),
('Honor');


INSERT INTO Sexo (Id_Sexo, Descripcion_Sexo) VALUES
(1, 'Masculino'),
(2, 'Femenino'),
(3, 'Otro');

INSERT INTO Roles (Id_Rol, Descripcion_Rol) VALUES
(1, 'Administrador'),
(2, 'Gerente'),
(3, 'Vendedor');






INSERT INTO Sexo (Id_Sexo, Descripcion_Sexo) VALUES
(1, 'Masculino'),
(2, 'Femenino'),
(3, 'Otro');


INSERT INTO Roles (Id_Rol, Descripcion_Rol) VALUES
(1, 'Administrador'),
(2, 'Cliente'),
(3, 'Empleado');

INSERT INTO Clientes (DNI_Cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente, Direccion_Cliente) VALUES
(12345678, 'Juan', 'Pérez', '555-1234', 'juan.perez@example.com', 'Calle Falsa 123'),
(87654321, 'Ana', 'Gómez', '555-5678', 'ana.gomez@example.com', 'Avenida Siempre Viva 456'),
(11223344, 'Carlos', 'López', '555-8765', 'carlos.lopez@example.com', 'Boulevard de los Sueños 789');

INSERT INTO Usuarios (DNI_Usuario, Usuario, Nombre_Usuario, Apellido_Usuario, Correo_Usuario, Sueldo_Usuario, Telefono_Usuario, Contraseña, Sexo_Usuario, Rol_Usuario) VALUES
(23456789 , 'juanito', 'Juan', 'Pérez', 'juan.perez@example.com', 3000.00, 5551234, 'password123', 1, 1),
(34567890, 'anita', 'Ana', 'Gómez', 'ana.gomez@example.com', 2000.00, 5555678, 'password456', 2, 3),
(45678901, 'carlitos', 'Carlos', 'López', 'carlos.lopez@example.com', 1500.00, 5558765, 'password789', 1, 2);

USE TecnoPuntaBD
select * from Roles

SELECT u.*, s.Descripcion_Sexo, r.Descripcion_Rol
FROM Usuarios u
JOIN Sexo s ON u.Sexo_Usuario = s.Id_Sexo
JOIN Roles r ON u.Rol_Usuario = r.Id_Rol

SELECT u.*, s.Descripcion_Sexo, r.Descripcion_Rol FROM Usuarios u JOIN Sexo s ON u.Id_Sexo = s.Id_Sexo JOIN Roles r ON u.Id_Rol = r.Id_Rol

SELECT 
    u.DNI_Usuario AS DNI,
    u.Usuario AS Usuario,
    u.Nombre_Usuario AS Nombre,
    u.Apellido_Usuario AS Apellido,
    u.Correo_Usuario AS Correo,
    u.Sueldo_Usuario AS Sueldo,
    u.Telefono_Usuario AS Telefono,
    u.Contraseña AS Contraseña,
    s.Descripcion_Sexo AS Sexo,
    r.Descripcion_Rol AS Rol
FROM 
    Usuarios u
JOIN 
    Sexo s ON u.Sexo_Usuario = s.Id_Sexo
JOIN 
    Roles r ON u.Rol_Usuario = r.Id_Rol;
