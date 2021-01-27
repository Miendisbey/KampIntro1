--Select
--ANSII Standartı
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive (büyük küçük haft duyarsız)
Select * from Products where categoryId = 1 or categoryId = 3

Select * from Products where categoryId = 1 and UnitPrice>=10

select * from Products order by ProductName --order by sırala demek.

select * from Products order by CategoryID,ProductName --ıd leri sıralıyor, kendi içlerinde de isimlerine göre sıralıyor

select * from Products order by UnitPrice asc   --ascending (artan)

select * from Products where CategoryID=1 order by UnitPrice desc  --descending (azalan-düşen)

select count(*) Adet from products where CategoryID =2

select CategoryID,count(*) from Products group by CategoryID having count(*)<10  --10 tane üründen az olanları categoryıd'ye listeler

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10  
--birim fiyatı 20den fazla olan ürünleri categoryıd'ye göre sırala 10dan az olanları göster

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
 from Products inner join Categories on Products.CategoryID = Categories.CategoryID
 where Products.UnitPrice>10  --ürünlerden fiyatı 10dan büyük olanlar için kategorilerle join et ve getir

 --DTO  Data Transformation object

 select * from Products p left join [Order Details] od
 on p.ProductID = od.ProductID

 Select * from Customers c left join Orders o
 on c.CustomerID = o.CustomerID
 where o.CustomerID is null --genellikle left join tercih edilir

 Select * from Orders o right join Customers c
 on c.CustomerID = o.CustomerID
 where o.CustomerID is null


 Select * from Products p inner join [Order Details] od
 on p.ProductID = od.ProductID
 inner join Orders o
 on o.OrderID = od.OrderID
