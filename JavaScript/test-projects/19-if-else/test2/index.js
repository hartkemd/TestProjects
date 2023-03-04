var season = prompt("What season is it?");
season = season.toLowerCase();

var foodToEat;
if (season === "spring") {
    foodToEat = "strawberries";
} else if (season === "summer") {
    foodToEat = "watermelon";
} else if (season === "fall" || season === "autumn") {
    foodToEat = "sweet potatoes";
}

console.log("Eat " + foodToEat);
