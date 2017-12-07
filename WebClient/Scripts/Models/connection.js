var ws = new WebSocket("ws://localhost:8881/Server");

	ws.onmessage = function (evt) {
		var msg = JSON.parse(evt.data);
        ai(msg);
    };

    ws.onopen = function () {
         var s = s + "\nYou've connected to server";
    };

    ws.onclose = function () {
        var s = s + "\nConnection was closed";;
    };

	ws.send = function(req) {
		var reqJson = JSON.stringify(req);
        ws.send(reqJson);
    };

	 ws.onerror = function(m) {
        console.log('Ошибка подключения');
    };
