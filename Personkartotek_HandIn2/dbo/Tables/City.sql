﻿--
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
    PostalCode     NVARCHAR(MAX) NOT NULL,
    Country        NVARCHAR(MAX) NOT NULL,
    CityName       NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_City PRIMARY KEY CLUSTERED (CityID))