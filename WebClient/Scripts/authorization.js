var ws = new Connection();

$('#submit').click(sendAuthRequest);

function getAuthData() {
    var login = $("#login");
    var psw = $("#pwd");
    return {
        Login: login.val(),
        Password: psw.val()
    }
}

function sendAuthRequest() {
    var request = new Request("AuthModule", "Login", getAuthData());
    var json = JSON.stringify(request);
    ws.send(json);
    return false;
}


