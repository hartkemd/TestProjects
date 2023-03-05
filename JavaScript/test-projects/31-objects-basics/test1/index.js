
const circle = {
    radius: 1,
    location: {
        x: 1,
        y: 1
    },
    isVisible: true,
    draw: function() {
        console.log('drawing...');
    }
}

circle.location.x = 2;
circle.location.y = 2;
circle.draw();
