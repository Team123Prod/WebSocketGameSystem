var ws = new WebSocket("ws://localhost:8881/Server");

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
         console.log("\nYou've connected to server");
    };

    ws.onclose = function () {
        console.log("\nConnection was closed");
	};

	ws.onerror = function(m) {
        console.log('Ошибка подключения');
	};
	var send = function(req) {
		var reqJson = JSON.stringify(req);
        ws.send(reqJson);
    };

	//this.send = function (req) {
	//	 var reqJson = JSON.stringify(req);
	//	 ws.send(reqJson);
	// };
