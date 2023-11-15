SELECT Products.ProductID, Products.ProductDesc, COALESCE(SUM(OrderDetails.Quantity), 0) as quantity FROM Products
LEFT JOIN OrderDetails on Products.ProductID = OrderDetails.ProductID
GROUP BY Products.ProductID, Products.ProductDesc