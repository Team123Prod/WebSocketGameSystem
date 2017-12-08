var ws;
class Connection {

	if (ws === undefined) {
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

	    };

	    ws.onclose = function () {

			};

			ws.onerror = function(m) {
	        console.log('Ошибка подключения');
			};
	}
	
		this.send = function (req) {
		 var reqJson = JSON.stringify(req);
		 ws.send(reqJson);
	 	};
 }
