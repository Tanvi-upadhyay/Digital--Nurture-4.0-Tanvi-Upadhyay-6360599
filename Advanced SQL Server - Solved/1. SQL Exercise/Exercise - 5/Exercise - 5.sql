use tanvidb;
-- Step 1: Create a CTE that counts orders per customer
WITH CustomerOrderCounts AS (
    SELECT 
        CustomerID,
        COUNT(OrderID) AS OrderCount
    FROM Orders
    GROUP BY CustomerID
)

-- Step 2: Join with Customers and filter those with more than 3 orders
SELECT 
    c.CustomerID,
    c.Name,
    coc.OrderCount
FROM CustomerOrderCounts coc
JOIN Customers c ON c.CustomerID = coc.CustomerID
WHERE coc.OrderCount > 3;
