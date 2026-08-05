# RFID Based Attendance Monitoring System

A desktop application developed using **C# Windows Forms**, **Dapper**, and **Microsoft SQL Server** for managing employee attendance through RFID technology. This project was developed as a freelance application to automate attendance tracking, employee management, shift scheduling, and attendance reporting.

---

## Overview

The RFID Based Attendance Monitoring System is a desktop application designed to automate employee attendance using RFID cards. It records employee time-in and time-out transactions, manages employee information, departments, positions, work schedules, holidays, and generates attendance reports. The system minimizes manual attendance processing while improving the accuracy and efficiency of attendance management.

---

## Features

- Attendance Management
- Employee Management
- Department Management
- Position Management
- Shift Schedule Management
- Holiday Management
- Attendance Reports
  - Daily Attendance
  - Monthly Attendance Summary per Employee
  - Department-wise Attendance Summary
  - List of Late and Absent Employees
  - 15-Day Cutoff Summary
- RFID Card Registration
- Data Validation

---

## Tech Stack

- Language: C#
- Framework: Windows Forms (.NET Framework)
- Database: Microsoft SQL Server
- Data Access: Dapper
- IDE: Visual Studio

---

## Project Structure

```text
RFIDBasedAttendanceMonitoringSystem/
├── Controllers/
├── Data/
├── Database/
│   └── RFIDBasedAttendanceMonitoringSystem.sql
├── Models/
├── Repositories/
├── Resources/
├── Shared/
├── Views/
├── App.config
└── Program.cs
```

---

## Getting Started

### Prerequisites

- Visual Studio 2022 (or later)
- .NET Framework 4.7.2 (or the version used by the project)
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)

---

## Installation

Clone the repository:

```bash
git clone https://github.com/kingdavidperalta/RFIDBasedAttendanceMonitoringSystem.git
```

Open the solution in **Visual Studio**.

---

## Database Setup

### 1. Create the Database

Open **SQL Server Management Studio (SSMS)** and execute the SQL script located at:

```text
Database/RFIDBasedAttendanceMonitoringSystem.sql
```

The script will automatically create the required database objects, including:

- Database
- Tables
- Views
- Indexes

---

### 2. Configure the Connection String

If your project does not already contain an **App.config** file:

1. Right-click the project.
2. Select **Add** → **New Item**.
3. Choose **Application Configuration File**.
4. Name it **App.config**.

Replace the contents with the following:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>

  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
  </startup>

  <connectionStrings>
    <add
      name="db_attendance"
      connectionString="Server=YOUR_SERVER;Database=db_attendance;Trusted_Connection=True;"
      providerName="System.Data.SqlClient" />
  </connectionStrings>

</configuration>
```

---

### 3. Update the Connection String

Locate the following line inside **App.config**:

```xml
connectionString="Server=YOUR_SERVER;Database=db_attendance;Trusted_Connection=True;"
```

Replace `YOUR_SERVER` with your SQL Server instance.

Example:

```text
DESKTOP-ABC123\SQLEXPRESS
```

or

```text
localhost
```

---

### 4. Restore NuGet Packages

In Visual Studio:

```
Tools
└── NuGet Package Manager
    └── Manage NuGet Packages for Solution
```

Restore or reinstall the required NuGet packages before building the project.

---

### 5. Run the Application

1. Build the solution.
2. Press **F5** to run the application.



## Developer

**King David B. Peralta**

Bachelor of Science in Information Technology

### Technologies Used

- C#
- Windows Forms (.NET Framework)
- Dapper
- Microsoft SQL Server
