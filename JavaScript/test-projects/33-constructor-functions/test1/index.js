
function Circle(radius, x, y) {
    this.radius = radius;
    this.x = x;
    this.y = y;
    this.draw = function() {
        console.log('drawing...');
    }
}

const circle1 = new Circle(1, 1, 1);
circle1.draw();
