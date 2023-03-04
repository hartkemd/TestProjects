console.log(isLeapYear(2000));

function isLeapYear(year) {
    var output = "";
    
    if (year % 4 === 0) {
        if (year % 100 === 0) {
            if (year % 400 === 0) {
                output = "Leap year.";
            }
            else {
                output = "Not leap year.";
            }
        }
        else {
            output = "Leap year.";
        }
    }
    else {
        output = "Not leap year.";
    }
    return output;
}
