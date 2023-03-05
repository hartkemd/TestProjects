
function createCircle(radius, x, y) {
    return {
        radius,
        x,
        y,
        draw() {
            console.log('drawing...');
        }
    }
}

const circle1 = createCircle(1, 1, 1);
console.log(circle1.radius);
circle1.draw();

const circle2 = createCircle(2, 1, 1);
console.log(circle2.radius);
circle2.draw();
