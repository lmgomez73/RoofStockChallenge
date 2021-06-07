
# Welcome to RoofstockChallenge!
This is my solution to the challenge. I hope you like the code as much as I enjoyed coding it. This project divided in two parts. The backend and the front-end.
For the backend I used the latest version of .Net Core (.Net 5). It has a public Api REST called Property wich returns a list of properties. It uses Entity framework as ORM using code first approach and seeding to create the database and insert the seed data.
For the front end I use Angular 8, using Angular Material for the design.
It is a table filled by the call to the Property Api.
  
  

## Prerequisites

- Clone this repo

-  [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

-  [.NET SDK](https://dotnet.microsoft.com/download) (.NET 5 or higher)

-  [Node.js](https://nodejs.org/en/)

- Install Angular CLI using the following command:

```bash

npm i -g @angular/cli

```
- install EF Core cli using the following command:
```bash

dotnet  tool install --global dotnet-ef

```

## Configuring

  

Open **appsettings.json** inside **RoofstockChallenge** folder and set the **connection string**  *RoofStockDB* using your sql connection (not need to have a database created, just the server)

  

## Run the app

  

1. Open a command prompt inside the repo folder and run the following commands:

```bash

cd RoofstockChallenge

dotnet restore

dotnet  ef database update

dotnet run

```

This will run the backend web api service. It will set up the database using appsettings.json connectionString. It also will create and fill the tables using the [given data](https://samplerspubcontent.blob.core.windows.net/public/properties.json)

2. Open another command prompt inside the repo folder and run the following commands:

```bash
cd rooftock-challenge-client

npm install

ng serve -o

```

This will run client app