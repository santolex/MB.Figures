SELECT p.Name ProductName ,c.Name CategoryName
FROM Products p
    LEFT JOIN Categories c ON c.Id=p.CategoryId
