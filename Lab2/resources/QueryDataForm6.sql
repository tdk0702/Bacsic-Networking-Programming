﻿CREATE DATABASE DISHES;
USE DISHES;
GO
CREATE TABLE DISH(
	IDMA INT IDENTITY(1,1) PRIMARY KEY,
	DName NTEXT NOT NULL,
	DImage NTEXT,
	IDNCC NVARCHAR(5) NOT NULL
)
GO
CREATE TABLE PERSON(
	IDNCC NVARCHAR(5) NOT NULL PRIMARY KEY,
	PName NTEXT,
	Permit INT
)
GO
--DROP TABLE DISH;
--DROP TABLE PERSON;
ALTER TABLE DISH ADD CONSTRAINT fk_dish_person FOREIGN KEY (IDNCC) REFERENCES PERSON(IDNCC)
INSERT INTO DISH
VALUES(N'Sơn Hàu Hải Vị', '.\link', 'PS000')
GO
INSERT INTO DISH
VALUES(N'Mỳ Cay', '.\link', 'PS000')
GO
INSERT INTO PERSON
VALUES('PS000', N'Trương Duy Khôi', 0)
GO



