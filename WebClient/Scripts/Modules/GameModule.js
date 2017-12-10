var ws;

function GameModule(request) {
    switch (request.cmd) {
		case "CreateRoom":
			CreateRoom(request);
            break;
        case "Move":
            Move(request);
            break;
    }
}

function CreateRoom(request)
{
    var reqJson = JSON.stringify(new Request("GameModule", "GameStarted", request.args))
    ws = new Connection();
    ws.send(reqJson);
}

function Move(request) {
    var reqJson = JSON.stringify(new Request("GameModule", "Move", request.args))
    ws = new Connection();
    ws.send(reqJson);
}
