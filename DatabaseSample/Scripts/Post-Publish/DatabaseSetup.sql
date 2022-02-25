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

IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'db_rw')
BEGIN

    CREATE LOGIN db_rw WITH PASSWORD = 'P4$$W0RD'

    CREATE USER db_rw FOR LOGIN db_rw

    ALTER ROLE db_owner ADD MEMBER db_rw

END

:r ".\AddTestData.sql"