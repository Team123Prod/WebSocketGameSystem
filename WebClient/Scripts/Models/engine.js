var isBot = false;
var player = null;
var role = "X";
var con = new Connection();
function go(id) {
	document.getElementById(id).className = 'cell ' + role;
	con.send(JSON.stringify(new Request('GameModule', 'Move',  Array(player, id))));
}

function move(id) {
  document.getElementById(id).className = 'cell ' + role;
}
function changeSettingsPlayer(r, idRoom) {
	role = r;
}

function findPlayer() {
    debugger
	FindGame('Open');
	debugger
	$(".state-game").text("Wait...");
	//document.getElementById('.state-game').value = "Wait...";
  var login = document.getElementById('login').value;
  player = new Player(login);
  con.send(JSON.stringify(new Request('GameModule', 'CreateRoom', Array(player))));
}
function FindGame(cmd) {
	switch (cmd) {
		case 'XO':
			document.location.href = 'game.html';
			break;
		case 'Open':
			ShowGame();
			break;

	}
}
