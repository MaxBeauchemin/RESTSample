/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT name FROM master.sys.server_principals WHERE name = 'db_rw')
BEGIN

    CREATE LOGIN db_rw_login WITH PASSWORD = 'P4$$W0RD'

END

IF NOT EXISTS (SELECT name FROM DatabaseSample.sys.database_principals WHERE name = 'db_rw_user')
BEGIN

    CREATE USER db_rw_user FOR LOGIN db_rw

    ALTER ROLE db_owner ADD MEMBER db_rw_user

END

:r ".\AddTestData.sql"