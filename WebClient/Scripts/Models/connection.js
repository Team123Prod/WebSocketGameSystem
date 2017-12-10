//var ws;
//class Connection {
//    constructor() {
//        if(ws === undefined) {
//            ws = new WebSocket("ws://localhost:8881/Server");

//            ws.onmessage = function (evt) {
//                var msg = JSON.parse(evt.data);
//                if (msg.login === login) {
//                    $(".state-game").text("Your tern...");
//                    ai(msg);
//                }
//                else {
//                    $(".state-game").text("Wait...");
//                }
//            };

//            ws.onopen = function () {
//                var s = s + "\nYou've connected to server";
//            };

//            ws.onclose = function () {
//                var s = s + "\nConnection was closed";
//            };

//            ws.onerror = function (m) {
//                console.log('Error connection');
//            };

//            this.send = function (req) {
//                var reqJson = JSON.stringify(req);
//                ws.send(reqJson);
//            };
//        }
//    }
//}


class Connection {
    constructor() {
        this.ws = new WebSocket("ws://localhost:8881/Server");

        this.ws.onmessage = function (evt) {
            var msg = evt.data;
            console.log(msg);
            if (msg.login) {
                //var msg = JSON.parse(evt.data);
                if (msg.login === login) {
                    $(".state-game").text("Your turn...");
                    ai(msg);
                }
                else {
                    $(".state-game").text("Wait...");
                }
            }
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


