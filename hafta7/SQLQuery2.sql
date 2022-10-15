

create table brands(
brandId int Identity(10,1),
brandName varchar(50),
constraint pk_brandPrimary primary key(brandId),
)

alter table product add brandId int foreign key references brands(brandId)

insert into brands(brandName) Values('BOSCH'),('ARÇELÝK'),('ADEL'),('BELLONA'),('FABER CASTELL'),('ÝSTÝKBAL')

select * from product
--null geliyor product'ý updatelememiz lazým

update product set brandId=10 Where productId=107 --ankastre'ye brandID bosh ekledi

update product set brandId=13 Where productId=108 

update product set brandId=14 Where productId in (102,103,105)

update product set brandId=12 Where productId in (104)

select COUNT(productId)as adet from product where brandId=14 --fabercastel(14) olan kaç tane product var


/* JOIN TÜRLERÝ

Inner Join -> Sadece eþleþenleri birleþtirmek için kullanýlýr
Left Join -> Sol tarafýn her kaydý ile, sað tarafýn sadece eþleþenlerini getirir
Right Join -> sað tarafon her kaydý ile, sol tarafýn sadece eþleþenlerini getirir
Full outer Join -> Her iki tabloda önce eþleþen sonra eþleþmeyen kayýtlar getirir.

*/

SELECT * FROM product p inner join brands b on b.brandId=p.brandId

--ALternatif (product'ýn hepsini getir, brands tablosundan sadece brandName'i getir)

SELECT p.*,b.brandName FROM product p inner join brands b on b.brandId=p.brandId

--Kategori adlarýný da ekleyerek 3 farklý tabloyu eþleþtir

SELECT p.*,b.brandName,c.categoryName FROM product p
inner join brands b on b.brandId=p.brandId 
inner join category c on c.categoryId = p.categoryId

SELECT p.*,b.brandName,c.categoryName FROM product p
inner join brands b on b.brandId=p.brandId 
inner join category c on c.categoryId = p.categoryId
WHERE c.categoryName='Mutfak'

-- Her bir kategorideki ürün sayýsý

SELECT c.categoryName, COUNT(*) as Adet
FROM product p
inner join category c on c.categoryId = p.categoryId
group by c.categoryName

-- FABER CASTELL MARKALI ÜRÜNLER
SELECT p.productName,b.brandName FROM product p
inner join brands b on b.brandId=p.brandId 
Where brandName='FABER CASTELL'

---Eþleþen eþleþmeyen tüm kayýtlarý getir (NULL) dahil.
SELECT *
FROM product p
full outer join brands b on b.brandId=p.brandId 

--product tablosunda eþleþenleri getir
SELECT *
FROM product p
left join brands b on b.brandId=p.brandId 

--brand tablosunda eþleþenleri getir
SELECT *
FROM product p								--Arçelik ve istikbal boþ olmasýna raðmen geldi
right join brands b on b.brandId=p.brandId  --çünkü right join yaptýk


/* SUBQUERY*/

--> Mutfak kategorisindeki ürünler
SELECT *
FROM product
WHERE categoryId= (SELECT categoryId           --> categoryName'i MUTFAK olan
					FROM category         --> categoryId'leri getir
					WHERE categoryName='MUTFAK') 


--> kýrtasiye kategorisinde olan brandler

Select * from brands where brandId in	(SELECT brandId
										FROM product
										WHERE categoryId= (SELECT categoryId           
														FROM category         
														WHERE categoryName='Kirtasiye'))


