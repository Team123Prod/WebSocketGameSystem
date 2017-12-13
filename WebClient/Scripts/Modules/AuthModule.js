class AuthModule {
    Dispach(response) {
        switch (response.Cmd) {
            case "Login":
                console.log(response.Token);
                TokenProvider.saveToken(response.Token);
                break;
            case "Logout":
                break;
            case "Registration":
                break;
        }
    }
}