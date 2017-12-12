class Request {
	constructor(module, cmd, args) {
		debugger
        this.cmd = cmd;
        this.module = module;
        this.args = args;
        this.token = TokenProvider.getToken();
    }
}
