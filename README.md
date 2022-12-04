# Intro To SignalR In C# Using Blazor WPF

SignalR is an library allowing to connect two or more clients together for real-time communication. This library is just a wrapper around web-standard technologies such as Web Sockets and Long-Polling. It just makes them easier to use. We can even use SignalR with other clients such as Java or JavaScript. In this project, we are going to set up SignalR and connect to it using web clients and desktop clients.


## Create project

<img src="/pictures/create_blazor_app.png" title="create blazor app"  width="400">

## Add Nuget Packages
```
Install-Package Microsoft.AspNetCore.SignalR.Client
```


## Add Client side Library

Right-click to *SignalRTut* and add a client side library

<img src="/pictures/client_side_library.png" title="client side library"  width="400"> 



