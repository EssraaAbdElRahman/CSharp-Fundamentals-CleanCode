# C# Fundamentals – Clean Code & OOP Practice

A structured C# console-based project designed to demonstrate **clean architecture thinking**, **OOP principles**, and **scalable code organization** through a task-based system.

---

## 🎯 Project Goal

This project goes beyond solving simple programming exercises.

It focuses on how to:

* Design maintainable software systems
* Apply proper separation of concerns
* Use object-oriented design in real-world scenarios
* Build a strong foundation for backend development thinking

The main idea is evolving from **basic procedural code → structured software design mindset**.

---

## 🧠 Key Concepts Covered

### 🔹 C# Fundamentals

* Conditionals and control flow
* Loops and iteration
* Basic algorithmic problem solving

### 🔹 Object-Oriented Programming (OOP)

* Classes and objects
* Interfaces and abstraction
* Abstract classes and Template Method Pattern
* Constructor-based dependency injection (manual)
* Encapsulation and responsibility separation

### 🔹 Clean Code Principles

* Meaningful naming conventions
* Small, focused classes
* Separation of concerns
* Reusable components
* Avoiding duplication

### 🔹 Architecture Concepts (Lightweight)

* Task-based modular system
* Factory pattern (registry-based design)
* Centralized composition root
* Decoupling UI from business logic
* Scalable project structure design

---

## 🏗️ Architecture Overview

The system is designed around a **Task Execution Engine**:

User Input
↓
Menu System (Presentation Layer)
↓
TaskFactory (Application Layer)
↓
TaskRegistry (Configuration Source)
↓
ITask Implementation (Business Logic)
↓
Execution Result

---

## 🧩 Design Patterns Used

### ✅ Factory Pattern

Used to dynamically create task instances without coupling the UI to concrete implementations.

### ✅ Registry Pattern

Centralized registration of all available tasks in a single source of truth.

### ✅ Composition Root

All dependencies are wired in Program.cs, keeping object creation centralized and controlled.

---

## 📂 Project Structure

```
CSharp-Fundamentals-CleanCode
│
├── Core
│   ├── Abstractions
│   │   ├── ITask.cs
|   |   └── BaseTask.cs
│   └── Enums
│       └── MenuOption.cs
│
├── Application
│   ├── Factories
│   │   ├── ITaskFactory.cs
│   │   └── TaskFactory.cs
│   ├── TaskManagement
│   │   ├── TaskDefinition.cs
│   │   └── TaskRegistry.cs
│   └── Tasks
│       ├── Basics
│       ├── Loops
│       ├── Arrays
│       └── Strings
│
├── Infrastructure
│   └── Services
│       ├── InputService.cs
│       └── OutputService.cs
│
└── Presentation
    └── ConsoleUI
        ├── Menu
        │   └── MenuRenderer.cs
        └── Program.cs
```

## ⚙️ How It Works

1. The user selects an option from the console menu
2. The selection is mapped to a registered task via TaskFactory
3. The TaskFactory resolves the corresponding task from the registry
4. The task is executed through the ITask interface
5. Input and Output are handled via infrastructure services

---

## 🚀 Why This Project Matters

This project simulates how real backend systems are structured at a small scale:

* Decoupled components
* Scalable task registration system
* Clean separation between UI and business logic
* Extensible architecture ready for future enhancements

It is designed as a learning foundation for backend development in .NET.

---

## 📌 Future Improvements (Planned)

* Lightweight Dependency Injection container
* Reflection-based auto task registration
* Logging system integration
* Unit testing layer
* Migration toward ASP.NET Core architecture

---

## 🧑‍💻 Author Notes

This project is part of a personal learning journey focused on mastering:

* Software design principles
* Clean architecture thinking
* Backend development fundamentals in C#

It is continuously evolving as new concepts are learned and applied.

## 🔄 Upcoming Tasks

This project is continuously evolving with additional practice tasks covering:
- Loops & Iteration patterns
- Array manipulation
- String processing
- Number theory problems

> ⭐ Star this repo to follow the progress!
