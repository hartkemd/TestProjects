function addFive(value) {
    if (typeof value === 'number')
        return value + 5;
    else
        return parseInt(value) + 5;
}
console.log(addFive(5));
