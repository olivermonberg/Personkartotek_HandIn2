--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
--
-- Create Table    : 'Note'   
-- NoteID          :  
-- PersonID        :  (references Person.PersonID)
-- NoteText        :  
--
CREATE TABLE Note (
    NoteID         BIGINT IDENTITY(1,1) NOT NULL,
    PersonID       BIGINT NOT NULL,
    NoteText       VARCHAR NOT NULL,
CONSTRAINT pk_Note PRIMARY KEY CLUSTERED (NoteID),
CONSTRAINT fk_Note FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE CASCADE
    ON UPDATE CASCADE)