# .Net Core Web API

## Simple RESTful Web API to explain the basics concepts


### Examples:
** Some examples: GET, POST, PUT and DELETE **

```
[GET] https://localhost:5001/api/candidates/getall (returns all candidates)
[GET] https://localhost:5001/api/candidates/get/1 (return candidate where id=1)
[POST] https://localhost:5001/api/candidates/Add (add new candidate)

body content JSON:
{
	"id":1,
	"Name":"Henrique ",
	"Age":30,
	"Salary": 1200
}

[PUT] https://localhost:5001/api/candidates/update (update candidate where's values in "id" tag's) with JSON data below:

body content JSON:
{
	"id":1,
	"Name":"Henrique Mello",
	"Age":30,
	"Salary": 1400
}


[DELETE] https://localhost:5001/api/candidates/delete/2 (delete candidate ==2)

```

### How to run

You will need .net core <= 2.1 installed.

Open your terminal/command prompt

```
dotnet build
dotnet run

```
