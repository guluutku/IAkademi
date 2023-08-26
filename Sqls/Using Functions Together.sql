select E.EmployeeID, E.FirstName, O.OrderDate, O.ShippedDate, DATEDIFF(DAY, OrderDate, ShippedDate) as FARK from Orders as O
inner join
Employees as E
on E.EmployeeID = O.EmployeeID