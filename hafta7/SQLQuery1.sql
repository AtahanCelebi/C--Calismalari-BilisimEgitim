CREATE TABLE category(
categoryId int Identity(100,1), --100'DEN BA�LA 1'ER ARTTIR	
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

alter table product drop constraint fk_categoryToProduct  --�zellik kald�rma

--kay�t ekle // category id identity oldu�u i�in mssql otomatik de�er atayacak
INSERT INTO category VALUES('Kirtasiye'),('Elektronik'),('Mutfak'),('Mobilya')

SELECT * FROM category


INSERT INTO product(productName,categoryId) VALUES('Dolma Kalem',100),('TV',101),('PC',100),('Craft Ka��t',100),('Blender',102),('Ankastre',102),('3^l� koltuk',103)

SELECT * FROM product

UPDATE product  SET categoryId=101 where productId=102 --PC de�eri 100 kategorisinden 101'e updatelendi(de�i�tirildi)

SELECT * FROM product WHERE categoryId=101

SELECT * FROM product WHERE categoryId=100 or categoryId=102
SELECT * FROM product WHERE categoryId in (100,102)  --�sttekinin farkl� g�sterimi categoryId i�inde 100 ve 102'ler

SELECT * FROM product WHERE categoryId not in (100,102) --olmayanlar� vericek 101 ve 103 

SELECT * FROM product WHERE categoryId between 101 and 103  --101,102,103 categorylerini getir

SELECT * FROM product WHERE productName like '%t' -- son harfi t olan productName'i getir

SELECT * FROM product WHERE productName like 't%' -- ilk harfi t olan productName'i getir

SELECT * FROM product WHERE productName like '%ma%' -- i�erisinde 'ma' ge�en productName'i getir

/* ORDER BY KULLANIMI */
--query'nin en sonunda kullan�l�r
--ASC k���kten b�y��� (Alfabetik)
--DESC b�y�kten k����e

SELECT * FROM product ORDER BY productName ASC

/* GROUP BY KULLANIMI */

--> gruplamak i�in kullan�l�r
--> Gruplama fonksiyonlar� MAX,MIN, AVG, COUNT

SELECT categoryId, count(*) as KategoriSayisi from product GROUP BY categoryId --categoryID sayisini say, olu�an tabloya KategoriSayisi ad�n� ver


/* HAV�NG KULLANIMI */
--> Gruplanm�� ifadeleri filtrelemek i�in sadece group by ile kullan�l�r

---*** her bir kategoride �r�n say�s� 2 ve �zeri olanlar� g�ster
SELECT categoryId, count(*) '2denFazlaKategoriSayisi' from product group by categoryId having count(*)>=2
