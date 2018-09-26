--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
--
-- Create Table    : 'City'   
-- CityID          :  
-- PostalCode      :  
-- Country         :  
-- CityName        :  
--
CREATE TABLE City (
    CityID         BIGINT IDENTITY(1,1) NOT NULL,
    PostalCode     VARCHAR NOT NULL,
    Country        VARCHAR NOT NULL,
    CityName       VARCHAR NOT NULL,
CONSTRAINT pk_City PRIMARY KEY CLUSTERED (CityID))