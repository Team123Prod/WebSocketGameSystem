var ws;
class Connection {

    if(ws === undefined) {
        ws = new WebSocket("ws://localhost:8881/Server");

        ws.onmessage = function (evt) {
            var msg = JSON.parse(evt.data);
            if (msg.login == login) {
                $(".state-game").text("Your tern...");
                ai(msg);
            }
            else {
                $(".state-game").text("Wait...");
            }
        };

        ws.onopen = function () {
            var s = s + "\nYou've connected to server";
        };

        ws.onclose = function () {
            var s = s + "\nConnection was closed";
        };

        ws.onerror = function (m) {
            console.log('Error connection');
        };

        this.send = function (req) {
            var reqJson = JSON.stringify(req);
            ws.send(reqJson);
        };

    }
}
	
		
