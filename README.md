
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

#### Get all items

```http
  GET /api/items
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `api_key` | `string` | **Required**. Your API key |

#### Get item

```http
  GET /api/items/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

#### add(num1, num2)

Takes two numbers and returns the sum.


## Estadísticas

![GitHub commit activity](https://img.shields.io/github/commit-activity/t/Mateo00DelLungo/Practico_02)
[![wakatime](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/6c2afb84-c2e4-4afb-8e1e-aadb9ec4a3d3.svg?style=fot-the-badge)](https://wakatime.com/badge/user/ecb456c5-1b67-4281-9da9-456ba4d60a8e/project/6c2afb84-c2e4-4afb-8e1e-aadb9ec4a3d3)
![GitHub top language](https://img.shields.io/github/languages/top/Mateo00DelLungo/Practico_02)

## Autor

- [@Mateo del lungo](https://github.com/Mudo0)🤓

