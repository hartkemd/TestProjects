var input = prompt("Please enter a number from 0 to 2");
var response;

switch (input) {
    case "0":
        response = "That's the first number";
        break;
    case "1":
        response = "That's the second number";
        break;
    case "2":
        response = "That's the third number";
        break;

    default:
        response = "Input was outside the range of values";
        break;
}

alert(response);
