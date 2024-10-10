# IDWM 2024-2: Cloudinary

Este proyecto corresponde a un ejemplo de uso de una API externa (Cloudinary) para la asignatura Introducción al Desarrollo Web Móvil.

## Requerimientos

- **[ASP.NET Core 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)** 
- **[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)** 
- **[Postman](https://www.postman.com/downloads/)** para probar la API
- Credenciales de **[Cloudinary](https://cloudinary.com/)** (CloudName, ApiKey, ApiSecret) para realizar la configuración

## Clonar el Repositorio

Clona el repositorio con el siguiente comando:

```bash
git clone https://github.com/IDWM/dotnet-posts.git
```

## Restaurar el Proyecto

Después de clonar el repositorio, navega a la carpeta del proyecto y restaura los paquetes de NuGet:

```bash
cd dotnet-posts
dotnet restore
```

## Configurar la Base de Datos

Crea el archivo `appsettings.json` para configuración del proyecto.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=app.db"
  },
  "CloudinarySettings": {
    "CloudName": "your-cloud-name",
    "ApiKey": "your-api-key",
    "ApiSecret": "your-api-secret"
  }
}
```

Asegúrate de reemplazar `your-cloud-name`, `your-api-key`, y `your-api-secret` con tus credenciales de Cloudinary.

## Ejecutar la Aplicación

Para ejecutar la aplicación, utiliza el siguiente comando:

```bash
dotnet run
```

Esto iniciará el servidor en `http://localhost:5000`.

## Probar la API con Postman

Utiliza Postman para probar los endpoints de la API. Importa la colección llamada **"Cloudinary.postman_collection.json"**, que está incluida en el proyecto, y ejecuta las solicitudes predefinidas.