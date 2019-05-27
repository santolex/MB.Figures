Tables: 
 1. Products
 2. Categories
 3. ProductCategories

SELECT p.Name ProductName ,c.Name CategoryName
FROM Products p
    LEFT JOIN ProductCategories pc ON pc.ProductId=p.Id
    LEFT JOIN Categories c ON pc.CategoryId=c.id

или так

SELECT p.Name ProductName ,a.CategoryName CategoryName
FROM Products p
    (SELECT p.ProductId,c.CategoryName
     FROM ProductCategories pc 
        INNER JOIN Categories c ON pc.CategoryId=c.id) a
    LEFT JOIN ON a.ProductId=p.id
