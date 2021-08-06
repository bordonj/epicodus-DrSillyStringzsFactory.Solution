## Dr. SIllystringz's Factory

#### _Dr. SIllystringz's Factory- 08/06/21 - Code Review011_

#### By _**Jennifer Bordon**_
## Description
This is an MVC web application to help Dr. Sillystringz (not Pierre's friend?) keep track of their machine repairs. This MVC web app helps manage their engineers and machines they are licensed to fix. 

The factory manage is able to:
- add a list of engineers
- add a list of machines
- specify which engineers are licensed to repair which machines

There is a many-to-many relationship between `Engineer`s and `Machine`s.
- an engineer can be licensed to repair (belong to) many machines
- a machine can have many engineers licensed to repair it

## Technologies Used

* _C#_
* _MySQL_
* _MySQL Workbench_
* _.NET 5 SDK_
* _Git BASH_
* _ASP .NET CORE MVC_
* _Entity Framework Core

## Schema

![Screenshot](screenshot.png)
## Setup/Installation Requirements

1. Download or clone the https://github.com/bordonj/epicodus-DrSillyStringzsFactory.Solution to your local machine

2. Open terminal and navigate to the epicodus-DrSillyStringzsFactory.Solution of the directory

3. Run "dotnet restore" in the the `Factory` directory to install dependencies
`$ dotnet restore`

4. Create your own version of the database by importing the `jennifer_bordon.sql` file from the repo with MySQL Workbench.

5. Create an appsettings.json file in the `Factory` directory add the following code to the file:
```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database={first_last};uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to replace `{first_last}` `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}` with the appropriate terms.
- for `{first_last}`, this refers to the database or schema
  - make sure to replace this input with what you decide to name the schema/database
- for `{YOUR_USERNAME_NAME}` and `{YOUR_PASSWORD}`, this refers to your username and password for MySQL

- NOTE: _Do not include the curly brackets in your code snippet of appsettings.json_

6. In order to see the website in the browser, make sure you've navigated to the `Factory` diretory
  - run the code `$ dotnet run`
7. View the website by entering `localhost:5000/` in the url of your browser/client 

## Bugs

_No known bugs at this time. But if any found, please contact me so I can fix them._

## License

_MIT_

_Copyright (c) 2021 Jennifer Bordon_


## Contact Information

_jennifer.bordon@gmail.com_