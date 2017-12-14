class Connection {
    constructor() {
        this.ws = new WebSocket("ws://localhost:8881/Server");
        var moduleDispatcher = new ModuleDispatcher();

        this.ws.onmessage = function (evt) {
            var response = JSON.parse(evt.data);

            console.log("onmessage. Response = " + response);

            moduleDispatcher.Distribute(response);
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

        this.addEventHandlers();

    }

    send(req) {
        this.ws.send(req);
    }

    addEventHandlers() {
        var self = this;
        $(document).ready(function () {
            var sendAuthReq = self.sendAuthRequest.bind(self);
            var sendRegistrationReq = self.sendRegistrationRequest.bind(self);
            $('#authSubmit').click(sendAuthReq);
            $('#registrationSubmit').click(sendRegistrationReq);
        });
    }

    sendAuthRequest() {
        var request = new Request("AuthModule", "Login", AuthModule.getAuthData());
        var json = JSON.stringify(request);
        this.send(json);
        return false;
    }

    sendRegistrationRequest() {
        var request = new Request("AuthModule", "Registration", AuthModule.getRegistrationData());
        var json = JSON.stringify(request);
        this.send(json);
        return false;
    }
}