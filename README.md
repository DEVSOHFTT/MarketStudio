# MarketStudio
Sistema destinado a la gestión administrativa de empresas.
Market Studio es un software de administración comercial diseñado para ayudar a las empresas a gestionar sus operaciones de ventas, compras, inventario y facturación de manera eficiente.

## Funcionalidades Principales

- **Registro de Ventas y Compras**: Permite a los usuarios registrar y realizar un seguimiento de las transacciones de ventas y compras.

- **Gestión de Proveedores**: Facilita el mantenimiento de información sobre los proveedores y sus productos o servicios.

- **Control de Inventario**: Ayuda a llevar un registro actualizado del inventario, permitiendo una gestión más efectiva de los productos.

- **Facturación**: Confección de facturas para transacciones de venta, con la capacidad de enviarlas por correo electrónico utilizando la librería `Client.dll`.

## Estructura del Proyecto

El proyecto está organizado en varias librerías que proporcionan funcionalidades específicas:

- **Client.dll**: Contiene la información del correo electrónico necesario para enviar las facturas, así como los métodos y clases necesarios para la comunicación por correo electrónico.

- **Dominio.dll**: Contiene las clases para conectarse a la base de datos y gestionar las operaciones relacionadas con los datos.

- **Entidades.dll**: Contiene los modelos de las tablas que se extraen de la base de datos.

- **IDEVStudioUI.dll**: Contiene controles personalizados como textbox, combobox, etc., para mejorar la interfaz de usuario de Market Studio.

- **Negocios.dll**: Contiene métodos y clases necesarios para interactuar con la clase `Dominio.dll` y transformar los datos extraídos de la base de datos en entidades utilizables en la aplicación.

## Dependencias

Este proyecto utiliza las siguientes bibliotecas externas:

- **Bunifu_UI_v1.52.dll**: Una biblioteca para mejorar la interfaz de usuario en aplicaciones Windows Forms.

- **Xander.dll**: Biblioteca para simplificar la creación de controles de interfaz de usuario en C#.
