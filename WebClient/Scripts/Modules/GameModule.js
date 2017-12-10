class GameModule {
    Dispach(request) {
        this.ws = new Connection();
        switch (request.cmd) {
            case "startGame":
                Start(request);
                break;
            case "move":
                Move(request);
                break;
        }
    }

    Start(request) {
        var reqJson = JSON.stringify(new Request("GameModule", "GameStarted", request.args));
        this.ws.send(reqJson);
    }

    Move(request) {
        var reqJson = JSON.stringify(new Request("GameModule", "move", request.args));
        this.ws.send(reqJson);
    }
}