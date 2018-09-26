--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- Name            :  
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- Name            :  
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- Name            :  
--
CREATE TABLE Person (
    PersonID       BIGINT IDENTITY(1,1) NOT NULL,
    AddressID      BIGINT NOT NULL,
    Name           VARCHAR NOT NULL,
CONSTRAINT pk_Person PRIMARY KEY CLUSTERED (PersonID),
CONSTRAINT fk_Person FOREIGN KEY (AddressID)
    REFERENCES Address (AddressID)
    ON DELETE CASCADE
    ON UPDATE CASCADE)