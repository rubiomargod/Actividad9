CREATE DATABASE TIENDAA;

USE  TIENDAA;

CREATE TABLE productos(
idproducto INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
nombre VARCHAR(100),
descripcion VARCHAR(100),
precio DECIMAL(5,2));


INSERT INTO productos VALUES(NULL,'coca','Refresco','18');

SELECT * FROM productos;