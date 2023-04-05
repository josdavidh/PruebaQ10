# PruebaQ10
App de tareas para la pruebaQ10

El proyecto usa: 
**Microsoft.EntityFrameworkCore.SqlServer** - 
**Microsoft.EntityFrameworkCore.Tools**

## Base de datos
Para la base de datos se usa la siguiente tabla en SQL

```SQL
CREATE DATABASE TASKS
USE TASKS

CREATE TABLE Tareas (
	Id int identity(1,1) primary key,
	Descripcion varchar(100),
	FechaCreacion datetime,
	Completada bit
)
```

## Archivo ``aapsettings.json``
Es donde se crea el String de conexión a la base de dato 
```JSON
{
  ...  
  "ConnectionStrings": {
    "conexion": "Server=[nombre de la base de datos]; Database=TASKS; Trusted_Connection=True; TrustServerCertificate=True;"
  }
  ...
}
```
## Archivo ``Program.cs``
En las primeras lineas de codigo, es donde se hace la inyeccion de la dependencia

```csharp
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TasksContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

var app = builder.Build();
```

