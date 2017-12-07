
var t = new Array(9);
var isBot = false;
var player = null;
function go(id) {
	send(new Request('cmd', 'module', 1,  player, id));
}
function ai(id) {
  t[id] ? ai() : move(id, 'ai');
}
function aiBot() {
  var id = Math.floor(Math.random() * 9);
  t[id] ? aiBot() : move(id, 'ai');
}

function checkEnd() {
  if (t[0]==='ai' && t[1]==='ai' && t[2]==='ai' || t[0]==='player' && t[1]==='player' && t[2]==='player')  return true;
  if (t[3]==='ai' && t[4]==='ai' && t[5]==='ai' || t[3]==='player' && t[4]==='player' && t[5]==='player')  return true;
  if (t[6]==='ai' && t[7]==='ai' && t[8]==='ai' || t[6]==='player' && t[7]==='player' && t[8]==='player')  return true;
  if (t[0]==='ai' && t[3]==='ai' && t[6]==='ai' || t[0]==='player' && t[3]==='player' && t[6]==='player')  return true;
  if (t[1]==='ai' && t[4]==='ai' && t[7]==='ai' || t[1]==='player' && t[4]==='player' && t[7]==='player')  return true;
  if (t[2]==='ai' && t[5]==='ai' && t[8]==='ai' || t[2]==='player' && t[5]==='player' && t[8]==='player')  return true;
  if (t[0]==='ai' && t[4]==='ai' && t[8]==='ai' || t[0]==='player' && t[4]==='player' && t[8]==='player')  return true;
  if (t[2]==='ai' && t[4]==='ai' && t[6]==='ai' || t[2]==='player' && t[4]==='player' && t[6]==='player')  return true;
  if(t[0] && t[1] && t[2] && t[3] && t[4] && t[5] && t[6] && t[7] && t[8]) return true;
}

function move(id, role) {
  if(t[id]) return false;
  t[id] = role;
  document.getElementById(id).className = 'cell ' + role;
  var checkBox = document.getElementById('isBot');
  if(checkBox.checked){
	!checkEnd() ? (role === 'player') ? aiBot() : null : reset()
  }else{
	!checkEnd() ? (role === 'player') ? go(id) : null : reset()
  }
}

function reset() {
  alert("Игра окончена!");
}
function reload() {
  location.reload();
}
function findPlayer() {
	FindGame('Open');
	debugger
	$(".state-game").text("Wait...");
	//document.getElementById('.state-game').value = "Wait...";
  var login = document.getElementById('login').value;
  player = new Player(login);
  send(new Request('connect', 'no', 1, player, 0));
}
function start() {
  $(".container").attr('disabled','disabled');
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
