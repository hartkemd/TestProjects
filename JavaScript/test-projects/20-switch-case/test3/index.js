var weatherConditions = ["sunny", "cloudy", "rainy", "thunderstorms"];
var sunlight = 0;
var water = 0;

for (let i = 0; i < weatherConditions.length; i++) {
    switch (weatherConditions[i]) {
        case "sunny":
            sunlight += 10;
            break;
        
        case "cloudy":
            sunlight += 5;
            break;
    
        case "rainy":
            water += 10;
            break;
    
        default:
            console.log("Invalid weather condition");
            break;
    }
}

console.log("Total sunlight: " + sunlight);
console.log("Total water: " + water);
