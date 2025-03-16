# Prueba Técnica de ABPOS 
Prueba tecnica de desarrrollo web para una empresa de Point Of Security

## Descripción
Este proyecto es una aplicación web creada utilizando **ASP.NET Core MVC** y **Entity Framework Core**. La página es completamente responsiva y cuenta con un formulario de contacto funcional que valida y guarda los datos en una base de datos.

## Requisitos
- **Visual Studio 2019** o superior
- **.NET Core SDK 6.0** o superior
- **SQL Server**

## Tecnologías Utilizadas
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **HTML** y **CSS**

## Funcionalidades
- **Página Responsiva**: Adaptativa y funcional en dispositivos de escritorio y móviles.
- **Formulario de Contacto**: Ubicado en la esquina inferior derecha de la pantalla, con los campos **Nombre**, **Email**, y **Mensaje**. Los datos son validados y guardados en la base de datos.
- **Base de Datos**: Utiliza Entity Framework Core para interactuar con SQL Server.

## Instalación
1. Clona el repositorio:
   ```bash
   git clone https://github.com/Chompi777/Prueba_AB_POS.git
2. Abre el proyecto en Visual Studio.
3. Restaura los paquetes NuGet:
   ```bash
   dotnet restore
4.Crea la base de datos: Ejecuta el comando de migración para crear las tablas:
  ```bash
   dotnet ef database update
```
5.Ejecuta el proyecto:

        dotnet run

Estructura del Proyecto
Models: Contiene las clases que representan los datos y la interacción con la base de datos.
Views: Contiene las vistas de la aplicación, incluyendo la página principal y el formulario de contacto.
Controllers: Gestiona la lógica de la aplicación, como la validación del formulario.
Consideraciones
Responsividad: Probado en dispositivos móviles y navegadores populares.
Comentarios: El código está comentado para facilitar su comprensión.
Licencia
Este proyecto es de uso libre y está bajo la licencia MIT.

```bash

Este `README.md` es sencillo pero informativo y presenta el proyecto de una manera clara y profesional. Puedes personalizarlo más dependiendo de la información adicional que desees agregar.

```
By Salvador Guerra 2025

Images
![image](https://github.com/user-attachments/assets/1331fe91-f7c1-4fb1-abe6-21ea9e7057e6)
![image](https://github.com/user-attachments/assets/bdd3305f-86e1-44a0-9a4f-49e1cd023676)
![image](https://github.com/user-attachments/assets/bfebed39-760f-44f1-96a7-d1804471fd6c)

