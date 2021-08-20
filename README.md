# Epicodus Weekly Project | C# Api Project

##### Table of Contents
1. [Description](#description)
2. [Objectives](#objectives)
   - [Further Exploration Objectives](#further-exploration-objectives)
3. [Setting Up The Project](#setting-up-the-project)
   - [Setting Up The Database](#setting-up-the-database)
   - [Setting Up The Application](#setting-up-the-application)
4. [Using the API](#using-the-api)

## Description

This is the fourtheenth project in the Epicodus program. For this, I have chosen to make an animal shelter API.

- **Author**: Allister Moon Kays
- **Copyright**: MIT License

You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a project, take this opportunity to showcase your versatility for the project manager.

##### Building an API
For your final C#/.NET code review, you’ll build one of the three APIs below:

Animal Shelter: Create an API for a local animal shelter. The API will list the available cats and dogs at the shelter.
Local Business Lookup: Create an API for a local business lookup. The API will list restaurants and shops in town.
Parks Lookup: Create an API for state and national parks. The API will list state and national parks.
You have the freedom to build out your APIs as you wish. At the very least, your API should include the following:

Full CRUD functionality.
Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
Complete documentation of API endpoints and the further exploration you did.

## Objectives
- Application includes CRUD functionality and successfully returns responses to API calls.
- Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
- Application is well-documented, including specific documentation on further exploration and instructions on how to create the appsettings.json and set up the project.
- Build files and sensitive information is included in .gitignore file and is not to be tracked by Git
- Commit history clearly shows eight hours of work.
- The project meets previous objectives and follows best practices.

### Further Exploration
- Add a RANDOM endpoint that randomly returns a park/business/animal.
- Add a second custom endpoint that accepts parameters. Example: a SEARCH route that allows users to search by specific park names.

## Setting Up The Project
You are expected to have the following installed on your computer:

- A working bash terminal
- An instance of MySQL 8 or Docker
- .Net 5.0 or greater (https://dotnet.microsoft.com/download)
- Have the global tool `Entity Framework` installed

Before you can begin either set of setup instructions, you must do the following:
1. Download the files or clone the repository to your computer.

### Setting Up The Database
This assumes either an instance of MySQL 8 is installed, or you have Docker available on your computer

#### Using Docker
If you have Docker, then the set up will be quick and easy!

1. Ensure the Docker daemon is currently running on your computer
2. Close any instances of MySQL running
  - Or, change the ports used when running docker for this project. However, you'll be responsible for updating the DB configuration in that case.
3. Open a terminal instance in the root of this project
4. Run `docker compose up` to start the database.

#### Manual Database Setup

1. Ensure MySQL is installed and currently running

#### Setting up table/column data

1. If you do not have `Entity Framework` installed on your computer, open a terminal window and run the following command:
  - `dotnet tool install --global dotnet-ef`
2. Open a terminal window and go into the `Factory` folder in this repo.
3. Run `dotnet ef database update`

### Setting Up The Application

1. The one thing you'll need to do before starting the project is setting up the `appsettings.json` file.
2. Open a terminal window
3. Run `bash scripts/create-appsettings.sh`
  - This will create the necessary `appsettings.json` file with assumed default information, this is:
  - Username is `root`. If you wish to change this, append `-u your-user-name` to the command
  - Password is `epicodus`. If you wish to change this, append `-p your-password` to the command
    - alternatively for no password, append the `-P` flag to the command
  - DB Name is `allister_kays`. If you wish to change this, append `-d database_name` to the command. The database does not need to exist, and any existing data be wiped out when the command runs.
  - An example would be `bash scripts/initialize-db.sh -u otherroot -p mypassword -d mydatabase`.
4. Alternatively, you can fill in the `appsettings.json` file yourself. You can copy the `appsettings.example.json` and rename it, then fill in the values.
5. Now you are ready to run the app
  - To run the application, use `dotnet run` while in the `Factory` directory.
  - Then, open your browser and load the dev server address to see the app. The default address will be `http://localhost:5000`.

### Using the API

For convience, a Postman workspace has been saved which contains pre-built requests for all of the api routes. In addition, it will automatically handle things like saving the JWT for queries, as authentication is required for all user routes.

To use it, open Postman and in the workspace area select `import`. Then upload the file in this repo titled `Epicodus Project 14 - Allister Kays - C# API.postman_collection.json`.

#### Available endpoints:

-----

`GET /api/auth`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Returns:  
An instance of `UserViewModel` representing the user identified by the JWT.

-----

`POST /api/auth/register`

Required body:
- `username`: username for the new user
- `password`: password for the new user

Returns:  
An instance of `RegisterResultViewModel` representing the registration status and newly created user.

-----

`POST /api/auth/login`

Required body:
- `username`: username for the user
- `password`: password for the user

Returns:  
An instance of `LoginResultViewModel` representing the login status, user info (if successful), and JWT (if successful).

-----

`GET /api/animals`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Returns:  
A list of all Animals.

-----

`GET /api/animals/{id}`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Returns:  
A single animal, identified by the provided `{id}`.

-----

`GET /api/animals/random`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Returns:  
A single animal, selected randomly out of all animals in the database.

-----

`POST /api/animals`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Body fields (all optional):
- `Type`: the type of animal (i.e. cat or dog)
- `Breed`: the breed of the animal
- `Age`: how old the animal is (in years)
- `Name`: name of the animal
- `Description`: description of the animal

Returns:  
The newly created animal.

-----

`PUT /api/animals/{id}`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Body fields (all optional):
- `Type`: the type of animal (i.e. cat or dog)
- `Breed`: the breed of the animal
- `Age`: how old the animal is (in years)
- `Name`: name of the animal
- `Description`: description of the animal

Returns:  
The animal identified by the id, after updating based on provided body fields.

-----

`PATCH /api/animals/{id}`

Required headers:
- `Authorization`: `Bearer {jwt here}`

- Example body:
```
[
  {
    "value": 2,
    "path": "/age",
    "op": "replace"
  },
  {
    "value": "potato",
    "path": "/name",
    "op": "replace"
  }
]
```

An array is required, and can contain as many objects as desired. Each object maps to a field in Animal.
Fields in object:
- `value`: the new value for the field
- `path`: a path which represents the field in Animal (i.e. to update Description, put `/description`)
- `op`: which operation to use, by default put `replace` which replaces the field. For info on other operations, check out: http://jsonpatch.com/#operations

Returns:  
The animal identified by the id, after updating based on provided fields.

-----

`DELETE /api/animals/{id}`

Required headers:
- `Authorization`: `Bearer {jwt here}`

Returns:  
The animal identified by the id, after removing it from the database.
