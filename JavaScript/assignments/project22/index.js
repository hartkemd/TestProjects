
const numbers = [1, 2, 3, 4];

const max = getMax(numbers);

console.log(max);

function getMax(array) {
    if (array.length === 0) return undefined;
    
    // let output = array[0];
    
    // for (let i in array)
    //     if (array[i] > output)
    //         output = array[i];
    
    // return output;

    return array.reduce((a, b) => (a > b) ? a : b);
}
