
# 🔍 Simple Reflection Project

A practical **C# Windows Forms application** built to explore and demonstrate the power of **.NET Reflection**.

The application allows you to load an external `.dll` assembly, inspect its classes, explore methods and properties, dynamically generate input controls for method parameters, and execute selected members at runtime.

> **Built as a practical learning project to understand how Reflection can be used to inspect and interact with .NET types dynamically.**

---

## ✨ Features

* 📦 Load external `.dll` assemblies dynamically.
* 🔎 Discover and display classes contained in an assembly.
* 🧩 Explore class members using Reflection.
* ⚙️ Display available **Methods** and **Properties**.
* 📋 View method parameters, parameter types, and optional parameters.
* 🏷️ Display selected member information.
* 🧠 Automatically generate input controls based on parameter types.
* ▶️ Execute methods dynamically using `MethodInfo.Invoke()`.
* 🏗️ Create class instances dynamically using `Activator.CreateInstance()`.
* 🔧 Assign values to writable properties dynamically.
* 👀 Read and display property values from returned objects.
* 📊 Display returned `DataTable` objects using a `DataGridView`.
* 🚫 Detect read-only properties and prevent assigning values to them.

---

## 🛠️ Technologies Used

| Technology               | Usage                              |
| ------------------------ | ---------------------------------- |
| **C#**                   | Main programming language          |
| **.NET Framework 4.7.2** | Application framework              |
| **Windows Forms**        | Desktop UI                         |
| **System.Reflection**    | Runtime type and member inspection |
| **MethodInfo**           | Dynamic method invocation          |
| **PropertyInfo**         | Dynamic property access            |
| **Activator**            | Runtime object creation            |
| **DataTable**            | Tabular result handling            |
| **Guna UI2**             | UI components                      |
| **FontAwesome.Sharp**    | Icons                              |

---

## 🧠 Reflection Concepts Demonstrated

This project focuses on practical usage of several important Reflection concepts:

* `Assembly`
* `Type`
* `MemberInfo`
* `MethodInfo`
* `PropertyInfo`
* `ParameterInfo`
* `Activator.CreateInstance()`
* `MethodInfo.Invoke()`
* `PropertyInfo.GetValue()`
* `PropertyInfo.SetValue()`
* `GetMembers()`
* `GetProperties()`
* Runtime type inspection
* Dynamic UI generation

---

## 🔄 How It Works

```text
Select DLL
    ↓
Load Assembly
    ↓
Discover Classes
    ↓
Select Class
    ↓
Discover Methods & Properties
    ↓
Select Member
    ↓
Inspect Parameters / Property
    ↓
Generate Input Controls
    ↓
Enter Values
    ↓
Execute Member
    ↓
Display Result
```

---

## 🎯 Project Goals

The main goal of this project was to move from learning **Reflection theoretically** to applying it in a practical application.

Through this project, I practiced how .NET Reflection can be used to:

* Inspect assemblies at runtime.
* Discover types and members dynamically.
* Read method metadata and parameters.
* Create objects dynamically.
* Invoke methods without directly referencing them.
* Read and modify properties at runtime.
* Generate UI controls based on runtime type information.
* Handle different types of returned values.

---

## 📁 Project Structure

```text
SimpleReflectionProject/
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
│
├── clsMemberItem.cs
├── clsUIManager.cs
│
├── Program.cs
├── App.config
├── ReflectionProject.csproj
├── ReflectionProject.sln
├── packages.config
├── .gitignore
│
└── Properties/
```

---

## 🚀 Future Improvements

* [ ] Support more parameter types.
* [ ] Improve exception handling.
* [ ] Support constructors with parameters.
* [ ] Display access modifiers.
* [ ] Support fields and events.
* [ ] Improve assembly dependency handling.
* [ ] Add search/filter functionality.
* [ ] Improve result visualization.
* [ ] Add execution history.

---

## 📅 Development

**Development Period:**
`September 19, 2026 → September 21, 2026`

This project was developed as a focused practical exercise for learning and applying **C# Reflection** in a Windows Forms environment.

---

## 🔗 Project Links

* 💻 **GitHub Repository:**
  https://github.com/aimanameenmohammed/SimpleReflectionProject

* 💼 **LinkedIn Project Post:**
  https://lnkd.in/p/eKpqQT-Y

The LinkedIn post documents the practical experience and the concepts explored while building this project.

---

## 👨‍💻 Author

**Ayman Amin Al-Amry**

Computer Science Student
C# / .NET Developer

---

## ⭐ About the Project

This project is primarily a **learning and experimentation project** focused on understanding how .NET Reflection can inspect types and interact with their members dynamically at runtime.

It demonstrates how Reflection can be used to build tools that are not tightly coupled to specific classes or methods at compile time.
