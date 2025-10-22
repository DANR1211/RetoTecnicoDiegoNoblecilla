# Reto Técnico - Diego Noblecilla

Este proyecto fue desarrollado como parte de un reto técnico. Consiste en consumir la API pública (https://randomuser.me/api/) para mostrar información de usuarios aleatorios en una aplicación ASP.NET Core MVC.

---

## 👨‍💻 Sobre mí

Desarrollador con **4 años de experiencia profesional en C#** y el ecosistema .NET. Durante mi carrera he trabajado en:

- Desarrollo de aplicaciones web con **ASP.NET Core MVC y Web API**
- Consumo e integración de **servicios RESTful**
- Arquitectura limpia, separación de responsabilidades y buenas prácticas SOLID
- Frontend básico con Razor Pages, HTML y CSS
- Desarrollo orientado a pruebas (TDD), logs y manejo robusto de errores

---

## 🛠 Tecnologías utilizadas

- **Lenguaje:** C# (.NET 8)
- **Framework:** ASP.NET Core MVC
- **Cliente HTTP:** `HttpClient` inyectado mediante `IHttpClientFactory`
- **Deserialización JSON:** `System.Text.Json`
- **Vistas:** Razor Views (.cshtml)
- **Estilos:** CSS básico (inline)
- **IDE recomendado:** Visual Studio 2022 / Visual Studio Code

---

## 🎯 Funcionalidades implementadas

- Consumo de la API de RandomUser para obtener usuarios aleatorios
- Deserialización y mapeo de los datos a modelos fuertemente tipados
- Visualización de la información relevante en una interfaz web:

  - Foto del usuario
  - Nombre completo
  - Género (traducido al español)
  - Email
  - Ubicación (ciudad, estado, país)
  - Fecha de nacimiento

- Manejo de errores en llamadas HTTP
- Arquitectura limpia: separación entre controlador, vista y servicio

---

