
# Proyecto[Practica_02]

#### Ejercicio Práctico sobre WebApi utilizando ASP.NET CORE.

Tomando el dominio del Problema 1.5 de la guía de estudios correspondiente a la unidad temática N° 1, se pide:

- Crear un Proyecto Web API con la siguiente estructura de carpetas:

  proyecto[Practica02]:

	    ++ Un controlador llamado ArticulosController (carpeta Controllers).

        ++ Un Modelo llamado Articulo (carpeta Models)

        ++ Una implementación de una interfaz IAplicacion que exponga los servicios para: agregar, consultar, editar y registrar la baja de artículos

        ++ Modelar una capa de acceso a datos que permita, mediante procedimientos almacenados, gestionar artículos (utilizar patrón Repository). 

    Puede utilizar un segundo proyecto de tipo Librería (dll) para modelar esta capa. No olvide indicar la dependencia de proyecto desde la WebApi al proyecto de tipo librería.

- Utilizar la misma base de datos de la actividad 01

- Desarrollar el/los procedimientos almacenados que considere necesarios.

- Adicionalmente deberá probar la WebApi mediante la herramienta Swagger.


## API Reference

#### Get all Articulos

```http
  GET /api/Articulos
```
#### Post Articulo

```http
  Post /api/Articulos
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | El valor de id debe ser 0 (cero) para crear/insertar un nuevo articulo |
| `nombre`      | `string` | nombre del articulo |
| `precioUnitario`      | `double` |precio|


#### Get Articulo especifico

```http
  GET /api/Articulos/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Requerido**. codigo del Articulo a consultar |

#### Put Articulo

```http
  PUT /api/Articulos/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| From URL|
| `id`      | `int` | **Requerido**. codigo del Articulo a que se desea modificar |
| From Body|
| `id`      | `int` | valor indistinto |
| `nombre`      | `string` | nombre que se desea aplicar al objeto existente |
| `precioUnitario`      | `double` |precio que se desea aplicar al objeto existente|

#### Delete Articulo

```http
  DELETE /api/Articulos/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Requerido**. codigo del Articulo que se desea eliminar |

## Estadísticas

![GitHub commit activity](https://img.shields.io/github/commit-activity/t/Mateo00DelLungo/Practico_02)
[![wakatime](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/6c2afb84-c2e4-4afb-8e1e-aadb9ec4a3d3.svg?style=fot-the-badge)](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/6c2afb84-c2e4-4afb-8e1e-aadb9ec4a3d3)
![GitHub top language](https://img.shields.io/github/languages/top/Mateo00DelLungo/Practico_02)

## Autor

- [@Mateo del lungo](https://github.com/Mudo0)🤓

