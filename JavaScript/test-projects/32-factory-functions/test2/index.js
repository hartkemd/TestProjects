
function createCar(make, model, numberOfWheels, numberOfDoors) {
    return {
        make,
        model,
        numberOfWheels,
        numberOfDoors,
        start() {
            console.log('starting...');
        }
    }
}

const car1 = createCar('Honda', 'Civic', 4, 4);
console.log(`${car1.make} ${car1.model}`);
