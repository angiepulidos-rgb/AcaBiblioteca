# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**Corporación Unificada Nacional de Educación Superior (CUN)**

**Ingenieria De Sistemas / Programaciòn Avanzada**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**
Angie Tatiana Pulido Sosa

**Docente:**
Veronica Castro Munar

**Fecha:**
Bogotà, 08 Noviembre 2026

----------------------------------------------------------

# CONTRAPORTADA..

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Angie Tatiana Pulido Sosa
**Programa:** Ingenieria De Sistemas
**Grupo:** 54465
**Docente:** Veronica Castro
**Institución:** Corporación Unificada Nacional de Educación Superior (CUN)
**Año:** 2026

------------------------------------------------------------------------

# TABLA DE CONTENIDO

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN

El presente proyecto describe el desarrollo de un **Sistema de Gestión de Biblioteca**, Mediante una aplicación de escritorio que permita organizar y administrar la informaciòn  bibliografica de una biblioteca universitaria.

La necesidad de este sistema surge de la importancia de contar con una herramienta tecnologica que facilite el manejo de la informaciòn  relacionada con los libros, autores, editoriales y usuarios, Ademas registrar los prestamos y consultar reportes realcionados con prestamos activos, libros devueltos e inventario de libros.

El sistema fue desarrollado utilizando **C# / windows Forms /
SQL Server **, para crear la interfaz grafica y el sistema de gestion de bases de datos, que almacena y administra la informaciòn.Asi mismo de aplicaron conceptos de programaciòn orientada a onjetos, operaciones CRUD, validaciones de datos, manejo de excepciones y principios de arquitectura en capas.

La aplicación permite gestionar libros, autores, editoriales, usuarios, préstamos y reportes. Con esto se busca administrarla informaciòn de manera organizada, facilitar las consultas y mejorar el control de los procesos de una biblioteca.

------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar un Sistema de Gestión de Biblioteca que permita administrar de manera organizada la informaci+pm de libros, autores, editoriales, y demas registros bibliograficos, utilizando los principios de la Programación Orientada a Objetos, una base de datos relacional y una arquitectura por capas.


## 2.2 Objetivos específicos

-   Diseñar e implementar una aplicación de escritorio para la gestión
    de una biblioteca universitaria.
-   Aplicar principios de Programación Orientada a Objetos.
-   Diseñar e implementar una base de datos relacional en SQL Server.
-   Implementar operaciones CRUD para las entidades principales.
-   Implementar validaciones de datos.
-   Implementar manejo de excepciones.
-   Aplicar una arquitectura por capas.
-   Implementar consultas que faciliten la administración de la
    biblioteca.
-   Utilizar Git y GitHub para el control de versiones.
-   Documentar técnica y funcionalmente el proyecto.
-   Desarrollar interfaces graficas utulizando C# y Windows Forms,
    para que el usuario interactue con el sistema.
-   Realizar Puebas de Funcionamiento para comprobar que las 
    operaciones implementadas respondan correctamente a la necesidades del sistema.

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

La biblioteca actualmente presenta dificultades para administrar de
manera organizada la información relacionada con los libros, autores,
usuarios y préstamos. Ya que no se cuenta con una herramienta que permita 
organizar y controlar adecuadamente los libros.

Ademas es necesrio llevar el registro de los prestamos y devoluciones y para
esto se requiere mantener la informaciòn actualizada y determinar cuales
ejemplares estan prestados, devueltos o disponibles.

Por esta razón, se propone desarrollar una aplicación que permita
centralizar y administrar la información de la biblioteca de manera
organizada y eficiente.

## 3.2 Justificación

El desarrollo de este sistema es importante debido a que la universidad 
presenta problemas con la organizaciòn,reporte y registro oportuno, que
dificulta el trabajo de el personal que la administra e impide que los 
estudiantes y maestros accedan a los recursos que necesita. 

Con este sistema se espera tener un registro detallado, organizado y que
sea accequible para los estudiantes y docentes.

## 3.3 Alcance

El sistema permitirá:

-   Gestionar libros.
-   Gestionar autores.
-   Gestionar usuarios.
-   Registrar préstamos.
-   Registrar devoluciones.
-   Generar   Reportes

### Fuera del alcance

-   No permitira compra de libros.
-   No enviara mensaje de recordatorio a usuarios.

------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información
relacionada con entidades principales como lo son Autor, Editorial, Libro,
Usuario, Prestamo y controlar los procesos de préstamos, devoluciones, consultas, etc.

## 4.2 Actores del sistema

  -----------------------------------------------------------------------
  Actor                               Descripción
  ----------------------------------- -----------------------------------
  Bibliotecario / Administrador: Gestiona usuarios, permisos, configuración y superviciòn del sisrema,Registra libros, autores y editoriales; realiza préstamos,  devoluciones y controla el inventario. 

  Estudiante: Consulta catálogo de libros, verifica disponibilidad, y solicita prestamos.

  Docente: Apoya el registro, organización, búsqueda y devolución de materiales bibliográficos.
  -----------------------------------------------------------------------

## 4.3 Requerimientos funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RF01                    Gestionar libros        Registrar, consultar,
                                                  actualizar, eliminar y
                                                  buscar libros.

  RF02                    Gestionar autores       Registrar, consultar,
                                                  actualizar y eliminar
                                                  autores.

  RF03                    Gestionar editoriales   Registrar, consultar,
                                                  actualizar y eliminar
                                                  editoriales.

  RF04                    Gestionar usuarios      Registrar, consultar,
                                                  actualizar y eliminar
                                                  usuarios.

  RF05                    Registrar préstamos     Registrar préstamos y
                                                  actualizar la
                                                  disponibilidad de los
                                                  libros.

  RF07                    Gestionar Reportes      Consultar Préstamos 
                                                  activos, prestamos 
                                                  devueltos, inventario
                                                  de libros.
  -----------------------------------------------------------------------

## 4.4 Requerimientos no funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RNF01                   Usabilidad              La interfaz debe ser
                                                  clara, sencilla y fácil
                                                  de utilizar.

  RNF02                   Validación              El sistema debe validar
                                                  la información
                                                  ingresada por el
                                                  usuario.

  RNF03                   Mantenibilidad          El código debe estar
                                                  organizado y
                                                  documentado.

  RNF04                   Arquitectura            El sistema debe
                                                  utilizar una
                                                  arquitectura por capas.

  RNF05                   Manejo de excepciones   Las operaciones deben
                                                  manejar errores de
                                                  forma controlada.

  RNF06                   Integridad de datos     La información debe
                                                  mantenerse consistente
                                                  en la base de datos.

  RNF07                    Validaciòn de datos    Se deben realizar validaciones
                                                  para evitar registros incompletos 
                                                  o informaciòn incorrecta

  RNF08                    Mantenimieto de        El sistema debe permitir realizar
                            informaciòn           operaciones de registro,
                                                  consulta, ediciòn y eliminaciòn
                                                  deacuerdo con las funcionalidades del modulo.          
  -----------------------------------------------------------------------

## 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario inexistente.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro inexistente.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, la disponibilidad del libro deberá
actualizarse.

### RN07 -- Devolución

Al registrar una devolución, la disponibilidad deberá actualizarse
nuevamente.

### RN08 -- Multa

La multa se calculará únicamente cuando exista retraso en la devolución.


------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

Mediante los casos de uso se identifican las principales funcionalidades del sistema y la interacciòn del personal de la biblioteca con cada modulo. Esto permite comprender mejor el funcionamiento de la aplicaciòn.

## 5.2 Diagrama de casos de uso


![alt text](<Diagrama De Casos De Uso - Biblioteca .png>)

## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar y
buscar libros.

**Precondiciones:** - El usuario debe tener acceso al sistema. - Otra
precondición.

**Flujo principal:** 1. El actor ingresa al módulo de libros. 2. El
sistema muestra los libros registrados. 3. El actor selecciona la
operación que desea realizar. 4. El sistema procesa la solicitud. 5. El
sistema muestra el resultado.


**Postcondiciones:** -Los módulos que permiten realizar tareas de administración y control de la información de la biblioteca.

------------------------------------------------------------------------

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar el préstamo de uno o varios libros a
un usuario.

**Precondiciones:** - El usuario debe existir. - El libro debe
existir. - Debe existir disponibilidad.

**Flujo principal:** 1. Seleccionar usuario. 2. Seleccionar libro. 3.
Verificar disponibilidad. 4. Registrar préstamo. 5. Actualizar
disponibilidad. 6. Mostrar confirmación.

**Flujos alternativos:** - Usuario inexistente. - Libro inexistente. -
Libro sin disponibilidad. 

**Postcondiciones:** - El préstamo queda registrado. - La disponibilidad
del libro queda actualizada.

------------------------------------------------------------------------

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar la devolución de un libro prestado.

**Precondiciones:** - Debe existir un préstamo activo.

**Flujo principal:** 1. Seleccionar el préstamo. 2. Registrar la
devolución. 3. Calcular días de retraso. 4. Calcular multa cuando
corresponda. 5. Actualizar disponibilidad. 6. Actualizar el estado del
préstamo. 7. Mostrar confirmación.


**Postcondiciones:** - La devolución queda registrada. - El libro vuelve
a estar disponible según corresponda.

------------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

FrmLibros: Administra la informaciòn de los libros mediante una interfaz grafica.
Conexiones: Contiene connexiones y permite obtener conexiones con SQL SERVER.
Form: Clase base de Windows Forms de la cual hereda FmrLibros.
SqlConnection: Objeto utilizado para establecer conexiòn con SQL Server.

## 6.2 Diagrama de clases

Insertar aquí el diagrama de clases.

![alt text](<Diagrama De Clases - Biblioteca.png>)

## 6.3 Principales clases

  Clase             Responsabilidad
  ----------------- --------------------------------------------------------
  FrmPrincipal        Permite acceder a los diferentes modulos.
  FrmInicio           Muestra la bienvenida.
  FrmLibros           Representar y gestionar la información de los  libros.
  FrmAutores          Representar y gestionar los autores.
  FrmUsuarios         Representar los usuarios de la biblioteca.
  FrmPrestamos        Gestionar la información de los préstamos.
  FrmReportes         Gestionar los prestamos y las devoluciones y  calcular retrasos/multas.
  FrmEditoriales      Relaciona y gestiona las editoriales.
  Conexion            Establece la conexion con SQL SERVER.

## 6.4 Aplicación de POO

Explicar cómo se aplicaron:

-   Clases: Las clases se aplicaron mediante la creaciòn de libros como FrmLibros, FrmPrestamos, Fmr reportes, FrmAutores, FrmEdotiriales, FrmInicio, FrmPricipal, FrmUsuarios y Conexiòn y cada clase se encarga de realizar diferentes funciones en el sistema.

-   Objetos: Se aplicaron objetos para establecer la conexiòn con la base de datos SQL SERVER.

-   Constructores: Se aplicaron constructores como (public FrmReportes()) para inicalizar los componentes y preparar la informaciòn necesaria para su funcionamiento.

-   Métodos: Se eneraron metodos para agregar datos ,editar eliminar,generar reportes y consultas en cada uno de los formularios.

-   Propiedades: Se utilizaron propiedades de los controles, como Text, DataSource,Selectedvalue y SelectedIndex, para consultar y modificar inofrmaciòn.

-   Encapsulamiento:Se aplicaron atributos y metodos privados para mantener determinados datos y funciones dentro de la clase.

-   Colecciones: Se aplicaron conexiones para enlazar datos como DataGridView y ComboBox para mostrar multiples registros en pantalla.

-   Herencia: Los formilarios heredan la clase Form de windows Form


------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

El modelo entidad-relaciòn representa la organizaciòn de la informaciòn dentro de las bases de datos, identificando las tablas, sus atributos y las realciones entre ellas.

La base de datos AcaBiblioteca esta conformada por cinco tablas principales: Autores, Editoriales, Libros, Usuarios y Prestamos.

## 7.2 Diagrama entidad-relación

![alt text](<Análisis BD Biblioteca.png>)


## 7.3 Relaciones principales

Describir las relaciones entre las entidades.

Relación	Cardinalidad	Explicación

Autores – Libros: 	Uno a muchos (1:N)	Un autor puede estar relacionado con varios libros.

Editoriales – Libros:	Uno a muchos (1:N)	Una editorial puede publicar varios libros.

Usuarios – Prestamos:	Uno a muchos (1:N)	Un usuario puede tener varios préstamos.

Libros – Prestamos:	Uno a muchos (1:N)	Un libro puede aparecer en diferentes registros de préstamos.

# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

  Abreviatura   Significado
  ------------- -----------------------------
  PK            Clave primaria
  FK            Clave foránea
  UQ            Campo con valor único
  NULL          Campo que puede estar vacío
  NOT NULL      Campo obligatorio

## 8.2 Tabla: Autor

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ --------------------------------
  idAutor           INT            PK      No     Identificador único del autor.
  nombre            VARCHAR(100)   \-      No     Nombre del autor.
  apellidos         VARCHAR(100)   \-      No     Apellidos del autor.
  nacionalidad      VARCHAR(50)    \-      Sí     Nacionalidad del autor.
  fechaNacimiento   DATE           \-      Sí     Fecha de nacimiento.

  ## 8.3 Tabla: Editoriales

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ --------------------------------
  idEditorial       INT            PK      No    Identificador único 
  de la editorial.  
  nombre            VARCHAR(150)   \-      No     Nombre del autor.
  apellidos         VARCHAR(100)   \-      No     Apellidos del autor.
 
## 8.4 Tabla: Libro

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ -----------------------------------
  ISBN              VARCHAR(20)    PK      No     Identificador unico del linro.
  titulo            VARCHAR(200)   \-      No     Título del libro.
  idAutor           INT            FK      No     Autor asociado al libro.
  IdEditorial       INT            FK      No     Editorial del libro.
  Categoria         VARCHAR(100)   \-      No     Categoría del libro. 
  Anio              INT            \-      No     Año de publicaciòn.
  Existencias       INT            \-      No     CAntidad ejemplares.

## 8.5 Tabla: Usuario

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ ----------------------------------
  idUsuario         INT            PK      No     Identificador único del usuario.
  documento         VARCHAR(30)    UQ      No     Número de documento.
  nombre            VARCHAR(100)   \-      No     Nombre del usuario.
  apellidos         VARCHAR(100)   \-      No     Apellidos del usuario.
  telefono          VARCHAR(30)    \-      Sí     Teléfono de contacto.
  correo            VARCHAR(150)   \-      Sí     Correo electrónico.

## 8.6 Tabla: Prestamo

  Campo           Tipo de dato   Clave   Nulo   Descripción
  --------------- -------------- ------- ------ -----------------------------------
  idPrestamo      INT            PK      No     Identificador único del préstamo.
  idUsuario       INT            FK      No     Usuario que realiza el préstamo.
  ISBN            VARCHAR(20)    FK      No     Identifica el libro prestado.
  fechaPrestamo   DATE           \-      No     Fecha del préstamo.
  fechaDevolucion DATE           \-      No     Fecha de devoluciòn
  estado          VARCHAR(20)    \-      No     Estado del préstamo.


------------------------------------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una
**arquitectura por capas**, con el propósito de separar las
responsabilidades del sistema y facilitar su mantenimiento, organización y evolución.

La arquitectura está compuesta por:

1.  Capa de Presentación.
2.  Capa de Lógica de Negocio.
3.  Capa de Acceso a Datos.
4.  Capa de Base de Datos.

## 9.2 Diagrama de arquitectura

Insertar aquí el diagrama de arquitectura.

![alt text](<Arquitectura Del Sistema  - Biblioteca .png>)

## 9.3 Capa de Presentación

**Responsabilidad:**

Es la capa mediante la cual el usuario interactúa con el sistema.

**Componentes:**

-   \[FrmPrincipal\]
-   \[FrmInicio\]
-   \[FrmLibros\]
-   \[FrmAutores\]
-   \[FrmUsuarios\]
-   \[FrmEditoriales\]
-   \[FrmPrestamos\]
-   \[FrmReportes\]

**Tecnología utilizada:**

-   C#
-   Windows Forms
-   Visual Studio
-   SQL Server
-   SQL Server Management Studio (SSMS)
-   Microsoft.Data.SqlClient


## 9.4 Capa de Lógica de Negocio

**Responsabilidad:**

Procesa las solicitudes provenientes de la interfaz, aplica las reglas
de negocio y coordina las operaciones.

**Componentes:**

-   \[LibroController\]
-   \[AutorController\]
-   \[CategoriaController\]
-   \[UsuarioController\]
-   \[PrestamoController\]
-   \[DevolucionController\]

**Ejemplos de reglas:**

-   Validar disponibilidad.
-   Validar existencia del usuario.
-   Validar existencia del libro.
-   Calcular días de retraso.
-   Actualizar estados.

## 9.5 Capa de Acceso a Datos

**Responsabilidad:**

Gestiona la comunicación entre la aplicación y SQL Server.

**Componentes:**

-   \[Conexion\]
-   \[LibroDAO\]
-   \[AutorDAO\]
-   \[UsuarioDAO\]
-   \[PrestamoDAO\]
-   \[DevolucionDAO\]

**Tecnologías utilizadas:**

-   SQL Server.
-   ADO.NET / \[tecnología realmente utilizada\].
-   Consultas parametrizadas.

## 9.6 Capa de Base de Datos

La información del sistema se almacena en:

**Base de datos:** AcaBiblioteca

**Tablas principales:**

-   Autores
-   Libros
-   Usuarios
-   Prestamos
-   Editoriales

## 9.7 Flujo de información

``` text
Usuario
   ↓
Presentación
   ↓
Lógica de Negocio
   ↓
Acceso a Datos
   ↓
SQL Server
```

Las respuestas de la base de datos realizan el recorrido inverso hasta
llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de inicio 

**Objetivo:** Es la pantalla de bienvenida del sistema. Presenta una imagen con el mensaje de bienvenida a la biblioteca.

## 10.2 Módulo principal

**Objetivo:** Es el formulario principal desde el cual se accede a los diferentes módulos de la aplicación, permitiendo abrir los formularios de libros, autores, editoriales, usuarios, préstamos y reportes.

## 10.3 Módulo de libros

**Objetivo:** Este módulo permite administrar la información bibliográfica de los libros registrados en la biblioteca.

**Funcionalidades:** - Nuevo. - Guardar. - Editar. -Eliminar. -Cancelar. - Buscar.

## 10.4 Módulo de autores

**Objetivo:** Este módulo permite gestionar la información de los autores relacionados con los libros de la biblioteca.

**Funcionalidades:** -Nuevo. - Guardar. - Editar. - Eliminar. -Cancelar. - Consultar.

## 10.5 Módulo de Editoriales

**Objetivo:** Este módulo permite gestionar la información de las editortiales relacionadas con los libros de la biblioteca.

**Funcionalidades:** -Nuevo. - Guardar. - Editar. - Eliminar. -Cancelar. - Consultar.


## 10.6 Módulo de usuarios

**Objetivo:** Este mòdulo permite almacenar y administrar la información de las personas que utilizan los servicios de la biblioteca.

**Funcionalidades:** -Nuevo. - Guardar. - Editar. - Eliminar. -Cancelar. - Consultar.

## 10.7 Módulo de préstamos

**Objetivo:** Su propósito es permitir administrar los préstamos de libros realizados por los usuarios de la biblioteca.

**Funcionalidades:** -Nuevo. - Guardar. - Editar. - Eliminar. -Cancelar. - Consultar.

## 10.8 Módulo de Reportes

**Objetivo:** Su proposito es consultar informaciòn sobre el funcionamiento de labiblioteca.

**Funcionalidades:** - Generar reportes sobre: prestamos activos. - Prestamos devueltos. - Inventario de libros. Mediante las opciones Generar. - Limpiar.

------------------------------------------------------------------------

# 11. CAPTURAS DE PANTALLA DEL SISTEMA

En esta sección se deben incluir evidencias de las principales
funcionalidades.

## 11.1 Menú principal e Inicio

![alt text](<Captura de pantalla 2026-11-10 003657.png>)

**Descripción:** Menú con las opciones disponibles e inico muestra Pantalla de bienvenida al ejecutar el programa.

## 11.2 Gestión de libros

![alt text](<Captura de pantalla 2026-11-09 225141.png>)


**Descripción:** Formulario abierto con los datos de los libros cargados.

## 11.3 Gestión de autores

![alt text](<Captura de pantalla 2026-11-09 231818.png>)

**Descripción:** Formulario abierto con la lista de autores registrados.

## 11.4 Gestión de editoriales

![alt text](<Captura de pantalla 2026-11-09 233427.png>)

**Descripción:** Formulario abierto con la lista de editoriales.

## 11.5 Gestión de usuarios

![alt text](<Captura de pantalla 2026-11-09 234046.png>)

**Descripción:** 	Formulario abierto con la lista de usuarios.

## 11.6 Registro de préstamos

![alt text](<Captura de pantalla 2026-11-10 001448.png>)

**Descripción:** Formulario abierto con la información de los préstamos.

## 11.7 Registro de reportes

![alt text](<Captura de pantalla 2026-11-10 002856.png>)

**Descripción:** Formulario donde muestra los reportes generados.


------------------------------------------------------------------------

# 12. PRUEBAS DE FUNCIONAMIENTO

## 12.1 Estrategia de pruebas

Se efectuaron pruebas para registrar, consultar, modificar y eliminar información, además de verificar los campos obligatorios, gestionar préstamos y devoluciones, y generar informes. Asimismo, se confirmó que el sistema presente mensajes cuando detecta datos duplicados o cuando las relaciones entre las tablas de la base de datos impiden completar una operación.

## 12.2 Casos de prueba

  ------------------------------------------------------------------------------------------
  ID       Funcionalidad              Entrada / Acción     Resultado esperado       Resultado  obtenido      Estado
                                                             
  ----------- --------------- ---------------- ---------------- --------------- ------------
  CP01     Validaciòn campos vacios   Campos vacios        mensaje de validación    No permite guardar       Aprobado
                                                                  

  CP02     Registro de libro          Ingresa datos        Mostrar libro en lista   Guardado correcto        Aprobado
                                                                  

  CP03     Búsqueda de libro          ingresa ISBN         Encontrar el libro       Libro encontrado         Aprobado
                                                          

  CP04     Eliminar un libro          Presionar Eliminar   Confirmar eliminación    Libro Eliminado          Aprobado
                                                                       
                                                             
  CP05     Registrar autor nuevo      Ingresar nombre, apellido   Registrar el autor  Autor en lista         Aprobado
                                   

  CP06     Eliminar un autor          seleciona autor     Eliminar un autor        Autor eliminado          Aprobado
                                  

  CP07     Ingresar nueva editorial  Presionar Guardar   Registrar la editorial    Guardado correcto         Aprobado
           

  CP08     Eliminar editorial        Selecionar ditorial  Confirmar eliminación    Editorial eliminada      Aprobado
                                             

  CP09     Registrar usuario nuevo   Ingresar datos      Presionar Guardar         Guardado correcto        Aprobado


  CP10    Registrar préstamo nuevo   Ingresar datos      Presionar Guardar         registro correcto        Aprobado
                                                                     

  CP11    devolución de un libro   Seleccionar préstamo   Cambiar estado a Devuelto  registrado correcto    Aprobado                                           
                                   activo,Registrar 
                                   fecha de devolución

  CP12    Inventario de libros     Presionar Generar     Mostrar existencias         Genera Reportes        Aprobado                                 
  ------------------------------------------------------------------------------------------

## 12.3 Evidencias de pruebas

### Prueba CP01

![alt text](<Captura de pantalla 2026-11-09 225922.png>)

**Resultado:** No permite campos vacios.

### Prueba CP02

![alt text](<Captura de pantalla 2026-11-09 230257.png>)

**Resultado:** Permitio ingresar libro de prueba.

### Prueba CP03

![alt text](<Captura de pantalla 2026-11-09 230520.png>)

**Resultado:** Permitio buscar libro.

### Prueba CP04

![alt text](<Captura de pantalla 2026-11-09 231326.png>)

**Resultado:** Libro de prueba eliminado correctamente.

### Prueba CP05

![alt text](<Captura de pantalla 2026-11-09 232055.png>)

**Resultado:** Aurtor registrado correctemente.

### Prueba CP06

![alt text](<Captura de pantalla 2026-11-09 233154.png>)

**Resultado:** Autor eliminado correctamente.

### Prueba CP07

![alt text](<Captura de pantalla 2026-11-10 030208.png>)

**Resultado:** Permitio ingresar nueva editorial.

### Prueba CP08

![alt text](<Captura de pantalla 2026-11-10 030509.png>)

**Resultado:** Permitio eliminar editorial.

### Prueba CP09

![alt text](<Captura de pantalla 2026-11-09 234250.png>)

**Resultado:** Permitio ingresar usuario nuevo.

### Prueba CP10

![alt text](<Captura de pantalla 2026-11-10 001638.png>)

**Resultado:** Permitio ingresar prestamo correctamente.

### Prueba CP11

![alt text](<Captura de pantalla 2026-11-10 002456.png>)

**Resultado:** Permitio registrar devoluciòn correctamente.

### Prueba CP12

![alt text](<Captura de pantalla 2026-11-10 003019.png>)

**Resultado:** Permitio generar reporte de inventario.
------------------------------------------------------------------------

# 13. CONCLUSIONES

## Conclusión 1

Con el desarrollo del proyecto se logró crear un Sistema de Gestión de Biblioteca que permite administrar de manera organizada la información de los libros, autores, editoriales y usuarios. También se implementaron funciones para registrar préstamos, controlar las devoluciones y generar reportes de préstamos activos, préstamos devueltos e inventario de libros.

De esta manera, se obtuvo una aplicación que facilita las tareas administrativas de una biblioteca y permite tener un mejor control de la información.



## Conclusión 2

Durante el desarrollo del proyecto se aplicaron conceptos de Programación Orientada a Objetos, como clases, objetos, métodos, constructores, propiedades, encapsulamiento y herencia.

Estos conceptos permitieron organizar el código, crear los diferentes formularios y desarrollar funciones para registrar, consultar, editar y eliminar información. También se utilizó la clase Conexion para facilitar la comunicación entre la aplicación y la base de datos SQL Server.

## Conclusión 3
Con el desarrollo del proyecto se logró crear una base de datos en SQL Server con cinco tablas: Autores, Editoriales, Libros, Usuarios y Prestamos, relacionadas mediante claves primarias y claves foráneas. Esto permitió almacenar la información de forma organizada, mantener las relaciones entre los registros y proteger los datos relacionados.

Con la arquitectura, se logro que mediante los formularios de Windows Forms crear un sistema para la interacción con el usuario y la clase Conexion.cs, para establecer la comunicación con SQL Server.

## Conclusión 4

Durante el desarrollo del proyecto se presentaron algunas dificultades relacionadas con la conexión a la base de datos, el funcionamiento de algunos formularios y las validaciones de la información.

Estas dificultades se fueron solucionando mediante la revisión y corrección del código, la implementación de validaciones y el manejo de excepciones para mostrar mensajes de error más claros. Además, se comprobó que las relaciones de la base de datos protegieran la información existente.


------------------------------------------------------------------------

# 14. RECOMENDACIONES

-   continuar realizando ajustes en el diseño de los formularios para que el sistema sea más fácil y agradable de utilizar.

-   realizar respaldos periódicos de la base de datos para proteger la información almacenada.

-   continuar mejorando los controles de ingreso de información para evitar errores y mantener los datos organizados.

-   considerar la implementación de opciones como el control de fechas de vencimiento y avisos sobre préstamos pendientes de devolución.

------------------------------------------------------------------------

# 15. REFERENCIAS BIBLIOGRÁFICAS

**Página web:**

Microsoft. (s. f.). *Documentación del lenguaje C#*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/csharp/

Microsoft. (s. f.). *Documentación de Windows Forms para .NET*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/desktop/winforms/

Microsoft. (s. f.). *Documentación de SQL Server*. Microsoft Learn. https://learn.microsoft.com/es-es/sql/

Microsoft. (s. f.). *Descripción general de Windows Forms*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/desktop/winforms/overview/


------------------------------------------------------------------------

# ANEXOS

## Anexo A. Repositorio GitHub

**Repositorio:** \[Enlace al repositorio\]

## Anexo B. Script de base de datos

**Archivo:** `[Nombre del archivo .sql]`

## Anexo C. Evidencia de Git y GitHub

Insertar capturas que evidencien:

-   Creación del repositorio.
-   Commits realizados.
-   Organización del proyecto.
-   Publicación del código.
-   README.md.

------------------------------------------------------------------------