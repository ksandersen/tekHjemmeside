/**
 * 
 * @param {*} option Switching information on "projekt.html"
 */
function show(option) {

    /**
     * DOM
     */
    generalt = document.getElementById("Generalt");
    how = document.getElementById("Hvordan");
    models = document.getElementById("Modeller");
    island = document.getElementById("Øen");

    var dom = [generalt, how, models, island];

    for (let i = 0; i < dom.length; i++) {
        if (i != option) {
            dom[i].style.display = "none";
        } else {
            dom[i].style.display = "block";
        }
        
    }
}