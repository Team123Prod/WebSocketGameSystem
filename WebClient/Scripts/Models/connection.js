var ws = new WebSocket("ws://localhost:8881/Server");

	ws.onmessage = function (evt) {
		debugger
		var msg = JSON.parse(evt.data);
        ai(msg);
    };
    ws.onopen = function () {
         var s = s + "\nYou've connected to server";
    };
    ws.onclose = function () {
        var s = s + "\nConnection was closed";;
    };
	this.send = function(req) {
		debugger
		var reqJson = JSON.stringify(req);
        ws.send(reqJson);
    };
	 ws.onerror = function(m) {
        console.log('Ошибка подключения');
    };
