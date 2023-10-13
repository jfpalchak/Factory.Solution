# _Dr. Sillystringz's Factory_

#### By _Joey Palchak_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

{DESCRIPTION}

## Setup/Installation Requirements

### Install Tools
This project assumes you have MySQL Server and MySQL Workbench installed on your system. _If you do not have these tools installed_, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

For Entity Framework Core, we'll use a tool called `dotnet-ef` to reference the project's migrations and update our database accordingly. To install this tool globally, run the following command in your terminal:

```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

Optionally, you can run the following command to verify that EF Core CLI tools are correctly installed:

```
$ dotnet ef
```

### Install and Run the Project

Assuming you've completed the required steps above:

1. Copy the **[URL](#REPO LINK)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone [URL]
```
5. Open your terminal and navigate to this project's production directory called `Factory`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]`, and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
8. With `appsettings.json` properly configured, in the command line, run the following command to reference the project's migrations and re-create the application's database:
9. 
   ```
   $ dotnet ef database update
   ```
10. Then, in the command line, run the following command to compile and run the web application in development mode with a watcher:
   
```bash
$ dotnet watch run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

11. Open your browser to https://localhost:5001 to navigate and use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.

## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _10/13/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.