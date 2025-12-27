# Student Management System – ASP.NET Core MVC

## 📌 Project Overview
Student Management System is a web-based CRUD application developed using **ASP.NET Core MVC** and **Entity Framework Core**.  
The system allows users to manage employee records efficiently with proper validation and a responsive user interface.

---

## 🚀 Features
- Add Employee
- Edit Employee Details
- Delete Employee
- View Employee List
- Server-side validation using Data Annotations
- Clean and responsive UI using Bootstrap

---

## 🛠️ Technologies Used
- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Razor Views
- Bootstrap
- LINQ

---

## 📂 Project Structure
```
StudentManagementSystem
│── Controllers
│ └── EmployeeController.cs
│── Models
│ └── Emp.cs
│── Views
│ └── Employee
│ ├── AddEmp.cshtml
│ ├── EditEmp.cshtml
│ └── getListOfData.cshtml
│── wwwroot
│── Program.cs
│── appsettings.json
│── StudentManagementSystem.sln
```
## 🧩 Employee Model
```csharp
public class Emp
{
    public int Id { get; set; }
    public string Ename { get; set; }
    public float Salary { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
}
```

▶️ How to Run the Project

Clone the repository

git clone https://github.com/SanskarGandhewar/StudentManagementSystem-ASP.NET-Core.git

Open the project in Visual Studio

Configure SQL Server connection in appsettings.json

Run the application using IIS Express

📸 Screenshots

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/c48de27c-1b47-4200-8741-8024aec93287" />

👨‍💻 Author

Sanskar Gandhewar
B.E. (ENTC) – 2025
ASP.NET Core | Java | SQL | Web Development

📄 License

This project is created for learning and academic purposes.
