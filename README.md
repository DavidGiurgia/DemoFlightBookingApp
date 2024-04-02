# Demo Flight Booking Application

**Description**

This application is an implementation of a flight booking platform, using a multi-panel (wizard) model for user navigation. 
It is intended to provide functionalities for both administrators and clients, allowing them to perform actions such as authentication, reservation, purchase, and management of flights.

**Technologies Used**

C#
.NET Framework (or .NET Core)
Windows Forms for the graphical interface
Data structures: Dictionaries, Enums
Design Patterns: State, Template Method

**Project Structure**

**Flight.Model**: Class library containing the core models of the application, including the implementation of State and Template Method patterns, data models, and necessary enums.

**Flight.DataAccess**: Access to the local database and CRUD operations. This module utilizes a repository pattern to abstract data access.

**Flight.UI**: User interface implemented using Windows Forms. All application functionalities are presented here, including navigating through panels and interacting with the user.

Please note that this project is not available for download as it relies on a local database server for functionality. The application is designed to interact with a database hosted on a local server, and it may not function properly without access to this database. Therefore, it is not suitable for standalone use or deployment without configuring the database connection to a local server. If you are interested in exploring the code or contributing to the project, feel free to browse the source code on GitHub. However, keep in mind that you will need to set up your own local database server to run the application effectively.

![Imagine Descriptivă](https://github.com/DavidGiurgia/DemoFlightBookingApp/blob/main/Images/Screenshot%202024-04-02%20231617.png?raw=true)
![Imagine Descriptivă](https://github.com/DavidGiurgia/DemoFlightBookingApp/blob/main/Images/Screenshot%202024-04-02%20231632.png?raw=true)
![Imagine Descriptivă](https://github.com/DavidGiurgia/DemoFlightBookingApp/blob/main/Images/Screenshot%202024-04-02%20231701.png?raw=true)
![Imagine Descriptivă](https://github.com/DavidGiurgia/DemoFlightBookingApp/blob/main/Images/Screenshot%202024-04-02%20231728.png?raw=true)

Author
*Giurgia David*

License
This project is licensed under the MIT License. See the LICENSE file for more information.
