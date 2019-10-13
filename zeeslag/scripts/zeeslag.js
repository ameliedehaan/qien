//loading DDOM        
window.onload = function() {


// grootte van Board

        rowsNum = 9;
        colsNum = 9;
        turnsNum = 0;
        squareSize = 40;

// hoeveel is geraakt = 0 in begin
        var Count = 0;

// container board
    var boardContainer = document.getElementById("zeeslagBoard");

    // rijen maken
    for (x = 0; x < colsNum; x++) {
        for (y = 0; y < rowsNum; y++) {

            //maakt een vak
            var square = document.createElement("div");
            boardContainer.appendChild(square);

            //geeft elk vak een ander id
            square.id = 'sq' + x + y;

            //maakt de hoeveelheid vakken die nodig zijn
            var topPosition = y * squareSize;
            var leftPosition = x * squareSize;

            square.style.top = topPosition + 'px';
            square.style.left = leftPosition + 'px';
        }
    }
// gameboard pre-defined
    var gameboard = [
        [1, 1, 1, 1, 1, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 1, 1, 1],
        [1, 0, 0, 1, 1, 1, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 1, 1, 1],
        [1, 1, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 1, 1, 1, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 1, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0],
        ]
        
// randomize board using Fisher-Yates on every reload
function shuffle(arrayboard) {
    var ctr = arrayboard.length, temp, index;

    while (ctr > 0) {
        index = Math.floor(Math.random() * ctr);
        ctr--;
        temp = arrayboard[ctr];
        arrayboard[ctr] = arrayboard[index];
        arrayboard[index] = temp;
    }
    return arrayboard;

}
console.log(shuffle(gameboard));
  

//let's play

var user = localStorage.getItem("key");
console.log(user);

document.getElementById("display").innerHTML = "Welkom " + user + ". Klik op een vierkant!";


boardContainer.addEventListener("click", sinkswim, false);

//geeft een nummer voor rij en kolom
function sinkswim(a) {
   // var squareclick = a.target.id;
    if (a.target !== a.currentTarget) {     
        var row = a.target.id.substring(2,3);
        var col = a.target.id.substring(3,4);
        console.log(row,col);
   

//is het raak of mis       
    if (gameboard[row][col] == 0) {
        console.log("miss"); 
        a.target.style.background = "blue";
        gameboard[row][col] = 3;
        document.getElementById("display").innerHTML = "Niet raak! Nog " + (27-Count) + " vierkanten over.";
        }
     
    else if (gameboard[row][col] == 1) {
        console.log("hit");
        a.target.style.background = "red";
        gameboard[row][col] = 2;
        Count ++;
        document.getElementById("display").innerHTML = "Raak! Nog " + (27-Count) + " vierkanten over.";

        if (Count == 27) {
            document.getElementById("display").innerHTML = "Je hebt gewonnen!";
            alert("Je hebt gewonnen! Nog een keer spelen?" );
            document.location.reload();
            } }

    else if (gameboard[row][col] > 1) {
    console.log("You've already hit this square!");  
        document.getElementById("display").innerHTML = "Je hebt al op deze vierkant geklikt! Nog " + (27-Count) + " vierkanten over.";}
   
    };
    a.stopPropagation();
};
};