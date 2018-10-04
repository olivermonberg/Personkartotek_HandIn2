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
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- FirstName       :  
-- MiddleName      :  
-- LastName        :  
-- Nationality     :  
-- Gender          :  
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- FirstName       :  
-- LastName        :  
-- Nationality     :  
-- Gender          :  
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- FirstName       :  
-- LastName        :  
-- Nationality     :  
-- Gender          :  
--
--
-- Create Table    : 'Person'   
-- PersonID        :  
-- AddressID       :  (references Address.AddressID)
-- FirstName       :  
-- LastName        :  
-- Nationality     :  
-- Gender          :  
--
CREATE TABLE Person (
    PersonID       BIGINT IDENTITY(1,1) NOT NULL,
    AddressID      BIGINT NOT NULL,
    FirstName      NVARCHAR(MAX) NOT NULL,
    LastName       NVARCHAR(MAX) NOT NULL,
    Nationality    NVARCHAR(MAX) NOT NULL,
    Gender         NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_Person PRIMARY KEY CLUSTERED (PersonID),
CONSTRAINT fk_Person FOREIGN KEY (AddressID)
    REFERENCES Address (AddressID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)