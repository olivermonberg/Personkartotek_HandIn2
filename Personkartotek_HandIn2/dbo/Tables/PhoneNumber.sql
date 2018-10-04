--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
--
-- Create Table    : 'PhoneNumber'   
-- PhoneNumberID   :  
-- PersonID        :  (references Person.PersonID)
-- PhoneCarrierID  :  (references PhoneCarrier.PhoneCarrierID)
-- Num             :  
--
CREATE TABLE PhoneNumber (
    PhoneNumberID  BIGINT IDENTITY(1,1) NOT NULL,
    PersonID       BIGINT NOT NULL,
    PhoneCarrierID BIGINT NOT NULL,
    Num            NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_PhoneNumber PRIMARY KEY CLUSTERED (PhoneNumberID),
CONSTRAINT fk_PhoneNumber FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
CONSTRAINT fk_PhoneNumber2 FOREIGN KEY (PhoneCarrierID)
    REFERENCES PhoneCarrier (PhoneCarrierID)
    ON DELETE CASCADE
    ON UPDATE CASCADE)