# webAPISocial
this is an API Rest project in dotnetcore framework database first

## Explanation
I had been working on .NET core 3.1 EF database-first to develop a webAPI CRUD. The architecture implemented was DDD with a pattern MVC, focusing to maintain SOLID principles. 
Until now, I did the functionalities for one of the tables get, get all and post. Once the app is launched the default loaded method is get all. The following is the endpoint
api/Post. The same endpoint is used to Post and api/Post/{id} is to select by id. All these endpoints were tested using Postman and the database software used was SQL Server 
Studio 18.

## Main lessons implemented and learned
-Dependency inyection
-Service containers
-DDD architecture
-API Rest
-Dto/Entities Autommaper
-Drawback about the use of entities to communicate with the ddbb instead of DTOs.
