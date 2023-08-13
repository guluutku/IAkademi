INSERT INTO Suppliers
    (CompanyName, ContactName, Address, City, Country)
VALUES
    (
        'ExmpName',
        'Gün',
        'Balçova',
        'İzmir',
        'Turkey'
)

update Suppliers set Address = 'Muğla' WHERE CompanyName = 'ExmpName'

DELETE FROM Suppliers WHERE CompanyName = 'ExmpName'

SELECT [SupplierID]
      , [CompanyName]
      , [ContactName]
      , [Address]
      , [City]
      , [Country]
FROM [NORTHWND].[dbo].[Suppliers]
WHERE CompanyName = 'ExmpName'