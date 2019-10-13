//remember username 

var naam = {};
function speler() {
naam = document.getElementById("username").value;
localStorage.setItem("key", naam);
var user = localStorage.getItem("key");
console.log(user);
window.location.replace("zeeslag.html");
};