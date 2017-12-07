using GameSystem.Models;
using GameSystem.Modules;

namespace GameSystem.Controllers
{
    public class ModulesDispatcher
    {
        public ModulesDispatcher()
        {

        }
        public void Distribute(Request request)
        {
            switch (request.Module)
            {
                case "AuthModule":
                    new AuthModule().Dispach(request);
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
                default:
                    break;
            }
        }
    }
}
