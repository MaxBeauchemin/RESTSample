## REST Sample

The intent of this project is to serve as a basic example of a REST Web API project with Controllers, a Database, and Unit Tests. It is also designed to act as a learning platform for anyone who is not familiar with the framework / concept of REST APIs

## Projects

- `DatabaseSample`
	- This project stores the SQL Table Definitions and the SQL Scripts necessary to build the database and populate it with test data
	- :file_folder:`Schema`
		- SQL scripts containing table definitions
	- :file_folder:`Scripts`
		- SQL scripts to add permissions / populate test data
- `DomainSample`
	- This project acts as the "Logic" layer between the Database and the Web APIs/Unit Tests
	- :file_folder:`DTOs`
		- Data Transfer Objects, which are classes used to represent data in transit between the Database and the APIs
	- :file_folder:`Enums`
		- Enum Objects, which are used to represent a predetermined list of values for a Type of data
	- :file_folder:`Models`
		- Entity Framework Models that represent the database tables
	- :file_folder:`Resources`
		- Helpful files and other general resources
	- :file_folder:`Services`
		- Logic classes that contain the necessary code to communicate between Database and the APIs
- `RESTSample`
	- This project houses the controllers, which act as the endpoints for integration, where you can perform [CRUD](https://developer.mozilla.org/en-US/docs/Glossary/CRUD) operations
	- :file_folder:`Controllers`
		- The API Routes that can be utilized to interact with the application
- `UnitTestSample`
	- This project contains tests that can be executed against the `DomainSample` project to make sure the logic is functioning as expected


## Recommended Development Tools

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
	- Make sure to install the following modules
		- ASP.NET and web development
		- .NET desktop development
		- Data storage and processing
- [SQL Server Express 2019](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
- [Postman](https://www.postman.com/)

## First Time Setup

1. Install IDE of your choice (Visual Studio Community Recommended)
2. Install SQL Server Express
	- Instance Name `localhost\SQLEXPRESS`
	- Mixed Authentication Mode
3. Clone repository to your computer
4. Publish the database by double-clicking the `DatabaseSample.publish.xml` file in Visual Studio and clicking **Publish**
5. Execute the Unit Tests to make sure the code can connect to the Database
6. Run the RESTSample project using the Web Browser of your choice to make sure the APIs are functional
7. (Optional) Import the `REST Sample.postman_collection.json` file into Postman to make sure you are able to easily interact with the Web APIs

## Project Diagram

![Diagram](https://user-images.githubusercontent.com/12040012/156093648-1647c451-481a-42ab-87ba-938f44d17252.png)
