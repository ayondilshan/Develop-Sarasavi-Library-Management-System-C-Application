# Develop-Sarasavi-Library-Management-System-C-Application

DIT2145 | SOFTWARE DEVELOPMENT PROJECT  


A modern desktop-based Library Management System developed using **C# Windows Forms** and **Microsoft SQL Server**. This project automates traditional library operations such as book management, user management, loans, returns, and reservations through a secure and user-friendly interface.

## 📚 Project Overview

The **Sarasavi Library Software Project** is designed to digitize and simplify library administration. The system provides a centralized platform for managing:

* Library members
* Book records
* Book copies
* Loan transactions
* Book reservations

The application includes a chalkboard-themed UI to create a modern academic experience while ensuring smooth and efficient functionality.

---

## 🚀 Features

### 🔐 Authentication System

* Secure login interface
* Admin access control

**Default Login Credentials**

```txt
Username: admin
Password: 12345
```

---

### 👥 User Management

* Add new users
* Edit user details
* Delete users
* View all registered users

---

### 📖 Book Management

* Add new book titles
* Edit book information
* Delete books
* Automatic generation of book copy records

---

### 🔍 Book Inquiry

Search books using:

* Book ID
* Book title
* Author name

---

### 📕 Loan Management

* Issue books to members
* Validate borrowing rules
* Limit members to 5 active loans

---

### 📗 Return Management

* Process returned books
* Update copy availability
* Handle reservation queue automatically

---

### 📘 Reservation System

* Reserve unavailable books
* Track reservation requests
* Manage reservation priorities

---

## 🛠 Technologies Used

| Category | Technology           |
| -------- | -------------------- |
| Frontend | C# Windows Forms     |
| Backend  | C# .NET              |
| Database | Microsoft SQL Server |
| IDE      | Visual Studio        |

---

## 🗄 Database Structure

The system uses a normalized relational database with the following tables:

* `Users`
* `Books`
* `Copies`
* `Loans`
* `Reservations`

---

## 📋 Business Rules

* Visitors cannot borrow or reserve books
* Reference books cannot be loaned
* Maximum 5 active loans per member

---

## 🖼 System Modules

* Login Form
* Library Home Dashboard
* User Operations
* Book Operations
* Book Inquiry
* Loan Books
* Return Books
* Reserve Books
* View Users

---


## 📂 Project Resources

### Google Drive

```txt
https://drive.google.com/drive/folders/1QGdxgi9AtV1PkPcQvfUhh24K9kipVyJQ
```

---

## ⚙️ Installation Guide

1. Clone the repository

```bash
git clone https://github.com/your-username/sarasavi-library-system.git
```

2. Open the project in **Visual Studio**

3. Restore SQL Server database

4. Configure the database connection string

5. Run the application

---

## 📌 Future Improvements

* Barcode scanning support
* Fine calculation system
* Email notifications
* Multi-user authentication
* Cloud database integration







