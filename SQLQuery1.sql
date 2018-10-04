--SELECT * FROM City INNER JOIN Address ON City.CityID = Address.CityID

SELECT * FROM Person INNER JOIN Address ON Address.AddressID = Person.AddressID INNER JOIN City ON City.CityID = Address.CityID