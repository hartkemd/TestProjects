document.addEventListener("keydown", function(event) {
    document.querySelector("p").innerHTML = event.key + " key was pressed";
});
