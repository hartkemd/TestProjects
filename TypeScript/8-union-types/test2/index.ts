
function addFive(value: number | string): number {
    if (typeof value === 'number')
        return value + 5;
    else
        return parseInt(value) + 5;
}

console.log(addFive(5));
