CREATE VIEW vFindCountryNumber2 AS
select p.FirstName,p.LastName,pf.PhoneNumber,pm.EmailAddress,padr.City, padr.AddressLine1,st.Name as City2, crg.Name as Country
from Person.Person as p
inner join Person.PersonPhone as pf
on pf.BusinessEntityID = p.BusinessEntityID
inner join Person.EmailAddress as pm
on pm.BusinessEntityID=p.BusinessEntityID
inner join Person.BusinessEntityAddress as padress
on pf.BusinessEntityID =  padress.BusinessEntityID
inner join Person.Address as padr
on padr.AddressID = padress.AddressID
inner join person.StateProvince as st
on st.StateProvinceID = padr.AddressID
inner join Person.CountryRegion as crg
on crg.CountryRegionCode = st.CountryRegionCode



select * 
from vFindCountryNumber2


select Country as Kiþi,COUNT(Country) as Sayi
from vFindCountryNumber2
WHERE Country in('Canada','Australia') group by Country


select City, count(FirstName) from vFindCountryNumber2 as p where Country='France'
group by City
--having count(p.FirstName)>25