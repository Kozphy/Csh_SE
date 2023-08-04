"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message, otherInput) {
  var li = document.createElement("li");
  document.getElementById("messagesList").appendChild(li);
  // We can assign user-supplied strings to an element's textContent because it
  // is not interpreted as markup. If you're assigning in any other way, you
  // should be aware of possible script injection concerns.
  li.textContent = `${user} says ${message} - ${otherInput}`;
});

connection
  .start()
  .then(function () {
    document.getElementById("sendButton").disabled = false;
  })
  .catch(function (err) {
    return console.error(err.toString());
  });

document
  .getElementById("sendButton")
  .addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    let otherInput = document.getElementById("OtherInput").value;
    connection
      .invoke("SendMessage", user, message, otherInput)
      .catch(function (err) {
        return console.error(err.toString());
      });
    event.preventDefault();
  });

let chatBtn = document.querySelector(".chatBtn");
chatBtn.addEventListener("click", function (e) {
    console.log(e.currentTarget);
})
