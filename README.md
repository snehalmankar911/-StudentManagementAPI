
---

# 🚀 Student Management System – ASP.NET Core Web API

A secure and scalable **Student Management System API** built using **ASP.NET Core Web API**, **Entity Framework Core**, and **JWT Authentication**. This project follows a clean layered architecture and supports full CRUD operations.

---

## 📌 Project Overview

This API allows you to manage student data with secure endpoints. It includes authentication using JWT tokens and follows best practices for enterprise-level API development.

---

## ⚙️ Technologies Used

* ⚡ ASP.NET Core Web API
* 🗄️ Entity Framework Core
* 🧾 SQL Server
* 🔐 JWT Authentication
* 📘 Swagger (OpenAPI)
* 💻 C#

---

## 🏗️ Architecture

The project follows a clean layered architecture:

```
Controller Layer  → Handles HTTP Requests
Service Layer     → Business Logic
Repository Layer  → Data Access
Middleware        → Exception Handling
Database Layer    → EF Core + SQL Server
```

---

## 📊 Features

✅ Add Student
✅ Get All Students
✅ Update Student
✅ Delete Student
✅ JWT Authentication
✅ Global Exception Handling
✅ Swagger API Documentation

---

## 🔐 Authentication API

### 📌 Auth Endpoint

| Method | Endpoint         | Description   |
|--------|-----------------|--------------|
| POST   | /api/auth/login | Get JWT Token |

---

## 🔑 How Authentication Works

1. Call the login API:

POST /api/auth/login

2. You will receive a JWT token:

{
"token": "your_generated_jwt_token"
}

3. Use this token in headers:

Authorization: Bearer <your_token>

---
## 🔐 Authentication

This API uses **JWT (JSON Web Token)** for securing endpoints.

* All endpoints require authentication:

```csharp
[Authorize]
```

* You must pass a valid token in headers:

```
Authorization: Bearer <your_token>
```

---

## 📁 API Endpoints

### 📌 Students API

| Method | Endpoint           | Description      |
| ------ | ------------------ | ---------------- |
| GET    | /api/students      | Get all students |
| POST   | /api/students      | Add new student  |
| PUT    | /api/students/{id} | Update student   |
| DELETE | /api/students/{id} | Delete student   |

---

## 🧪 Sample Request

### ➤ Create Student

```json
POST /api/students

{
  "name": "John Doe",
  "age": 22,
  "course": "Computer Science"
}
```

---

## 🧰 Setup Instructions

### 1️⃣ Clone the repository

```bash
git clone https://github.com/snehalmankar911/-StudentManagementAPI.git
cd -StudentManagementAPI
```

### 2️⃣ Configure Database

Update `appsettings.json`:

```json
"ConnectionStrings": {
"DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3️⃣ Apply Migrations

```bash
dotnet ef database update
```

### 4️⃣ Run the Application

```bash
dotnet run
```

---

## 📘 Swagger UI

Once the application runs, open:

```
https://localhost:5109/swagger
```

You can test all APIs directly from Swagger.

---

## 📦 Project Structure

```
📁 Controllers
📁 Services
📁 Repositories
📁 Models
📁 Data
📁 Middleware
📄 Program.cs
📄 appsettings.json
```


