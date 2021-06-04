# Welcome to RoofstockChallenge!


## Prerequisites
  - Clone this repo 
  - [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
 -  [.NET SDK](https://dotnet.microsoft.com/download) (.NET 5 or higher)
  -  [Node.js](https://nodejs.org/en/)
   - Install Angular CLI by running the following command: 
	   ```bash
	  npm i -g @angular/cli
	  ```
	
  
## Configuring

Open **appsettings.json** inside **RoofstockChallenge** folder and set the **connection string** *RoofStockDB* using your sql connection (not need to have a database created, just the server)

## Run the app

 1. Open a command prompt inside the repo folder and run the following commands: 
 ```bash
	  cd RoofstockChallenge
	  dotnet restore
	  dotnet run
```
This will run the backend web api service. It will set up the database using appsettings.json connectionString. It also will create and fill the tables using the [given data](https://samplerspubcontent.blob.core.windows.net/public/properties.json) 
2. Open another command prompt inside the repo folder and run the following commands: 
 ```bash
	  npm install
	  ng serve -o
```
This will run client app

