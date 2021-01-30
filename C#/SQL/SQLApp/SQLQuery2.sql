--Select ContactName,CompanyName,City from Customers
--Select * from Customers where City = 'London'

--Select * from Products where ProductID<15
--Select * from Suppliers where SupplierID=1 or SupplierID=4
--Select * from Products where CategoryID=2 and UnitPrice>20

--Select * from Products order by CategoryID,ProductName
--Select * from Products order by UnitPrice asc  --ascending
--Select * from Products order by UnitPrice desc --descending

--Select * from Products where CategoryID=1 order by UnitPrice asc
--Select count(*) as Adet from Products where CategoryID=2

--Select UnitPrice,count(*) from Products group by UnitPrice
--Select CategoryID,count(*) from Products where UnitPrice>10 group by CategoryID having count(*)<10

--Select p.ProductID,p.ProductName from Products as p inner join Categories as c on p.CategoryID=c.CategoryID where p.UnitPrice<10
--Select * from Products p left join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID=od.OrderID--solda olup sağda olmayanı da getir
--Select * from Products p right join [Order Details] od on p.ProductID=od.ProductID --sağda olup solda olmayanı da getir

--Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

--ÖDEV--

Select p.ProductName,sum(od.UnitPrice*od.Quantity) Total from Products p inner join [Order Details] od on p.ProductID=od.ProductID group by p.ProductName
order by sum(od.UnitPrice*od.Quantity)


