var connection = new signalR.HubConnectionBuilder().withUrl('/home/index')
    .build();

connection.on('ReceiveMessage', addMessageToChat);

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('SendMessage', message);
}