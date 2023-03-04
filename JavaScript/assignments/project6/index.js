
const array = [0, 1, 2, NaN];

console.log(countTruthy(array));

function countTruthy(array) {
    let output = 0;
    for (let index of array) {
        if (index) output++;
    }
    return output;
}
