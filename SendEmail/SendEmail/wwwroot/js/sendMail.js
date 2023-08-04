let sendMailBtn = document.querySelector(".sendMailBtn");


// dbdf0147@gmail.com
sendMailBtn.addEventListener("click", async function (e) {

    let email_access_data = undefined;
    try {
        res = await axios.get("http://localhost:5189/api/GetMailTrapAccess");
        if (res.status == 200) {
            email_access_data = {
                SecureToken: res.data.mail_securetoken,
                Server: res.data.mail_server,
                Host: res.data.mail_server,
                Username: res.data.mail_username,
                Password: res.data.mail_password,
            };
        }
    } catch (e) {
        console.error(e);
    }

    let SendToWhere = document.querySelector(".emailToWhere");
    let SendToWhereValue = SendToWhere.value;

    console.log(`email_access_data:`, email_access_data);
    const email_pattern = /[a-z0-9!#$ %& '*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&' * +/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/i;
    console.log(SendToWhereValue);
    let isEmail = email_pattern.test(SendToWhere.value);
    console.log(`IsEmail: ${isEmail}`);


    if (SendToWhereValue.length > 0 && email_access_data != undefined && isEmail) {
        // document: https://www.smtpjs.com/
        const { SecureToken, Server, Host, Username, Password } = email_access_data;
        let mailApiContent = {
            SecureToken,
            Server,
            Host,
            Username,
            Password,
            To: SendToWhereValue,
            From: "dbdf0147@gmail.com",
            Subject: "Reset Password",
            Body: "http://localhost:5189/Home/Privacy",
        };
        console.log("mailApiContent: ", mailApiContent);
        let sendEmailRes = await Email.send(mailApiContent);
        console.log(sendEmailRes);

        if (sendEmailRes == "OK") {
            alert("send");
        }
    }
});
