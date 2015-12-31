##To Do List with Categories

###Description
This app uses a pseudo code-first approach with Entity Framework and allows the user to create a to do list with categories. This is done with foreign key relationships between tables in the database.

###Use
This app connects to (localdb)\mssqllocaldb server to a database with the name ToDoRelationships. 

Create an Item and Category table.

The Item table will have three columns:

- ItemId: data type _int_, set primary key, set as identity column
- Description: data type nvarchar(50), deselect _Allow Nulls_
- CategoryId: data type int, deselect _Allow Nulls_

The Category table will have two columns:

- CategoryId: data type _int_, set primary key, set as identity column
- Name: data type nvarchar(50), deselect _Allow Nulls_

Create a one-to-many relationship between Item and Category.

####Technologies used
ASP.NET 5, MVC 6, Entity Framework 6