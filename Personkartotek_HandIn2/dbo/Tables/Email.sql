--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
--
-- Create Table    : 'Email'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- EmailAddress    :  
--
CREATE TABLE Email (
    EmailID        BIGINT IDENTITY(1,1) NOT NULL,
    PersonID       BIGINT NOT NULL,
    EmailAddress   NVARCHAR(MAX) NOT NULL,
CONSTRAINT pk_Email PRIMARY KEY CLUSTERED (EmailID),
CONSTRAINT fk_Email FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)