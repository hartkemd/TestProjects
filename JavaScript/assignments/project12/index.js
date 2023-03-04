
const address = createAddress('Cincinnati', 'OH', '45201');
console.log(address);

const address2 = new Address('Columbus', 'OH', '43001');
console.log(address2);

function createAddress(city, state, zipCode) {
    return {
        city,
        state,
        zipCode
    };
}

function Address(city, state, zipCode) {
    this.city = city;
    this.state = state;
    this.zipCode = zipCode;
}
