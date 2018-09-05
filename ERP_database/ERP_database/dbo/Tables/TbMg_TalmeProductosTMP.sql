﻿CREATE TABLE [dbo].[TbMg_TalmeProductosTMP] (
    [Inv_codigo]              NVARCHAR (255) NULL,
    [Inv_nombre]              NVARCHAR (255) NULL,
    [Inv_descripcion]         NVARCHAR (255) NULL,
    [Inv_tipo]                NVARCHAR (255) NULL,
    [Inv_categoria]           NVARCHAR (255) NULL,
    [Inv_linea]               NVARCHAR (255) NULL,
    [Inv_medida]              NVARCHAR (255) NULL,
    [Inv_peso]                FLOAT (53)     NULL,
    [Inv_disponible_inicial]  FLOAT (53)     NULL,
    [Inv_fraccion]            FLOAT (53)     NULL,
    [Inv_disponible_anterior] FLOAT (53)     NULL,
    [Inv_disponible]          FLOAT (53)     NULL,
    [Inv_transito]            FLOAT (53)     NULL,
    [Inv_promedio_inicial]    FLOAT (53)     NULL,
    [Inv_promedio_anterior]   FLOAT (53)     NULL,
    [Inv_promedio]            FLOAT (53)     NULL,
    [Inv_ultimo_costo]        FLOAT (53)     NULL,
    [Inv_ultima_compra]       NVARCHAR (255) NULL,
    [Inv_ultima_venta]        NVARCHAR (255) NULL,
    [Inv_maximo]              FLOAT (53)     NULL,
    [Inv_minimo]              FLOAT (53)     NULL,
    [Inv_iva]                 NVARCHAR (255) NULL,
    [Inv_precio1]             FLOAT (53)     NULL,
    [Inv_precio2]             FLOAT (53)     NULL,
    [Inv_precio3]             FLOAT (53)     NULL,
    [Inv_precio4]             FLOAT (53)     NULL,
    [Inv_ultima_cotizacion]   FLOAT (53)     NULL,
    [Inv_proveedor]           NVARCHAR (255) NULL,
    [Inv_FechUltMov]          NVARCHAR (255) NULL,
    [Inv_UndXc]               FLOAT (53)     NULL,
    [Inv_Bonifi]              NVARCHAR (255) NULL,
    [Inv_Complemento]         BIT            NULL,
    [Inv_Cuenta]              NVARCHAR (255) NULL,
    [Inv_CostoProductoXTn]    FLOAT (53)     NULL,
    [Inv_Cuenta2]             NVARCHAR (255) NULL,
    [Inv_Largo]               FLOAT (53)     NULL,
    [Inv_Ancho]               NVARCHAR (255) NULL,
    [Inv_PesoEspecifico]      NVARCHAR (255) NULL,
    [Inv_Lote]                NVARCHAR (255) NULL
);
