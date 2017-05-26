CREATE TABLE dbo.products  
   (id int PRIMARY KEY NOT NULL IDENTITY,  
    name nvarchar(50) NOT NULL,  
    caloricity float NOT NULL,  
    protein float NULL,
	fat float NULL,
	carbo float NULL)  
GO  

drop table dbo.products

create procedure update_product (@my_id int, @new_cal float, @new_prot float, @new_fat float, @new_carbo float)
as update products
set caloricity = @new_cal, protein = @new_prot, fat = @new_fat, carbo = @new_carbo
where id = @my_id