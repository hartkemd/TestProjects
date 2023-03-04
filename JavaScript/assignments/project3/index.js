
function fizzBuzz(input) {
    let output = '';

    if (typeof input !== 'number') {
        output = 'not a number';
        return output;
    }

    if (input % 3 === 0) output += 'fizz';
    if (input % 5 === 0) output += 'buzz';
    
    if (output === '') output = input;

    return output;
}

console.log(fizzBuzz(1));
console.log(fizzBuzz(3));
console.log(fizzBuzz(5));
console.log(fizzBuzz(15));
console.log(fizzBuzz('hello'));
