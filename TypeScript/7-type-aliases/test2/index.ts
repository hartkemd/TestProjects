
type Car = {
    make: string,
    model: string,
    start: () => void
}

const car1: Car = {
    make: 'Honda',
    model: 'Civic',
    start: () => {
        console.log('starting...');
    }
}
