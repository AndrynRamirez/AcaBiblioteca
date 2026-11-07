# AcaBiblioteca

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![C%23](https://img.shields.io/badge/C%23-Windows%20Forms-239120?logo=csharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)
![Estado](https://img.shields.io/badge/Estado-Funcional-brightgreen)
![Licencia](https://img.shields.io/badge/Licencia-Acad%C3%A9mica-blue)

Sistema de Gestión de Biblioteca desarrollado como proyecto de **Programación Avanzada** para la Corporación Unificada Nacional de Educación Superior (CUN).

Aplicación de escritorio en **C# con Windows Forms** que permite administrar libros, autores, editoriales, usuarios, préstamos y devoluciones, almacenando la información en **SQL Server**.

**Repositorio:** [github.com/AndrynRamirez/AcaBiblioteca](https://github.com/AndrynRamirez/AcaBiblioteca)

![Menú principal](Capturas%20de%20pantalla/MenuPrincipal.png)

---

## Tabla de contenido

- [Características](#características)
- [Tecnologías](#tecnologías)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Modelo de datos](#modelo-de-datos)
- [Requisitos](#requisitos)
- [Instalación y ejecución](#instalación-y-ejecución)
- [Módulos del sistema](#módulos-del-sistema)
- [Capturas de pantalla](#capturas-de-pantalla)
- [Documentación](#documentación)
- [Contribución](#contribución)
- [Autor](#autor)
- [Licencia](#licencia)

## Características

- **Gestión de libros:** registrar, consultar, editar, eliminar y buscar por ISBN. Controla las existencias disponibles.
- **Gestión de autores:** registrar, consultar, actualizar y eliminar autores.
- **Gestión de editoriales:** registrar, consultar, actualizar y eliminar editoriales.
- **Gestión de usuarios:** registrar, consultar, actualizar y eliminar usuarios. El documento es único.
- **Gestión de préstamos:** registrar préstamos descontando existencias y controlar la disponibilidad de cada libro.
- **Gestión de devoluciones:** registrar la fecha de devolución, cambiar el estado a "Devuelto" y reponer las existencias.
- **Reportes:** préstamos activos, préstamos devueltos e inventario de libros.
- **Validaciones:** campos obligatorios, datos numéricos, ISBN y documento únicos, existencias disponibles y devolución única.
- **Manejo de excepciones:** operaciones protegidas con `try`/`catch` y mensajes al usuario.

## Tecnologías

| Tecnología | Uso |
| --- | --- |
| C# | Lenguaje de programación |
| .NET 10 (Windows Forms) | Framework de la aplicación |
| SQL Server | Base de datos relacional |
| Microsoft.Data.SqlClient | Acceso a datos (ADO.NET) |
| FontAwesome.Sharp | Íconos del menú |
| Git / GitHub | Control de versiones |

## Estructura del proyecto

```
AcaBiblioteca/
├── AcaBiblioteca/
│   └── AcaBiblioteca/
│       ├── Datos/
│       │   └── Conexion.cs
│       ├── Properties/
│       ├── FrmPrincipal.cs
│       ├── FrmInicio.cs
│       ├── FrmLibros.cs
│       ├── FrmAutores.cs
│       ├── FrmEditoriales.cs
│       ├── FrmUsuarios.cs
│       ├── FrmPrestamos.cs
│       ├── FrmReportes.cs
│       ├── Program.cs
│       └── AcaBiblioteca.csproj
├── Base de datos/
│   └── Querys BD - AcaBiblioteca.txt
├── Capturas de pantalla/
├── Diagramas/
├── Documentacion.md
└── README.md
```

## Modelo de datos

Base de datos: **AcaBiblioteca**

| Tabla | Descripción |
| --- | --- |
| `Autores` | Nombre y apellido de los autores. |
| `Editoriales` | Nombre de las editoriales. |
| `Libros` | ISBN (PK), título, autor, editorial, categoría, año y existencias. |
| `Usuarios` | Nombre, apellido, documento (único), teléfono y correo. |
| `Prestamos` | Usuario, libro, fechas y estado (`Prestado` / `Devuelto`). |

Relaciones principales:

- `Libros.IdAutor` → `Autores.IdAutor`
- `Libros.IdEditorial` → `Editoriales.IdEditorial`
- `Prestamos.IdUsuario` → `Usuarios.IdUsuario`
- `Prestamos.ISBN` → `Libros.ISBN`

## Requisitos

- Windows 10 o superior.
- [.NET 10 SDK](https://dotnet.microsoft.com/download).
- Visual Studio 2022 o superior con la carga de trabajo **Desarrollo de escritorio de .NET**.
- SQL Server (Express, Developer o superior) y SQL Server Management Studio (opcional, recomendado).

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/AndrynRamirez/AcaBiblioteca.git
cd AcaBiblioteca
```

### 2. Crear la base de datos

1. Abre SQL Server Management Studio.
2. Ejecuta el script [`Base de datos/Querys BD - AcaBiblioteca.txt`](Base%20de%20datos/Querys%20BD%20-%20AcaBiblioteca.txt).
3. El script crea la base de datos `AcaBiblioteca`, las tablas y algunos datos de prueba.

> Si el script se ejecuta tal cual, cambia los comentarios `//` por `--`, ya que SQL Server no acepta `//` como comentario.

### 3. Configurar la conexión

Edita la cadena de conexión en `AcaBiblioteca/AcaBiblioteca/Datos/Conexion.cs` y ajusta el nombre del servidor:

```csharp
private string cadenaConexion =
    "server= PEDRONEITOR; Database= AcaBiblioteca; Integrated Security=True; TrustServerCertificate=true;";
```

### 4. Compilar y ejecutar

Desde Visual Studio:

1. Abre `AcaBiblioteca/AcaBiblioteca/AcaBiblioteca.csproj`.
2. Restaura los paquetes NuGet.
3. Presiona `F5` para ejecutar.

Desde la línea de comandos:

```bash
cd AcaBiblioteca/AcaBiblioteca
dotnet restore
dotnet run
```

## Módulos del sistema

| Módulo | Descripción |
| --- | --- |
| Inicio | Pantalla de bienvenida. |
| Libros | Administración del catálogo y control de existencias. |
| Autores | Administración de autores. |
| Editoriales | Administración de editoriales. |
| Usuarios | Administración de los usuarios de la biblioteca. |
| Préstamos | Registro de préstamos y devoluciones. |
| Reportes | Préstamos activos, préstamos devueltos e inventario de libros. |

## Capturas de pantalla

### Menú principal

![Menú principal](Capturas%20de%20pantalla/MenuPrincipal.png)

### Gestión de libros

![Gestión de libros](Capturas%20de%20pantalla/GestionLibros.jpg)

### Gestión de autores

![Gestión de autores](Capturas%20de%20pantalla/GestionAutores.jpg)

### Gestión de editoriales

![Gestión de editoriales](Capturas%20de%20pantalla/GestionEditoriales.jpg)

### Gestión de usuarios

![Gestión de usuarios](Capturas%20de%20pantalla/GestionUsuarios.jpg)

### Registro de préstamos y devoluciones

![Registro de préstamos y devoluciones](Capturas%20de%20pantalla/GestionPrestamos.jpg)

### Consultas y reportes

![Consultas y reportes](Capturas%20de%20pantalla/GestionReportes.jpg)

## Documentación

La documentación completa del proyecto (requerimientos, casos de uso, diagramas, diccionario de datos, arquitectura, módulos y pruebas) está en [`Documentacion.md`](Documentacion.md).

## Contribución

Este proyecto es de carácter académico. Si deseas proponer una mejora:

1. Haz un fork del repositorio.
2. Crea una rama con tu cambio (`git checkout -b mejora/nombre`).
3. Realiza tus cambios y haz commit (`git commit -m "Describe el cambio"`).
4. Envía un pull request.

## Autor

**Andryn Jair Ramirez Moreno**

Ingeniería de Sistemas — Grupo 54469

Docente: Veronica Castro

Corporación Unificada Nacional de Educación Superior (CUN)

## Licencia

Proyecto con fines académicos.
