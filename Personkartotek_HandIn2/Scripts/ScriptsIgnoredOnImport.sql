﻿
--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 17:30
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 18:30
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 18:34
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 18:39
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 18:41
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 26 2018 18:41
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 27 2018 09:17
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 27 2018 09:58
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Sep 27 2018 13:44
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO

--
-- Target: Microsoft SQL Server 
-- Syntax: isql /Uuser /Ppassword /Sserver -i\path\filename.sql
-- Date  : Oct 04 2018 08:42
-- Script Generated by Database Design Studio 2.21.3 
--


--
-- Select Database: 'db_name'
--
USE db_name
GO

IF DB_NAME() = 'db_name'
    RAISERROR('''db_name'' DATABASE CONTEXT NOW IN USE.',1,1)
ELSE
    RAISERROR('ERROR IN BATCH FILE, ''USE db_name'' FAILED!  KILLING THE SPID NOW.',22,127) WITH LOG
GO

EXECUTE SP_DBOPTION 'db_name' ,'TRUNC. LOG ON CHKPT.' ,'TRUE'
GO

--
-- Permissions for: 'public'
--
GRANT ALL ON City TO public
GO

GRANT ALL ON PhoneCarrier TO public
GO

GRANT ALL ON Address TO public
GO

GRANT ALL ON Person TO public
GO

GRANT ALL ON AlternativeAddress TO public
GO

GRANT ALL ON Note TO public
GO

GRANT ALL ON PhoneNumber TO public
GO

GRANT ALL ON Email TO public
GO
