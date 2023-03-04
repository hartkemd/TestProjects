var num1 = getNumber();
var num2 = getNumber();
var result = subtract(num1, num2);
console.log(num1 + " - " + num2 + " = " + result);

function getNumber() {
    var number = prompt("Please enter a number");
    return number;
}

function subtract(num1, num2) {
    return num1 - num2;
}
