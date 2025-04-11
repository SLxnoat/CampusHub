# 🎓 CampusHub – University Management System

> A modern Windows Forms application built for efficient campus administration.  
> Developed by **H. M. C. M. Bandara** | Powered by **ArtXpert-Code**

---

## 📌 Overview

**CampusHub** is a C#-based front-end desktop application designed to streamline university operations. Built using Windows Forms, it provides a central dashboard for managing students, lecturers, faculties, assignments, attendance, and exam results — all while demonstrating key Object-Oriented Programming concepts.

> 💡 Note: This is a front-end only application. No database is used — data is handled via local controls and UI logic.

---

## 🧩 Features

- 🔐 **Login System** – Simple admin login with logout and exit functionality
- 🏠 **Admin Dashboard** – Central navigation panel with real-time clock and date
- 🎓 **Student Management** – Add, update, and delete student data
- 🏛️ **Faculty Management** – Manage faculty names and assign departments
- 👨‍🏫 **Lecturer Management** – Handle lecturer details and assigned courses
- 📎 **Assignment Upload** – Upload multiple DOC/PDF files to local storage
- 📅 **Attendance Module** – Simulate attendance tracking for students
- 📝 **Exam Results** – Record and display grades
- ⏰ **Live Clock & Date** – Real-time display on the dashboard
- 🖼️ **Modern UI** – Organized layout with branding and logo support

---

## 🧠 OOP Concepts Implemented

| Concept | Usage |
|--------|--------|
| **Encapsulation** | Separate classes for each module (e.g., Student, Assignment) |
| **Inheritance** | All forms inherit from the base `Form` class |
| **Polymorphism** | Event method overloading in buttons & forms |
| **Abstraction** | File handling and module logic hidden behind simple UIs |
| **Event-Driven Programming** | Actions driven by user events (clicks, timers) |
| **Reusability** | Shared navigation, message dialogs, and utilities across forms |

---

## 🖥️ Tech Stack

- Language: **C#**
- Framework: **.NET Windows Forms**
- IDE: **Visual Studio 2022**
- UI: **Custom-designed with yellow/black theme, white fonts**
- File Storage: `D:\Degree\OOP\Mini Project\file store` (for assignment files)

---
## 🧪 How to Run

1. Open `CampusHub.sln` in **Visual Studio**.
2. Build the project:  
   `Ctrl + Shift + B`
3. Run the application:  
   Press `F5` or click the green ▶️ "Start" button.
4. Login credentials:
   Username: admin
   Password: admin123
5. Once logged in, navigate through the dashboard to access all modules.

---

## 📝 Future Improvements

- 🔗 Add **database integration** for real-time data storage and retrieval
- 🧑‍💼 Implement **role-based login** (e.g., Admin, Lecturer, Student)
- 🛡️ Improve **form validations** and input verification
- 📤 Export **reports as PDF or Excel**
- 💬 Add **notifications/messages module**
- 🌐 Add **multi-language support**
- 🎨 Add **themes or UI customization options**

---

## 📁 Folder Structure

```bash
CampusHub/
├── Forms/
│   ├── Login.cs
│   ├── Dashboard.cs
│   ├── StudentMgt.cs
│   ├── FacultyMgt.cs
│   ├── LecturerMgt.cs
│   └── Assignment.cs
├── Assets/
│   └── Logo, Icons
├── bin/
├── obj/
└── Program.cs
