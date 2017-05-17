CREATE TABLE dbo.products  
   (id int PRIMARY KEY NOT NULL IDENTITY,  
    name nvarchar(50) NOT NULL,  
    caloricity float NOT NULL,  
    protein float NULL,
	fat float NULL,
	carbo float NULL)  
GO  

drop table dbo.products