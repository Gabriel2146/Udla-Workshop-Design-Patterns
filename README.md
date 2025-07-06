# Documento Técnico - Aplicativo de Automóviles

## 1. Identificación del Problema y Restricciones

El proyecto consiste en un aplicativo de automóviles que requiere implementar funcionalidades para agregar vehículos (Mustang y Explorer) en la página principal. El sistema actual utiliza un patrón repositorio para operaciones CRUD, pero el equipo de QA ha reportado que no funciona correctamente. Además, el esquema de la base de datos aún no está listo, por lo que se necesita una solución para probar la funcionalidad sin persistencia en base de datos.

El equipo de negocio solicita agregar el año actual y 20 propiedades por defecto a los vehículos, con la necesidad de que esta funcionalidad sea extensible para futuros sprints. También se planea agregar un nuevo modelo (Ford Escape) y se sugiere implementar un patrón Factory Method para facilitar la incorporación de nuevos modelos en el futuro.

### Restricciones Técnicas y de Proyecto

- La base de datos no está disponible para pruebas, por lo que se debe usar un repositorio simulado en memoria.
- Se debe minimizar el impacto de futuros cambios para agregar nuevas propiedades a los vehículos.
- La solución debe seguir buenas prácticas y principios SOLID para facilitar mantenimiento y escalabilidad.

## 2. Metodologías y Patrones de Diseño Seleccionados

### Patrón Repositorio (Repository Pattern)

Se utiliza para abstraer la capa de acceso a datos, permitiendo cambiar la implementación del almacenamiento sin afectar la lógica de negocio. En este caso, se implementó un repositorio simulado en memoria (`MyVehiclesRepository`) para pruebas sin base de datos.

### Patrón Factory Method

Se implementa para la creación de vehículos, permitiendo encapsular la lógica de instanciación de diferentes modelos (Mustang, Explorer, Escape). Esto facilita la extensión para nuevos modelos sin modificar el código existente.

### Patrón Builder (Builder Pattern)

Se extiende el builder (`CarModelBuilder`) para construir vehículos con el año actual y 20 propiedades por defecto. Este patrón permite construir objetos complejos paso a paso y facilita la extensión para agregar nuevas propiedades en futuros sprints.

## 3. Diseño Técnico y Propuesta

### Diagrama UML (Descripción para creación manual)

- **Clases principales:**

![Untitled - Frame 3](https://github.com/user-attachments/assets/70f77a0c-2507-451b-8baf-dcdb34b3cf6f)

### Justificación Técnica

- El patrón Repositorio permite desacoplar la lógica de negocio del almacenamiento, facilitando el cambio a base de datos cuando esté lista.
- El Factory Method facilita la extensión para nuevos modelos sin modificar código existente, cumpliendo con el principio abierto/cerrado (SOLID).
- El Builder permite construir vehículos con múltiples propiedades de forma flexible y extensible, minimizando cambios futuros.
- La solución cumple con las restricciones de no usar base de datos y permite pruebas funcionales completas.

## 4. Prototipo y Código

El código implementado se encuentra en el repositorio clonado y modificado, con las siguientes características:

- Repositorio simulado en memoria (`MyVehiclesRepository`).
- Fábricas para Mustang, Explorer y Escape usando Factory Method.
- Builder extendido para agregar año actual y 20 propiedades por defecto.
- Controlador `HomeController` con métodos para agregar vehículos y manejar la lógica.

 
