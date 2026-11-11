# Sistema de Gestión de Biblioteca

## 1. Descripción del proyecto

El Sistema de Gestión de Biblioteca es una aplicación de escritorio desarrollada en C# con Windows Forms y SQL Server. Su objetivo es facilitar la administración de los libros, autores, editoriales, usuarios y préstamos de una biblioteca universitaria.

## 2. Tecnologías utilizadas

- Lenguaje de programación: C#.
- Entorno de desarrollo: Visual Studio.
- Interfaz gráfica: Windows Forms.
- Base de datos: Microsoft SQL Server.
- Acceso a datos: Microsoft.Data.SqlClient.

## 3. Módulos del sistema

El sistema cuenta con los siguientes módulos:

- Inicio y menú principal.
- Gestión de libros.
- Gestión de autores.
- Gestión de editoriales.
- Gestión de usuarios.
- Gestión de préstamos.
- Reportes de préstamos activos, préstamos devueltos e inventario de libros.

## 4. Base de datos

La base de datos se llama `AcaBiblioteca` y contiene las siguientes tablas:

- Autores.
- Editoriales.
- Libros.
- Usuarios.
- Prestamos.

El script para crear la base de datos se encuentra en el archivo `BaseDatos_AcaBiblioteca.sql`.

## 5. Requisitos para ejecutar el proyecto

- Tener instalado Visual Studio con soporte para C# y Windows Forms.
- Tener instalado Microsoft SQL Server.
- Tener disponible SQL Server Management Studio (SSMS) para ejecutar el script de la base de datos.

## 6. Pasos para ejecutar el proyecto

1. Ejecutar el archivo `BaseDatos_AcaBiblioteca.sql` desde SQL Server Management Studio.
2. Verificar que la base de datos `AcaBiblioteca` se haya creado correctamente.
3. Abrir la solución `AcaBiblioteca.slnx` desde Visual Studio.
4. Verificar la cadena de conexión en la clase `Conexion.cs`, ubicada en la carpeta `Datos`.
5. Compilar y ejecutar el proyecto desde Visual Studio.

## 7. Conexión a la base de datos

La aplicación utiliza una clase llamada `Conexion.cs` para establecer la conexión con SQL Server.

La cadena de conexión configurada utiliza el servidor local (`localhost`) y la base de datos `AcaBiblioteca`.

Si se ejecuta el proyecto en otro equipo, puede ser necesario ajustar la cadena de conexión según la configuración de SQL Server.

## 8. Autoría

Proyecto académico desarrollado como parte de la asignatura Programación Avanzada.