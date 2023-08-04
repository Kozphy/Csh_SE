
let connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

let dialogue_panel = document.querySelector(".dialogue");
let chatBtn = document.querySelector(".chatBtn");
let chatUserInputBox = document.querySelector(".chatUserInputBox");
let chatUserInputSection = document.querySelector(".chatUserInputSection");

connection.start().then(function () {
    console.log("connection success");
}).catch(function (err) {
    alert(console.error(err.toString()));
});

connection.on("ReceiveMessage", function (user, message) {
    let userTalkSection = document.querySelector(".userTalkSection");
    userTalkSection.innerHTML +=
    `<div class="user remote">
        <div class="avatar">
            <div class="pic">
                <img src="https://picsum.photos/100/100?random=12" />
            </div>
            <div class="name">${user}</div>
        </div>
        <div class="text">${message}</div>
    </div>`
    //dialogue_panel.scrollIntoView({ behavior: "smooth", block: "end" });
    //chatUserInputBox.scrollIntoView({ behavior: "smooth", block: "end" });
    //dialogue_panel.scrollTo({ top: dialogue_panel.scrollHeight, behavior: "smooth" });
    dialogue_panel.scrollTop = dialogue_panel.scrollHeight;
});



chatBtn.addEventListener("click", function (e) {
    //console.log(dialogue_panel);


    dialogue_panel.classList.toggle("dialogue-show");
    chatUserInputSection.classList.toggle("chatUserInputSection-show");
    //chatUserInputBox.scrollIntoView({ behavior: "smooth", block: "end" });
    //dialogue_panel.scrollTo({ top: dialogue_panel.scrollHeight, behavior: "smooth" });

    dialogue_panel.scrollTop = dialogue_panel.scrollHeight;

    chatUserInputBox.addEventListener("keyup", function (e) {
        if (e.key == "Enter" || e.keyCode == 13) {
            console.log("press enter success");
            let user = "me";
            let message = chatUserInputBox.value;
            connection.invoke("SendMessage", user, message).catch(function (err) {
                return console.error(err.toString());
            });
        }
    });
})