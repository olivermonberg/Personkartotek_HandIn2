--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
--
-- Create Table    : 'Address'   
-- AddressID       :  
-- CityID          :  (references City.CityID)
-- StreetName      :  
-- StreetNumber    :  
--
CREATE TABLE Address (
    AddressID      BIGINT IDENTITY(1,1) NOT NULL,
    CityID         BIGINT NOT NULL,
    StreetName     NVARCHAR(MAX) NOT NULL,
    StreetNumber   NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_Address PRIMARY KEY CLUSTERED (AddressID),
CONSTRAINT fk_Address FOREIGN KEY (CityID)
    REFERENCES City (CityID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)