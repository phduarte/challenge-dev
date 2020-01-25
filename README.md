# Using Google GeoCoding Api

## Overview
Api for drivers and cars management.

[![Build status](https://ci.appveyor.com/api/projects/status/gcu4ps8oflyfbf6f?svg=true)](https://ci.appveyor.com/project/phduarte/challenge-dev) [![BCH compliance](https://bettercodehub.com/edge/badge/phduarte/challenge-dev?branch=master)](https://bettercodehub.com/)

This application is a study case purpose only. It uses .Net Core 2.1, .Net Standard and .Net Framework 4.7. The database is stored in memory, in other words, it is volatile. The information will not be saved when the server restarts.

The architecture uses the guidance of Domain-Driven Design principles focused on DomainModel, Entity, Value Objects and Ubiquitous Language.

Many others design patterns was used throught the piece of codes, but without overengeneering. I tried to make it explict the using of SOLID principle, very often in DomainModel and Infrastructure layers. But is not hard to see a lot of implicit uses int the solution.

I tried to write a code simple, readable and elegant. Using code metrics keeping it low coupling and low cyclomatic complexity.

## Hands on

1. Opens the solution using Visual Studio 2017+
2. On Visual Studio, clique em Build / Clean Solution.
3. Set WappaMobile.ChallengeDev.WebApi as Startup (right click on the project then Set as Startup Project)
4. Inside the WappaMobile.ChallengeDev.GoogleMaps project, set the constant API_KEY in Settings class for the Api key provided by Google.
5. Run the Solution (F5).
6. Use the swagger documentation to try the app (access /swagger/index.html).

## End Points

### POST /api/drivers
Adds drivers in database.

Body (application/json)
```json
{
	"name":
	{
		"firstname": "",
		"lastname": ""
	},
	"car":
	{
		"brand":"",
		"model":"",
		"plate": ""
	},
	"address":
	{
		"suffix": "R",
		"street": "",
		"number": "",
		"district": "",
		"city": "",
		"state": "",
		"zipcode": ""
	}
}
```

### PUT /api/drivers/{id}
Update existing driver informations through its ID.

Body (application/json)
```json
{
	"name":
	{
		"firstname": "",
		"lastname": ""
	},
	"car":
	{
		"brand":"",
		"model":"",
		"plate": ""
	},
	"address":
	{
		"suffix": "R",
		"street": "",
		"number": "",
		"district": "",
		"city": "",
		"state": "",
		"zipcode": ""
	}
}
```

### GET /api/drivers
Lists all drivers stored in database.

### GET /api/drivers?orderby={campo}
Lists all drivers sorted ascending.

<table>
<tr>
<th>Parameter</th>
<th>Description</th>
<th>Expected values</th>
</tr>

<tr>
<td>orderby</td>
<td>Set the criteria for sort.</td>
<td>firstname / lastname</td>
</tr>
</table>

### DELETE /api/drivers/{id}
Removes a driver from database through its ID.
