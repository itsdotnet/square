SELECT 
    T1.ProductName,
    COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM 
    Products T1
LEFT JOIN 
    ProductCategory T2 ON T1.ProductID = T2.ProductID
LEFT JOIN 
    Categories T3 ON T2.CategoryID = T3.CategoryID;
