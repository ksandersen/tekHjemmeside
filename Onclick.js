// JavaScript source code
var Colabool = new Boolean(false)
var pris = 0;
let cola = document.getElementById('Cola');
let prisKnap = document.getElementById('Pris');
cola.addEventListener('click', Colafunction());


public function Colafunction(){
    alert('Test');
    if (Colabool == false) {
        Colabool = new Boolean(true);
        pris = pris + cola.innerText;
        prisKnap.innerText = pris + "kr"; 
    } else {
        Colabool = new Boolean(false);
        pris = pris - cola.innerText;
        prisKnap.innerText = pris + "kr";
    }

};