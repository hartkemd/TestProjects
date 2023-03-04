fibonacciGenerator(8);

function fibonacciGenerator(n) {
    var output = [];
    
    for (var i = 0; i < n; i++) {
        if (i <= 1) {
            output.push(i);
        }
        else {
            var sumOfPreviousTwo;
            sumOfPreviousTwo = output[i - 1] + output[i - 2];
            output.push(sumOfPreviousTwo);
        }
    }

    return output;
}
