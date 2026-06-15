# AdvancedC# 
RPG Character Vault
Developer: Ryan Crawford

Language: C# (.NET Console Application)

Database: SQLite

Project Overview
The RPG Character Vault is a console-based application designed to manage custom role-playing game characters, their statistics, and their active inventory loadouts. Built progressively over four phases, this project serves as a comprehensive demonstration of Object-Oriented Programming (OOP) principles and data persistence using an SQLite database.

Core Features & Architecture
This application was built using a structured MVC-style separation of concerns (Model data, Console view, Database controller) and highlights the following software development concepts:

1. Object-Oriented Principles
Inheritance: Utilizes an abstract base Character class, with specific roles (Mage, Warrior) inheriting shared properties like Name and Weapon.

Composition: Demonstrates a "has-a" relationship by passing a custom Weapon object into the Character classes.

Polymorphism: Derived classes override virtual and abstract base methods (like DisplayStats() and CalculatePowerLevel()) to provide class-specific outputs.

Abstraction & Interfaces: Implements an ISpecialAbility interface to guarantee unique combat abilities across different character classes, and uses abstract methods to enforce mathematical power calculations.

Encapsulation: Protects data integrity using strict access specifiers (private set, protected).

Constructor Overloading: Provides multiple ways to instantiate objects, such as assigning default weapon damage or specifying custom stats.

2. Database Integration
Uses Microsoft.Data.Sqlite to handle local data persistence.

Automatic Initialization: Automatically generates the rpg_vault.db file and relational tables (Characters, Weapons) upon first launch.

Full CRUD Functionality: * Create: Add new weapons and specific character classes to the database.

Read: Retrieve joined relational data and parse it back into active C# OOP objects.

Update: Modify character attributes (e.g., leveling up Mana or Armor).

Delete: Permanently remove retired characters from the roster.

Technologies Used
C# / .NET Core

Object-Oriented Programming (OOP)

SQLite

ADO.NET (SqliteConnection, SqliteCommand, SqliteDataReader)

How to Run
Clone the repository to your local machine.

Open the solution in Visual Studio.

Ensure the Microsoft.Data.Sqlite NuGet package is installed and restored.

Build and run the project. The database will automatically initialize in the project's output directory.
