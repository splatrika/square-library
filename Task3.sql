SELECT p.Name ProductName, c.Name CategoryName FROM dbo.Products p
LEFT JOIN dbo.ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN dbo.Categories c ON pc.CategoryId = pc.CategoryId;
