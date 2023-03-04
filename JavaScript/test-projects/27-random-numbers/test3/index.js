var maxValue = prompt("Enter max value for random number");

var random = Math.random() * maxValue;
random = Math.floor(random) + 1;
console.log(random);
