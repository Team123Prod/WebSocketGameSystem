class TokenProvider {
    static getToken() {
        return $.cookie("token") ? $.cookie("token") : "";
    }
    static saveToken(token) {
        $.cookie("token", token);
    }
}