# Reflection Explorer 🔍

A simple **C# Windows Forms** application built to practically explore and understand **Reflection in .NET**.

## 📌 About The Project

During my learning journey with **Reflection in C#**, I wanted to move beyond the theoretical side and build a simple practical application that would help me understand how Reflection works at runtime.

The application allows the user to load an external **DLL / Assembly**, explore its Classes and Methods, inspect Parameters, dynamically create input controls based on parameter types, execute Methods at runtime, and display their returned results.

The main purpose of this project is **learning, experimentation, and building a practical understanding of Reflection**.

## ✨ Features

* Load an external `.dll` file dynamically.
* Discover Classes inside an Assembly.
* Discover Methods inside a selected Class.
* Display Method information.
* Read Method Parameters and their types.
* Dynamically generate input controls according to Parameter types.
* Support parameter types such as:

  * `string`
  * `int`
  * `float`
  * `double`
  * `bool`
  * `DateTime`
  * `TimeSpan`
* Execute Methods dynamically using `MethodInfo.Invoke()`.
* Handle both Static and Instance Methods.
* Read returned Objects using Reflection.
* Read Object Properties dynamically.
* Display Property names and their values.
* Detect `DataTable` results and display them using `DataGridView`.

## 🧠 Reflection Concepts Applied

### Assembly

Loading an external DLL and accessing the Types it contains.

```csharp
Assembly assembly = Assembly.LoadFrom(path);
```

### Type

Discovering Classes inside the loaded Assembly.

```csharp
Type[] types = assembly.GetTypes();
```

### MethodInfo

Getting and inspecting Methods from a selected Class.

```csharp
MethodInfo[] methods = selectedClass.GetMethods();
```

### ParameterInfo

Reading Method Parameters dynamically.

```csharp
ParameterInfo[] parameters = selectedMethod.GetParameters();
```

### Method Invocation

Executing a Method at runtime.

```csharp
object result = selectedMethod.Invoke(instance, values);
```

### PropertyInfo

Reading Properties from a returned Object.

```csharp
PropertyInfo[] properties = result.GetType().GetProperties();
```

Retrieving Property values:

```csharp
object value = property.GetValue(result);
```

## ⚙️ How It Works

```text
DLL
 │
 ▼
Assembly
 │
 ▼
Classes
 │
 ▼
Methods
 │
 ▼
Parameters
 │
 ▼
Dynamic Input Controls
 │
 ▼
Parameter Values
 │
 ▼
Invoke()
 │
 ▼
Method Result
 │
 ├── Simple Value
 │
 ├── Object → Properties
 │
 └── DataTable → DataGridView
```

## 🖥️ Application Workflow

### 1. Load DLL

The user selects an external DLL file.

### 2. Explore Classes

The application loads the Assembly and displays the available Classes.

### 3. Explore Methods

After selecting a Class, its Methods are displayed.

### 4. Inspect Parameters

When a Method is selected, its Parameters and their Types are detected using Reflection.

### 5. Enter Parameters

Input controls are generated dynamically according to the Parameter type.

```text
int       → TextBox
string    → TextBox
bool      → CheckBox
DateTime  → DateTimePicker
TimeSpan  → DateTimePicker
```

### 6. Execute Method

The entered values are converted to the required Types and passed to the selected Method using `Invoke()`.

### 7. Display Result

The application checks the returned result and displays it according to its Type.

```text
Simple Value
      ↓
Display Value

Object
      ↓
Read Properties
      ↓
Display Property Values

DataTable
      ↓
DataGridView
```

## 🛠️ Technologies Used

* C#
* .NET
* Windows Forms
* Reflection
* `System.Reflection`
* `System.Data`
* `DataGridView`

## 🎯 Learning Objectives

This project helped me strengthen my understanding of:

* Reflection in C#
* Assemblies and DLLs
* `Type`
* `MethodInfo`
* `ParameterInfo`
* `PropertyInfo`
* Dynamic Method Invocation
* Static vs Instance Methods
* Runtime Type Inspection
* Dynamic UI Controls
* Working with returned Objects
* Working with `DataTable`

## 📚 Key Reflection Classes

| Class           | Purpose                      |
| --------------- | ---------------------------- |
| `Assembly`      | Load and inspect an Assembly |
| `Type`          | Represent Classes and Types  |
| `MethodInfo`    | Inspect and invoke Methods   |
| `ParameterInfo` | Inspect Method Parameters    |
| `PropertyInfo`  | Read Object Properties       |
| `Activator`     | Create instances dynamically |

## 🚀 Future Improvements

* Better Exception Handling.
* Support for more Parameter Types.
* Support for Nullable Types.
* Support for Enums.
* Support for Complex Object Parameters.
* Improved Result Visualization.
* Method Filtering and Searching.
* Constructor Inspection and Parameter Support.
* More advanced Object Visualization.
* Improved UI/UX.

## 🎥 Project Demo

A practical demonstration of the project is available on LinkedIn:

[View Project Demo](https://lnkd.in/p/dMdY_gFJ)

## 👨‍💻 Author

**Aiman Ameen**

C# / .NET & C++ Developer
Computer Science Student

## 📌 Purpose

This project is part of my learning journey in **C# and .NET**, focusing on understanding Reflection through practical implementation.

> Learn → Build → Experiment → Understand → Improve

## 🔗 Project

[LinkedIn Project Demo](https://lnkd.in/p/dMdY_gFJ)
