--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
-- Type            :  
--
--
-- Create Table    : 'AlternativeAddress'   
-- PersonID        :  (references Person.PersonID)
-- AddressID       :  (references Address.AddressID)
-- AlternativeAddressID :  
-- Type            :  
--
CREATE TABLE AlternativeAddress (
    PersonID       BIGINT NOT NULL,
    AddressID      BIGINT NOT NULL,
    AlternativeAddressID BIGINT IDENTITY(1,1) NOT NULL,
    Type           NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_AlternativeAddress PRIMARY KEY CLUSTERED (PersonID,AddressID,AlternativeAddressID),
CONSTRAINT fk_AlternativeAddress FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
CONSTRAINT fk_AlternativeAddress2 FOREIGN KEY (AddressID)
    REFERENCES Address (AddressID)
    ON DELETE CASCADE
    ON UPDATE CASCADE)