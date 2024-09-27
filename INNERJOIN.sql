Select ProductID,ProductName,CategoryID, UnitsInStock From Products
Select CategoryID, CategoryName From Categories
Select pr.ProductID,pr.ProductName,cr.CategoryName, pr.UnitsInStock From Products
pr Inner Join Categories cr
On pr.CategoryID = cr.CategoryID
