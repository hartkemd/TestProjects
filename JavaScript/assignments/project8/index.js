
console.log(sum(10));

function sum(limit) {
    let output = 0;

    for (let i = 0; i <= limit; i++) {
        if ((i % 3 === 0) || (i % 5 === 0)) output += i;
    }

    return output;
}
