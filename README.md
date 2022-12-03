# Intro To SignalR In C# Using Blazor WPF

SignalR is an library allowing to connect two or more clients together for real-time communication. This library is just a wrapper around web-standard technologies such as Web Sockets and Long-Polling. It just makes them easier to use. We can even use SignalR with other clients such as Java or JavaScript. In this project, we are going to set up SignalR and connect to it using web clients and desktop clients.


## Create project

<img src="/pictures/create_blazor_app.png" title="create blazor app"  width="400">

## Add Nuget Packages
```
Install-Package Microsoft.AspNetCore.SignalR.Client
```


## Create sql server

<img src="/pictures/create_sql_server.png" title="create sql server"  width="400"> 


## Add Table

<img src="/pictures/sql.png" title="sql"  width="600"> 


## Add Stored Procedures

<img src="/pictures/stored_procedure1.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure2.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure3.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure4.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure5.png" title="stored procedure"  width="600">


## Add Post-Deployment Script 

<img src="/pictures/post_deployment_script.png" title="post deployment script"  width="600">
<img src="/pictures/post_deployment_script2.png" title="post deployment script"  width="600">

Then click *Save Profile As*. That should create a *publish.xml* file. Double click on it to publish again.

<img src="/pictures/post_deployment_script4.png" title="post deployment script"  width="600">

## Create a SQL Server Object Explorer

<img src="/pictures/sql_server_object_explorer.png" title="sql server object explorer"  width="500">
<img src="/pictures/sql_server_object_explorer2.png" title="sql server object explorer"  width="400">

## Add editor config

<img src="/pictures/editor_config.png" title="editor config"  width="500">

## Add Nuget Packages
```
Install-Package Dapper
Install-Package System.Data.SqlClient
Install-Package Microsoft.Extensions.Configuration.Abstraction
```

## Get connection string

Copy it from the properties :
<img src="/pictures/connection_string.png" title="connection string"  width="800">


## Test API

<img src="/pictures/api1.png" title="api"  width="800">
<img src="/pictures/api2.png" title="api"  width="800">


