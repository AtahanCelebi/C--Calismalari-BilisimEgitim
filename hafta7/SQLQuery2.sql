

create table brands(
brandId int Identity(10,1),
brandName varchar(50),
constraint pk_brandPrimary primary key(brandId),
)

alter table product add brandId int foreign key references brands(brandId)

insert into brands(brandName) Values('BOSCH'),('AR�EL�K'),('ADEL'),('BELLONA'),('FABER CASTELL'),('�ST�KBAL')

select * from product
--null geliyor product'� updatelememiz laz�m

update product set brandId=10 Where productId=107 --ankastre'ye brandID bosh ekledi

update product set brandId=13 Where productId=108 

update product set brandId=14 Where productId in (102,103,105)

update product set brandId=12 Where productId in (104)

select COUNT(productId)as adet from product where brandId=14 --fabercastel(14) olan ka� tane product var


/* JOIN T�RLER�

Inner Join -> Sadece e�le�enleri birle�tirmek i�in kullan�l�r
Left Join -> Sol taraf�n her kayd� ile, sa� taraf�n sadece e�le�enlerini getirir
Right Join -> sa� tarafon her kayd� ile, sol taraf�n sadece e�le�enlerini getirir
Full outer Join -> Her iki tabloda �nce e�le�en sonra e�le�meyen kay�tlar getirir.

*/

SELECT * FROM product p inner join brands b on b.brandId=p.brandId

--ALternatif (product'�n hepsini getir, brands tablosundan sadece brandName'i getir)

SELECT p.*,b.brandName FROM product p inner join brands b on b.brandId=p.brandId

--Kategori adlar�n� da ekleyerek 3 farkl� tabloyu e�le�tir

SELECT p.*,b.brandName,c.categoryName FROM product p
inner join brands b on b.brandId=p.brandId 
inner join category c on c.categoryId = p.categoryId

SELECT p.*,b.brandName,c.categoryName FROM product p
inner join brands b on b.brandId=p.brandId 
inner join category c on c.categoryId = p.categoryId
WHERE c.categoryName='Mutfak'

-- Her bir kategorideki �r�n say�s�

SELECT c.categoryName, COUNT(*) as Adet
FROM product p
inner join category c on c.categoryId = p.categoryId
group by c.categoryName

-- FABER CASTELL MARKALI �R�NLER
SELECT p.productName,b.brandName FROM product p
inner join brands b on b.brandId=p.brandId 
Where brandName='FABER CASTELL'

---E�le�en e�le�meyen t�m kay�tlar� getir (NULL) dahil.
SELECT *
FROM product p
full outer join brands b on b.brandId=p.brandId 

--product tablosunda e�le�enleri getir
SELECT *
FROM product p
left join brands b on b.brandId=p.brandId 

--brand tablosunda e�le�enleri getir
SELECT *
FROM product p								--Ar�elik ve istikbal bo� olmas�na ra�men geldi
right join brands b on b.brandId=p.brandId  --��nk� right join yapt�k


/* SUBQUERY*/

--> Mutfak kategorisindeki �r�nler
SELECT *
FROM product
WHERE categoryId= (SELECT categoryId           --> categoryName'i MUTFAK olan
					FROM category         --> categoryId'leri getir
					WHERE categoryName='MUTFAK') 


--> k�rtasiye kategorisinde olan brandler

Select * from brands where brandId in	(SELECT brandId
										FROM product
										WHERE categoryId= (SELECT categoryId           
														FROM category         
														WHERE categoryName='Kirtasiye'))


