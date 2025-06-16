use tanvidb;
WITH CalendarCTE AS (
    SELECT CAST('2025-01-01' AS DATE) AS CalendarDate
    UNION ALL
    SELECT DATEADD(DAY, 1, CalendarDate)
    FROM CalendarCTE
    WHERE CalendarDate < '2025-01-31'
)
SELECT * FROM CalendarCTE
OPTION (MAXRECURSION 100);  -- Avoids infinite recursion
CREATE TABLE StagingProducts (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    UpdatedPrice DECIMAL(10, 2)
);
INSERT INTO StagingProducts (ProductID, ProductName, Category, UpdatedPrice) VALUES
(1, 'Laptop', 'Electronics', 1400.00),        -- Update existing product
(3, 'Headphones', 'Electronics', 320.00),     -- Update existing product
(5, 'Standing Desk', 'Furniture', 450.00);    -- New product
MERGE Products AS Target
USING StagingProducts AS Source
ON Target.ProductID = Source.ProductID
WHEN MATCHED THEN
    UPDATE SET
        Target.ProductName = Source.ProductName,
        Target.Category = Source.Category,
        Target.Price = Source.UpdatedPrice
WHEN NOT MATCHED THEN
    INSERT (ProductID, ProductName, Category, Price)
    VALUES (Source.ProductID, Source.ProductName, Source.Category, Source.UpdatedPrice);
SELECT * FROM Products;
