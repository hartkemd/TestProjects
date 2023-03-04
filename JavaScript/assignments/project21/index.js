
const numbers = [1, 2, 3, 4, 1];

const count = countOccurrences(numbers, 1);

console.log(count);

function countOccurrences(array, searchElement) {
    // let output = 0;

    // for (let i in array)
    //     if (array[i] === searchElement)
    //         output++;

    // return output;

    return array.reduce((accumulator, currentValue) => {
        const occurrence = (currentValue === searchElement) ? 1 : 0;
        return accumulator + occurrence;
    }, 0);
}
