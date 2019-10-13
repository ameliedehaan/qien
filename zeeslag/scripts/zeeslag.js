//loading DDOM        
window.onload = function() {

//username in localstorage

function createUser() {
    var userName = document.getElementById("username").value;
   // console.log(userName);
    var userJSON = JSON.stringify(userName)
   // console.log(userJSON);
    localStorage.setItem("username", userJSON);
    window.location.replace("zeeslag.html");
} ;

//display naam
function welcome() {
    var player = localStorage.getItem("username");
    var Parse = JSON.parse(player);
    console.log(Parse);
    var welcomediv = document.getElementById("welcome");
    welcomediv.innerHTML = "Hoi " + Parse + "en welkom bij dit spel!";
    console.log(welcomediv);
};

// grootte van Board

        rowsNum = 6;
        colsNum = 6;
        turnsNum = 0;
        squareSize = 50;

// defining variables
// 0 = zee, 1 = schip 2 = mis 3 = raak
// soorten schepen    
        var Carrier = [1, 1, 1, 1, 1];

        var Battleship = [1, 1, 1, 1];

        var Cruiser = [1, 1, 1];

// totaal vierkanten = 36, boten = 15

        var Ships = Carrier.concat(Cruiser, Battleship);

// maken van random Array
        var leftover = ((rowsNum*colsNum)-(Ships.length));
        var boardleftover = new Array(leftover).fill(0);

//shuffle function
        var boardadded = [Carrier, Battleship, Cruiser, boardleftover];
        console.log(boardadded);

        function shuffle(array) {
            var currentIndex = array.length, temporaryValue, randomIndex;
          
            // While there remain elements to shuffle...
            while (0 !== currentIndex) {
          
              // Pick a remaining element...
              randomIndex = Math.floor(Math.random() * currentIndex);
              currentIndex -= 1;
          
              // And swap it with the current element.
              temporaryValue = array[currentIndex];
              array[currentIndex] = array[randomIndex];
              array[randomIndex] = temporaryValue;
            }
          
            return array;
          }

        arr = shuffle(boardadded);
        arr = arr.concat();
    console.log(arr);

        while (arr.length > 0) {
            portions = arr.splice(0,6)
            console.log(portions);
        }

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
        [1, 1, 1, 1, 1, 0],
        [1, 0, 0, 0, 0, 0],
        [1, 0, 0, 1, 1, 1],
        [1, 0, 0, 0, 0, 0],
        [1, 1, 1, 0, 0, 0],
        [0, 0, 0, 1, 1, 1]
        ]
        
// randomize board

  

//function randomize() 
//need to figure out

//let's play
document.getElementById("display").innerHTML = "Click on a square!";


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
        document.getElementById("display").innerHTML = "It's a miss!";
        }
     
    else if (gameboard[row][col] == 1) {
        console.log("hit");
        a.target.style.background = "red";
        gameboard[row][col] = 2;
        document.getElementById("display").innerHTML = "It's a hit!";
        Count ++;
        if (Count == 17) {
            document.getElementById("display").innerHTML = "You've won!";
            console.log("Win!");
            } }

    else if (gameboard[row][col] > 1) {
    console.log("You've already hit this square!");  
        document.getElementById("display").innerHTML = "You've already hit this square!";}
   
    };
    a.stopPropagation();
};
};