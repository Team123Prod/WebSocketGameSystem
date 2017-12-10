class AuthModule {
    Dispach(request) {
        switch (request.Cmd) {
            case "Login":
                console.log(request.Module + request.Cmd);
                break;
            case "Logout":
                break;
            case "Registration":
                break;
        }
    }
}