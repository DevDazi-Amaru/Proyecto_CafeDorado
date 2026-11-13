CREATE DATABASE CAFEDORADO
GO
USE CAFEDORADO
GO

CREATE TABLE EMPLEADOS(
EmpleadoID INT IDENTITY (1,1) NOT NULL,
Codigo NVARCHAR (20) NOT NULL,
Cedula NVARCHAR (20) NOT NULL,
Nombre_Completo NVARCHAR (150) NOT NULL,
Telefono NVARCHAR (20) NOT NULL,
Correo NVARCHAR (50) NOT NULL, 
Usuario NVARCHAR (20) NOT NULL,
Contraseña NVARCHAR (20) NOT NULL,
Rol NVARCHAR (20) NOT NULL,
Estado NVARCHAR (20) NOT NULL,

PRIMARY KEY(EmpleadoID)
);

CREATE TABLE PRODUCTORES(
ProductorID INT IDENTITY (1, 1) NOT NULL,
Codigo AS ('PROD-' + RIGHT('00000' + CAST(ProductorID AS VARCHAR(10)), 5)) PERSISTED,
Cedula NVARCHAR (20) NOT NULL,
Nombre_Completo NVARCHAR (150) NOT NULL,
Nombre_Finca NVARCHAR (150) NOT NULL,
Ubicacion NVARCHAR (200) NOT NULL,
Altitud NVARCHAR (50) NOT NULL,
Correo NVARCHAR (50) NOT NULL,
Telefono NVARCHAR (20) NOT NULL,
Categoria NVARCHAR (20) NOT NULL,
Estado NVARCHAR (20) NOT NULL,

PRIMARY KEY (ProductorID)
);

CREATE TABLE CAFE(
TipoCafeID INT IDENTITY(1,1) NOT NULL,
Tipo_Cafe NVARCHAR (20) NOT NULL,
PrecioPorKilo DECIMAL(10,2) NOT NULL,
Descripcion NVARCHAR (250) NOT NULL,

PRIMARY KEY (TipoCafeID)
);

CREATE TABLE LOTESCAFE(
LoteID INT IDENTITY (1, 1) NOT NULL,
Codigo AS ('LOTE-' + RIGHT('00000' + CAST(LoteID AS VARCHAR(10)), 5)) PERSISTED,
Fecha_Recepcion DATE NOT NULL,
ProductorID INT NOT NULL,
TipoCafeID INT NOT NULL,
EmpleadoID INT NOT NULL,
CantidadSacos INT NOT NULL,
KilosBruto DECIMAL(10,2) NOT NULL,
TaraSacos AS (CantidadSacos * CAST(0.5 AS DECIMAL(10,2))),
KilosNetos AS (KilosBruto - (CantidadSacos * CAST(0.5 AS DECIMAL(10,2)))),
PorcentHumedad DECIMAL(5,2) NOT NULL,
PorcentDefectos DECIMAL(5,2) NOT NULL,
Calidad AS (
	Case 
		WHEN (PorcentHumedad >= 10.00 AND PorcentHumedad <= 12.00) AND PorcentDefectos <= 3.00
			THEN 'Calidad Oro'
		WHEN (PorcentHumedad >= 12.10 AND PorcentHumedad <= 13.00) AND (PorcentDefectos >= 3.10 AND PorcentDefectos <= 7.00)
			THEN 'Calidad Primera'
		WHEN (PorcentHumedad >= 13.10 AND PorcentHumedad <= 14.00) AND (PorcentDefectos >= 7.10 AND PorcentDefectos <= 12.00)
			Then 'Calidad Segunda' 
		WHEN PorcentHumedad >= 14.10 AND PorcentDefectos >= 12.10
			THEN 'Calidad Tercera'
		Else 'Procesando...'
	END
),
-- Estado NVARCHAR (20) NOT NULL,

PRIMARY KEY (LoteID),

CONSTRAINT FK_PRODUCTORES_LOTES FOREIGN KEY (ProductorID) REFERENCES PRODUCTORES(ProductorID),
CONSTRAINT FK_CAFES_LOTES FOREIGN KEY (TipoCafeID) REFERENCES CAFE(TipoCafeID),
CONSTRAINT FK_EMPLEADOS_LOTES FOREIGN KEY (EmpleadoID) REFERENCES EMPLEADOS(EmpleadoID)
);

CREATE TABLE LIQUIDACIONES(
LiquidacionID INT IDENTITY (1, 1) NOT NULL,
Codigo AS ('LIQ-' + RIGHT('00000' + CAST(LiquidacionID AS VARCHAR(10)), 5)) PERSISTED,
FechaEmision DATE NOT NULL,
LoteID INT NOT NULL,
KilosNetos DECIMAL(10,2) NOT NULL,
PrecioPorKilo DECIMAL (10,2) NOT NULL,
PrecioPorCalidad DECIMAL (10,2) NOT NULL,

SubtotalLote AS (KilosNetos * PrecioPorCalidad),

Bonificaciones DECIMAL (10,2) NOT NULL,


Retenciones DECIMAL (10,2) DEFAULT 0.02,

TotalAPagar AS ((KilosNetos * PrecioPorCalidad) + Bonificaciones - ((KilosNetos * PrecioPorCalidad) * Retenciones)),

Estado NVARCHAR (20) NOT NULL,
MetodoPago NVARCHAR (20) NOT NULL,

PRIMARY KEY (LiquidacionID),

CONSTRAINT FK_LOTE_LIQUIDACION FOREIGN KEY (LoteID) REFERENCES LOTESCAFE(LoteID)
);