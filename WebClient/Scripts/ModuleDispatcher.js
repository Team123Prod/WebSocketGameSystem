class ModuleDispatcher {
    constructor() {
        this.authModule = new AuthModule();
    }
    Distribute(request) {
        switch (request.Module) {
            case "AuthModule":
                this.authModule.Dispach(request);
                break;
            case "ProfileModule":
                new ProfileModule().Dispach(request);
                break;
            case "GameModule":
                new GameModule().Dispach(request);
                break;
            case "MsgModule":
                new MsgModule().Dispach(request);
                break;
            case "RateModule":
                new RateModule().Dispach(request);
                break;
        }
    }
}