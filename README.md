# This is the source code of the [Test App I made in .NET6 w/ ASP.NET CORE MVC](https://github.com/Neon021/AFS.NET_Test) for [Advanced Field Solutions Ltd](https://www.linkedin.com/company/advanced-field-solutions-ltd/)

- [Overview](#overview)
- [Service Architecture](#service-architecture)
- [Technologies](#technologies)
- [Architecture](#architecture)
- [VS Extensions](#vscode-extensions)

# Overview
<p>In this project, I've created a simple MVC app to take an input as a text, translate it via [fun translations](https://funtranslations.com/api/#shakespeare) API and record it into SQL database.<br>
Althought the app is simple, I'e used several <b>services</b> and interfaces with <b>stored procedures</b> to make it <b>production and team-work ready.</b></p>

# Application Architecture
- Utilized MVC Model <em>-which stands for Model,Controller and View-</em> and MVVM <em>-Model, View, ViewModel-</em> for the WebApplication on this project.
- Created <code>ITranslateService</code> to talk to API through controller *without coupling*.
- Employed *Dapper* and *Stored Procedures* with *two data access layers* for abstraction and decoupling before the controller.

# Technologies
- ASP.NET CORE 6
- Dapper
- SQL Server
- T-SQL
- REST API
- JSON

# Usage
- Simply git clone <code>https://github.com/Neon021/AFS.NET_Test</code> and <code>dotnet run --project AFS.NET_Test</code>

# VS Extensions
- [Dapper](https://github.com/DapperLib/Dapper) - A simple Micro-ORM for .Net.
