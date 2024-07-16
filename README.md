# SchoolManagementUI

## Overview

This project is a Razor Pages application designed to serve as the UI for managing basic school systems, including controlling students, specialties, and grades. It provides options to create, edit, and delete each entity. The IDE used is Visual Studio 2022 with the technology .NET 6, and the programming language used is C#. For fronted, HTML/CSS is used. For the database context, SQL language is used directly in the project. This repository contains the source code and resources required to deploy and run the application.

## Directory Structure

The project is structured as follows:

```
ProjectAAS/
├── App_Start/
├── Content/
├── Properties/
├── Scripts/
├── .gitattributes
├── .gitignore
├── About.aspx
├── About.aspx.cs
├── About.aspx.designer.cs
├── Bundle.config
├── Configurator.cs
├── Contact.aspx
├── Contact.aspx.cs
├── Contact.aspx.designer.cs
├── DBManipulator.cs
├── Default.aspx
├── Default.aspx.cs
├── Default.aspx.designer.cs
├── Site.Master
├── Site.Master.cs
├── Site.Master.designer.cs
├── Site.Mobile.Master
├── Site.Mobile.Master.cs
├── Site.Mobile.Master.designer.cs
├── Specialties.aspx
├── Specialties.aspx.cs
├── Specialties.aspx.designer.cs
├── Specialty.cs
├── SpecialtyInfo.aspx
├── SpecialtyInfo.aspx.cs
├── SpecialtyInfo.aspx.designer.cs
├── Student.cs
├── StudentInfo.aspx
├── StudentInfo.aspx.cs
├── StudentInfo.aspx.designer.cs
├── Students.aspx
├── Students.aspx.cs
├── Students.aspx.designer.cs
├── Subject.cs
├── SubjectInfo.aspx
├── SubjectInfo.aspx.cs
├── SubjectInfo.aspx.designer.cs
├── Subjects.aspx
├── Subjects.aspx.cs
├── Subjects.aspx.designer.cs
├── ViewSwitcher.ascx
├── ViewSwitcher.ascx.cs
├── ViewSwitcher.ascx.designer.cs
├── Web.Debug.config
├── Web.Release.config
├── Web.config
├── favicon.ico
└── packages.config
```


### Key Directories and Files

- **App_Start/**: Contains application startup configurations.
- **Content/**: Contains CSS and other content files.
- **Properties/**: Contains project properties and settings.
- **Scripts/**: Contains JavaScript files.
- **About.aspx**: Razor Page for the About section.
- **About.aspx.cs**: Code-behind file for About.aspx.
- **About.aspx.designer.cs**: Designer file for About.aspx.
- **Configurator.cs**: Configuration helper class.
- **Contact.aspx**: Razor Page for the Contact section.
- **Contact.aspx.cs**: Code-behind file for Contact.aspx.
- **Contact.aspx.designer.cs**: Designer file for Contact.aspx.
- **DBManipulator.cs**: Database manipulation class.
- **Default.aspx**: Razor Page for the default landing page.
- **Default.aspx.cs**: Code-behind file for Default.aspx.
- **Default.aspx.designer.cs**: Designer file for Default.aspx.
- **Site.Master**: Master page for the application.
- **Site.Master.cs**: Code-behind file for Site.Master.
- **Site.Master.designer.cs**: Designer file for Site.Master.
- **Site.Mobile.Master**: Mobile master page for the application.
- **Site.Mobile.Master.cs**: Code-behind file for Site.Mobile.Master.
- **Site.Mobile.Master.designer.cs**: Designer file for Site.Mobile.Master.
- **Specialties.aspx**: Razor Page for managing specialties.
- **Specialties.aspx.cs**: Code-behind file for Specialties.aspx.
- **Specialties.aspx.designer.cs**: Designer file for Specialties.aspx.
- **Specialty.cs**: Class file for Specialty entity.
- **SpecialtyInfo.aspx**: Razor Page for viewing specialty information.
- **SpecialtyInfo.aspx.cs**: Code-behind file for SpecialtyInfo.aspx.
- **SpecialtyInfo.aspx.designer.cs**: Designer file for SpecialtyInfo.aspx.
- **Student.cs**: Class file for Student entity.
- **StudentInfo.aspx**: Razor Page for viewing student information.
- **StudentInfo.aspx.cs**: Code-behind file for StudentInfo.aspx.
- **StudentInfo.aspx.designer.cs**: Designer file for StudentInfo.aspx.
- **Students.aspx**: Razor Page for managing students.
- **Students.aspx.cs**: Code-behind file for Students.aspx.
- **Students.aspx.designer.cs**: Designer file for Students.aspx.
- **Subject.cs**: Class file for Subject entity.
- **SubjectInfo.aspx**: Razor Page for viewing subject information.
- **SubjectInfo.aspx.cs**: Code-behind file for SubjectInfo.aspx.
- **SubjectInfo.aspx.designer.cs**: Designer file for SubjectInfo.aspx.
- **Subjects.aspx**: Razor Page for managing subjects.
- **Subjects.aspx.cs**: Code-behind file for Subjects.aspx.
- **Subjects.aspx.designer.cs**: Designer file for Subjects.aspx.
- **ViewSwitcher.ascx**: User control for switching views.
- **ViewSwitcher.ascx.cs**: Code-behind file for ViewSwitcher.ascx.
- **ViewSwitcher.ascx.designer.cs**: Designer file for ViewSwitcher.ascx.
- **Web.Debug.config**: Debug configuration file.
- **Web.Release.config**: Release configuration file.
- **Web.config**: Main configuration file for the application.
- **favicon.ico**: Favicon for the website.
- **packages.config**: NuGet packages configuration file.

## Prerequisites

- Visual Studio with ASP.NET and Web Development workload installed
- .NET Framework 4.7.2 or later

## Setup and Installation

1. **Clone the repository:**
    ```sh
    git clone https://github.com/siyana-m/SchoolManagementUI.git
    cd ProjectAAS
    ```

2. **Open the solution in Visual Studio:**
    - Open `ProjectAAS.sln` in Visual Studio.

3. **Build the project:**
    - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

4. **Run the application:**
    - Press `F5` or go to `Debug` > `Start Debugging`.

## Database Setup

## Database Setup

1. **Create a new database in SQL Server Management Studio (SSMS):**
    - Open SSMS and connect to your SQL Server instance.
    - Right-click on the `Databases` folder and select `New Database`.
    - Name the database `SchoolManagementDB` and click `OK`.

2. **Run the provided SQL script:**
    - Open a new query window in SSMS.
    - Copy the contents of the `schoolmanagement_db.txt` file into the query window.
    - Execute the script to create the necessary tables, triggers, and seed data.

    If you log into SSMS with a username and password:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SchoolManagementDB;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
    }
    ```

    If you log into SSMS directly with the server (Windows Authentication):
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=SchoolManagementDB;Trusted_Connection=True;"
    }
    ```


## Running Tests

To run any tests for the application (if applicable), use Visual Studio's built-in testing tools.

## Contributing

Contributions are welcome! Please create an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For any questions or feedback, please contact siskataam32@gmail.com.

## Notes

The project is still under development. There may be issues. In case of finding one, please contact siskataam32@gmail.com.
