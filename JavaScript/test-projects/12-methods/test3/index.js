function Car(make, model, color, price) {
    this.make = make;
    this.model = model;
    this.color = color;
    this.price = price;
    this.start = function() {
        console.log("Now starting");
    }
    this.stop = function() {
        console.log("Stopping...");
    }
}

var corolla = new Car("Toyota", "Corolla", "gray", 15000);
corolla.start();
corolla.stop();
