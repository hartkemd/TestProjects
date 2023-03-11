
type Customer = {
    birthday: Date
};

function getCustomerFromDB(id: number): Customer | null {
    return id === 0 ? null : { birthday: new Date };
}

let customer = getCustomerFromDB(0);
console.log(customer);
console.log(customer?.birthday);

customer = getCustomerFromDB(1);
console.log(customer);
console.log(customer?.birthday);
