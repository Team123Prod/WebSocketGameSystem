class Connection {
    constructor() {
        this.ws = new WebSocket("ws://localhost:8881/Server");

        this.ws.onmessage = function (evt) {
            var response = JSON.parse(evt.data);

            console.log(response);

            var moduleDispatcher = new ModuleDispatcher();
            moduleDispatcher.Distribute(response);

            //if (msg.login) {
            //    //var msg = JSON.parse(evt.data);
            //    if (msg.login === login) {
            //        $(".state-game").text("Your turn...");
            //        ai(msg);
            //    }
            //    else {
            //        $(".state-game").text("Wait...");
            //    }
            //}
        };

        this.ws.onopen = function () {
            var s = s + "\nYou've connected to server";
        };

        this.ws.onclose = function () {
            var s = s + "\nConnection was closed";
        };

        this.ws.onerror = function (m) {
            console.log('Error connection');
        };

    }
    send(req) {
        //var reqJson = JSON.stringify(req);
        //this.ws.send(reqJson);
        this.ws.send(req);
    }
}


