CREATE TABLE category(
categoryId int Identity(100,1), --100'DEN BAÞLA 1'ER ARTTIR	
categoryName varchar(50),
constraint pk_categoryId primary key(categoryId)
)


CREATE TABLE product(
productId int Identity(100,1),
productName varchar(50),
categoryId int
constraint pk_productId primary key(productId),
constraint fk_categoryToProduct foreign key(categoryId) references category(categoryId)
)

alter table product drop constraint fk_categoryToProduct  --özellik kaldýrma

--kayýt ekle // category id identity olduðu için mssql otomatik deðer atayacak
INSERT INTO category VALUES('Kirtasiye'),('Elektronik'),('Mutfak'),('Mobilya')

SELECT * FROM category


INSERT INTO product(productName,categoryId) VALUES('Dolma Kalem',100),('TV',101),('PC',100),('Craft Kaðýt',100),('Blender',102),('Ankastre',102),('3^lü koltuk',103)

SELECT * FROM product

UPDATE product  SET categoryId=101 where productId=102 --PC deðeri 100 kategorisinden 101'e updatelendi(deðiþtirildi)

SELECT * FROM product WHERE categoryId=101

SELECT * FROM product WHERE categoryId=100 or categoryId=102
SELECT * FROM product WHERE categoryId in (100,102)  --üsttekinin farklý gösterimi categoryId içinde 100 ve 102'ler

SELECT * FROM product WHERE categoryId not in (100,102) --olmayanlarý vericek 101 ve 103 

SELECT * FROM product WHERE categoryId between 101 and 103  --101,102,103 categorylerini getir

SELECT * FROM product WHERE productName like '%t' -- son harfi t olan productName'i getir

SELECT * FROM product WHERE productName like 't%' -- ilk harfi t olan productName'i getir

SELECT * FROM product WHERE productName like '%ma%' -- içerisinde 'ma' geçen productName'i getir

/* ORDER BY KULLANIMI */
--query'nin en sonunda kullanýlýr
--ASC küçükten büyüðü (Alfabetik)
--DESC büyükten küçüðe

SELECT * FROM product ORDER BY productName ASC

/* GROUP BY KULLANIMI */

--> gruplamak için kullanýlýr
--> Gruplama fonksiyonlarý MAX,MIN, AVG, COUNT

SELECT categoryId, count(*) as KategoriSayisi from product GROUP BY categoryId --categoryID sayisini say, oluþan tabloya KategoriSayisi adýný ver


/* HAVÝNG KULLANIMI */
--> Gruplanmýþ ifadeleri filtrelemek için sadece group by ile kullanýlýr

---*** her bir kategoride ürün sayýsý 2 ve üzeri olanlarý göster
SELECT categoryId, count(*) '2denFazlaKategoriSayisi' from product group by categoryId having count(*)>=2
