--SELECT * FROM City INNER JOIN Address ON City.CityID = Address.CityID

--SELECT * FROM Person INNER JOIN Address ON Address.AddressID = Person.AddressID INNER JOIN City ON City.CityID = Address.CityID



SELECT * FROM AlternativeAddress INNER JOIN Address ON Address.AddressID = AlternativeAddress.AddressID 
INNER JOIN City ON City.CityID = Address.CityID Inner join Person on Person.PersonID = AlternativeAddress.PersonID WHERE PersonID = 15
--Inner join Person on Person.PersonID = AlternativeAddress.PersonID
--INNER JOIN Address ON Address.AddressID = AlternativeAddress.AddressID --WHERE (Person.PersonID = 11)