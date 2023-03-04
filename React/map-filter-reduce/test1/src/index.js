var numbers = [3, 56, 2, 48, 5];

const doubledNumbers = numbers.map(function (x) {
  return x * 2;
});
console.log(doubledNumbers);

const filteredNumbers = numbers.filter(function (x) {
  return x > 10;
});
console.log(filteredNumbers);

const reducedNumbers = numbers.reduce(function (accumulator, x) {
  return accumulator + x;
});
console.log(reducedNumbers);

const number = numbers.find(function (x) {
  return x > 10;
});
console.log(number);

//FindIndex - find the index of the first item that matches.
const index = numbers.findIndex(function (x) {
  return x > 10;
});
console.log(index);
