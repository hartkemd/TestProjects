
const marks = [100, 95, 90];

console.log(calculateGrade(marks));

function calculateGrade(array) {
    const average = calculateAverage(array);
    let grade = '';

    if (average >= 90) grade = 'A';
    else if (average >= 80) grade = 'B';
    else if (average >= 70) grade = 'C';
    else if (average >= 60) grade = 'D';
    else grade = 'F';

    return grade;
}

function calculateAverage(array) {
    let output = null;
    let sum = 0;

    for (let i of array) sum += i;

    output = sum / array.length;
    return output;
}
