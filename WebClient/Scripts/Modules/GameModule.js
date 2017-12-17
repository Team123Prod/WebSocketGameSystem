class GameModule {
   GameModule(request) {
	switch (request.cmd) {
		case "GameResponse":
			CreateRoom(request);
			break;
		case "Move":
			Move(request);
			break;
	}
}

   CreateRoom(request) {
	   changeSettingsPlayer(request.args.mark, request.args.idRoom);
	}

	Move(request) {
		move(id);
	}
}