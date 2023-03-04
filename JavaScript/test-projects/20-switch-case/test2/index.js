var letter = "m";
var action;

switch (letter) {
    case "m":
        action = "mining ore";
        break;
    case "s":
        action = "smithing";
        break;

    default:
        console.log("invalid letter");
        break;
}

console.log("I am " + action);
