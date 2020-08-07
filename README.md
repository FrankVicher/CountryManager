# CountryManager

El proyecto fue creado con ASPNet core 3.0.

## Construcción y ejecución del proyecto API

Para construir la aplicación se debe abrir una consola de comandos en la carpeta del proyecto y ejecutar el comando:
```
dotnet build
```
posteriormente se debe actualizar la base de datos, para lo cual es necesario un servidor SQL Server con una instancia local y ejecutar el comando
```
dotnet ef database update
```
esto creará la base de datos y poblara las tablas.

Para ejecutar la aplicación de debe ejecutae el comando
```
dotnet run
```
y posteriormente abrir en el navegador la url https://localhost:5001/swagger/index.html

## Construcción y ejecución del proyecto Cliente
Para construir la aplicación se debe abrir una consola de comandos en la carpeta del proyecto y ejecutar el comando:
```
npm install
```
y posteriormente
```
ng build
```
Para ejecutar la aplicación de debe ejecutae el comando
```
ng serve
```
y posteriormente abrir en el navegador la url https://localhost:4200
