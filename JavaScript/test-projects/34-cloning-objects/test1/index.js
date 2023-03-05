
const circle = {
    radius: 1,
    draw() {
        console.log('drawing...');
    }
}

const anotherCircle = { ...circle };
console.log(anotherCircle);
