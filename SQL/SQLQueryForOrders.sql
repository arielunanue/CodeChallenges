SELECT CONCAT(C.FirstName, ' ', C.LastName) AS [full name], C.Age as [age], o.OrderID as [orderid], O.DateCreated as [datecreated],
	O.MethodofPurchase as [Purchase Method], OD.ProductNumber, OD.ProductOrigin FROM OrderDetails OD WITH(READPAST) 
	INNER JOIN Orders O WITH(READPAST) ON O.OrderID = OD.OrderID
	INNER JOIN Customers C WITH(READPAST) ON C.PersonID = O.PersonID
WHERE OD.ProductID = 1112222333 