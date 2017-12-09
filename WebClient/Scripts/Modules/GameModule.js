var ws;

function GameModule(request) {
    switch (request.cmd) {
        case "startGame":
            Start(request);
            break;
        case "move":
            Move(request);
            break;
    }
}

function Start(request)
{
    var reqJson = JSON.stringify(new Request("GameModule", "GameStarted", request.args))
    ws = new Connection();
    ws.send(reqJson);
}

function Move(request) {
    var reqJson = JSON.stringify(new Request("GameModule", "move", request.args))
    ws = new Connection();
    ws.send(reqJson);
}
