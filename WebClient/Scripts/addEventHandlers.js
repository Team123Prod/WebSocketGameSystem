var ws = new Connection();

$('#authSubmit').click(sendAuthRequest);

function getAuthData() {
    var login = $("#authLogin");
    var psw = $("#authPassword");
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

$('#registrationSubmit').click(sendRegistrationRequest);

function getRegistrationData() {
    var login = $("#registrationLogin");
    var psw = $("#registrationPassword");
    var email = $('#email');
    return {
        Login: login.val(),
        Password: psw.val(),
        Email: email.val()
    }
}

function sendRegistrationRequest() {
    var request = new Request("AuthModule", "Registration", getRegistrationData());
    var json = JSON.stringify(request);
    ws.send(json);
    return false;
}
