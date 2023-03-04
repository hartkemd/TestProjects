
const numbers = [1, 2, 3, 4, 1];

try {
    const count = countOccurrences(false, 1);
    console.log(count);
} catch (error) {
    console.log(error);
}

function countOccurrences(array, searchElement) {
    if (Array.isArray(array) === false)
        throw new Error('Argument is not an array.');

    return array.reduce((accumulator, currentValue) => {
        const occurrence = (currentValue === searchElement) ? 1 : 0;
        return accumulator + occurrence;
    }, 0);
}
