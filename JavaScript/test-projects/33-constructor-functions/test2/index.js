
function Car(make, model, year) {
    this.make = make;
    this.model = model;
    this.year = year;
    this.start = function() {
        console.log('starting...');
    }
}

const car1 = new Car('Honda', 'Fit', 2014);
console.log(`${car1.make} ${car1.model} ${car1.year}`);
