# 🔐 JWT Login Register API

A secure and scalable **Authentication REST API** built using **ASP.NET Core Web API (.NET 10)** with **JWT Authentication**, **BCrypt Password Hashing**, **Entity Framework Core**, and **SQL Server**.

---

## 🚀 Features

- 🔐 User Registration
- 🔑 User Login
- 🔒 Password Hashing using BCrypt
- 🎟️ JWT Token Generation
- 🛡️ Protected APIs using JWT Authentication
- 🗄️ SQL Server Database
- ⚡ Entity Framework Core
- 📖 Swagger API Documentation
- 🧩 Clean Architecture with DTOs & Services

---

## 🛠️ Tech Stack

| Technology | Used |
|------------|------|
| ASP.NET Core Web API | ✅ |
| C# | ✅ |
| SQL Server | ✅ |
| Entity Framework Core | ✅ |
| JWT Authentication | ✅ |
| BCrypt | ✅ |
| Swagger | ✅ |

---

## 📂 Project Structure

```text
JWT-Login-Register-API
│
├── Controllers
│   └── AuthController.cs
│
├── Models
│   └── User.cs
│
├── DTOs
│   ├── RegisterDto.cs
│   └── LoginDto.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Services
│   └── JwtService.cs
│
├── Migrations
├── Program.cs
├── appsettings.json
└── README.md
```

---

## 📌 API Endpoints

### 👤 Register User

```http
POST /api/Auth/register
```

Request

```json
{
  "name": "Jahnvi",
  "email": "jahnvi@gmail.com",
  "password": "123456"
}
```

---

### 🔑 Login User

```http
POST /api/Auth/login
```

Request

```json
{
  "email": "jahnvi@gmail.com",
  "password": "123456"
}
```

Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIs..."
}
```

---

### 🛡️ Protected Profile API

```http
GET /api/Auth/profile
```

Requires:

```text
Authorization: Bearer <JWT_TOKEN>
```

---

## 🔄 Authentication Flow

```text
User Registers
        │
        ▼
Password Hashed using BCrypt
        │
        ▼
Stored in SQL Server
        │
        ▼
User Logs In
        │
        ▼
JWT Token Generated
        │
        ▼
Token Sent in Authorization Header
        │
        ▼
Protected API Access
```

---

## ▶️ Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/JWT-Login-Register-API.git
```

### 2️⃣ Navigate to the Project

```bash
cd JWT-Login-Register-API
```

### 3️⃣ Restore Packages

```bash
dotnet restore
```

### 4️⃣ Update Connection String

Update the SQL Server connection string inside **appsettings.json**.

### 5️⃣ Apply Migrations

```bash
dotnet ef database update
```

### 6️⃣ Run the Project

```bash
dotnet run
```

Open Swagger:

```
http://localhost:5134/swagger
```

---

## 🎯 Learning Outcomes

This project demonstrates:

- ASP.NET Core Web API Development
- RESTful API Design
- JWT Authentication
- Password Hashing with BCrypt
- Entity Framework Core
- SQL Server Integration
- Dependency Injection
- DTO Pattern
- Authentication Middleware
- Protected Routes using `[Authorize]`

---

## 🌟 Future Enhancements

- 👥 Role-Based Authentication
- 🔄 Refresh Tokens
- 📧 Email Verification
- 🔑 Forgot Password
- 🖼️ Profile Picture Upload
- 📜 Logging & Exception Handling

---

## 👩‍💻 Author

**Jahnvi Srivastava**

If you found this project helpful, don't forget to ⭐ the repository!
