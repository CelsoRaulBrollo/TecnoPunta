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