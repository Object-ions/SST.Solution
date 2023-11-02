# _Pierre's Sweet and Savory Treats Management System_

#### By _**Moshe Atia**_

#### _This web application designed for Pierre to showcase his collection of delightful treats. The application emphasizes user experience, complete with a robust authentication system and a many-to-many relationship between treats and flavors._

## Technologies Used

- _C#_
- _HTML_
- _CSS_
- _.Net 6.0_
- _ASP.NET Core MVC 6.0_
- _Entity Framework Core_

## Features

- **User Authentication**: Allows users to register, log in, and log out.
- **CRUD Functionalities**: Create, Read, Update, and Delete functionalities are exclusively accessible for authenticated users.
- **Many-to-Many Relationships**: A relationship exists between Treats and Flavors, where a treat can have various flavors and vice versa.
- **Interactive UI**: Features a splash page that lists all treats and flavors, and allows users to view all treats/flavors associated with a particular treat or flavor.

## Setup/Installation Requirements

Installing/Configuring MySQL:

1. Follow the instructions on this <a href="https://old.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL.

Installing dotnet-ef:

1. Run the following command to globally install dotnet-ef tools which will allow you to create migrations and create databases:
   `$ dotnet tool install --global dotnet-ef --version 6.0.0`

Cloning the Repo:

1. Open Terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:  
   `$ git clone https://github.com/Object-ions/SST.Solution.git`
4. Using the terminal, navigate to the production directory: "SST" and create a new file called appsettings.json
5. Within appsettings.json, put in the following code while also replacing the following values with your own values as shown below the code snippet:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- [YOUR-USERNAME-HERE] with your username
- [YOUR-PASSWORD-HERE] with your password
- [YOUR-DB-NAME] with the name of your database

Running the program:

1. Navigate to the project's production directory "SST" using the terminal.
2. Run the following command to update the database:  
   `$ dotnet ef database update`
3. Within the command line, run the command `$ dotnet watch run` to compile and execute the console application in developer mode.

## Available Routes

### Without Authentication:

- **Home/Splash Page:**
  - `/`
    - Lists all treats and flavors.
- **Treats:**
  - View all treats: `/treats`
  - View specific treat details: `/treats/{treatId}`
- **Flavors:**
  - View all flavors: `/flavors`
  - View specific flavor details: `/flavors/{flavorId}`

### With Authentication:

(All the above routes plus the following)

- **Treats:**
  - Add a new treat: `/treats/add`
  - Edit a treat: `/treats/{treatId}/edit`
  - Delete a treat: `/treats/{treatId}/delete`
  - Add a flavor to a treat: `/treats/{treatId}/addflavor`
- **Flavors:**

  - Add a new flavor: `/flavors/add`
  - Edit a flavor: `/flavors/{flavorId}/edit`
  - Delete a flavor: `/flavors/{flavorId}/delete`
  - View treats with a specific flavor: `/flavors/{flavorId}/treats`

- **User Authentication:**
  - Register a new account: `/register`
  - Log in: `/login`
  - Log out: `/logout`

## Known Bugs

- No bugs known

## License

MIT License

Copyright (c) 2023 Moshe Atia

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
