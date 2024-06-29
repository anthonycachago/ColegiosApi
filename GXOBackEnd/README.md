# Sistema de Gestión de Colegios

Este proyecto es un sistema de gestión de colegios, que permite realizar operaciones CRUD sobre las entidades `Colegio`, `Materia`, `Calificacion` y `Usuario`. Está construido con .NET 6, Entity Framework y LINQ, siguiendo el patrón Clean Architecture y Repository Pattern. La base de datos utilizada es SQL Server en una instancia de Docker. La seguridad de las APIs se implementa mediante tokens JWT.

## Requisitos

- .NET 6 o superior
- Docker
- Visual Studio 2022 o superior
- Postman (opcional, para pruebas)

## Configuración del Proyecto

### 1. Clonar el Repositorio

```sh
git clone https://github.com/tu-usuario/sistema-gestion-colegios.git
cd sistema-gestion-colegios
### 2. Configurar la Cadena de Conexión
En el archivo appsettings.json, actualiza la cadena de conexión:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=ColegioDB;User Id=sa;Password=TuPassword123;"
}

### 3. Ejecutar la Aplicación
Ejecuta la aplicación desde Visual Studio

Uso de la API
Autenticación
Para utilizar las rutas protegidas, primero debes autenticarte y obtener un token JWT.

Solicitud de Autenticación
URL: POST /api/auth/login

Cuerpo:
{
    "username": "testuser",
    "password": "testpassword"
}

Respuesta:
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}

Endpoints CRUD
Crear Colegio
URL: POST /api/colegios

Cuerpo:
{
    "nombre": "Colegio Nacional",
    "tipoColegio": "Publico"
}

Obtener Todos los Colegios
URL: GET /api/colegios

Obtener Colegio por ID
URL: GET /api/colegios/{id}

Actualizar Colegio
URL: PUT /api/colegios/{id}

Cuerpo:
{
    "id": 1,
    "nombre": "Colegio Actualizado",
    "tipoColegio": "Privado"
}

Eliminar Colegio
URL: DELETE /api/colegios/{id}

Crear Materia
URL: POST /api/materias

Cuerpo:
{
    "idColegio": 1,
    "nombre": "Matemáticas",
    "area": "Ciencias Exactas",
    "numeroEstudiantes": 30,
    "docenteAsignado": "Prof. Juan Pérez",
    "curso": "10mo",
    "paralelo": "A"
}

Obtener Todas las Materias
URL: GET /api/materias

Obtener Materia por ID
URL: GET /api/materias/{id}

Actualizar Materia
URL: PUT /api/materias/{id}

Cuerpo:
{
    "id": 1,
    "idColegio": 1,
    "nombre": "Matemáticas Avanzadas",
    "area": "Ciencias Exactas",
    "numeroEstudiantes": 25,
    "docenteAsignado": "Prof. María López",
    "curso": "11mo",
    "paralelo": "B"
}
Eliminar Materia
URL: DELETE /api/materias/{id}

Crear Calificación
URL: POST /api/calificaciones

Cuerpo:
{
    "idColegio": 1,
    "idMateria": 1,
    "idUsuario": 1,
    "calificacion": 95.5
}

Obtener Todas las Calificaciones
URL: GET /api/calificaciones

Obtener Calificación por ID
URL: GET /api/calificaciones/{id}

Actualizar Calificación
URL: PUT /api/calificaciones/{id}

Cuerpo:
{
    "id": 1,
    "idColegio": 1,
    "idMateria": 1,
    "idUsuario": 1,
    "calificacion": 98.0
}
Eliminar Calificación
URL: DELETE /api/calificaciones/{id}

Crear Usuario
URL: POST /api/usuarios

Cuerpo:
{
    "nombreCompleto": "Juan Pérez",
    "username": "juanperez",
    "password": "password123",
    "correoElectronico": "juan.perez@example.com",
    "rol": "Estudiante"
}
Obtener Todos los Usuarios
URL: GET /api/usuarios

Obtener Usuario por ID
URL: GET /api/usuarios/{id}

Actualizar Usuario
URL: PUT /api/usuarios/{id}

Cuerpo:
{
    "id": 1,
    "nombreCompleto": "Juan Pérez Actualizado",
    "username": "juanperez",
    "password": "nuevoPassword123",
    "correoElectronico": "juan.perez@example.com",
    "rol": "Estudiante"
}

Eliminar Usuario
URL: DELETE /api/usuarios/{id}

Contribuir
Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request.

Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.

Este archivo `README.md` proporciona una guía completa sobre cómo configurar, ejecutar y utilizar la API, incluyendo ejemplos de solicitudes para los endpoints CRUD de cada entidad. Ajusta cualquier detalle específico de tu implementación según sea necesario.


