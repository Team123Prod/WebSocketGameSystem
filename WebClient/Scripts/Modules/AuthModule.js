class AuthModule {

    Dispach(response) {
        switch (response.Cmd) {
            case "Login":
                console.log("Login. response token = " + response.Token);
                TokenProvider.saveToken(response.Token);
                break;
            case "Logout":
                break;
            case "Registration":
                console.log("Registration. response token = " + response.Token);
                TokenProvider.saveToken(response.Token);
                break;
        }
    }

    static getAuthData() {
        var login = $("#authLogin");
        var psw = $("#authPassword");
        return {
            Login: login.val(),
            Password: psw.val()
        }
    }

    static getRegistrationData() {
        var login = $("#registrationLogin");
        var psw = $("#registrationPassword");
        var email = $('#email');
        return {
            Login: login.val(),
            Password: psw.val(),
            Email: email.val()
        }
    }
}
