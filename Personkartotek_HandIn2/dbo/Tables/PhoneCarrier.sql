--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
--
-- Create Table    : 'PhoneCarrier'   
-- PhoneCarrierID  :  
-- CompanyName     :  
--
CREATE TABLE PhoneCarrier (
    PhoneCarrierID BIGINT IDENTITY(1,1) NOT NULL,
    CompanyName    VARCHAR NOT NULL,
CONSTRAINT pk_PhoneCarrier PRIMARY KEY CLUSTERED (PhoneCarrierID))