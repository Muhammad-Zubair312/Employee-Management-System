# Employee Management System

A Console-based Employee Management System built with C# and .NET 8.0, demonstrating a structured 3-Layer Architecture (Presentation, Business Logic, Data Access).

## 📋 Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Usage](#usage)

## 📖 Introduction
This application provides a simple yet effective interface for managing employee records and departments. It allows users to perform CRUD (Create, Read, Update, Delete) operations on employees and departments. Data is persisted to local text files, ensuring that records are saved between application sessions.

## ✨ Features

### Employee Management
- **List All Employees**: View a complete list of all registered employees.
- **Add New Employee**: Register a new employee with details like Name, ID, Dept, Salary, etc.
- **Update Employee**: Modify details of an existing employee.
- **Delete Employee**: Remove an employee record.
- **Search Functionality**:
    - Search by ID
    - Search by Name
    - Search by Department
    - Search by Joining Date

### Department Management
- Add, Update, and Remove Departments.

### Persistence
- **File-Based Storage**: All data is stored in `Employee.txt` and `Department.txt` files, making it easy to check data without valid database connections.

## 🏗 Architecture
The solution follows a clean **3-Layer Architecture**:
1.  **Presentation Layer (PL)**:
    -   Handles User Interface (Console Input/Output).
    -   Interacts with the Business Logic Layer.
2.  **Business Logic Layer (BLL)**:
    -   Contains validation rules and business logic.
    -   Acts as a bridge between PL and DAL.
3.  **Data Access Layer (DAL)**:
    -   Responsible for reading from and writing to text files (`Employee.txt`).
    -   Handles all file I/O operations.

## 🛠 Technologies
-   **Language**: C#
-   **Framework**: .NET 8.0
-   **Application Type**: Console Application

## 🚀 Getting Started

### Prerequisites
-   [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine.
-   An IDE like Visual Studio 2022 or VS Code.

### Installation
1.  **Clone the repository** (if you put this on GitHub):
    ```bash
    git clone https://github.com/your-username/Employee-Management-System.git
    ```
2.  **Navigate to the project directory**:
    ```bash
    cd "Employee Management System"
    ```
3.  **Build the project**:
    ```bash
    dotnet build
    ```

### Running the Application
To run the application, navigate to the Presentation Layer directory or run from the root:
```bash
dotnet run --project "Employee Management Presentation Layer/Employee Management Presentation Layer.csproj"
```

## 🎮 Usage
Once running, follow the on-screen menu:
```
1. List All Employees
2. Add New Employee
3. Update Employee Details
4. Delete Employee
5. Search Employees
6. Manage Departments
7. To Exit
```
Simply enter the number corresponding to your choice and press Enter.
