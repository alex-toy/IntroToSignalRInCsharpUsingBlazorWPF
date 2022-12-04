"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
connection.on("ReceiveMessage", (msg) => {
    var li = document.createElement("li");
    li.textContent = msg;
    document.getElementById("msglist").appendChild(li);
});


