function getCustomerFromDB(id) {
    return id === 0 ? null : { birthday: new Date };
}
var customer = getCustomerFromDB(0);
console.log(customer);
console.log(customer === null || customer === void 0 ? void 0 : customer.birthday);
customer = getCustomerFromDB(1);
console.log(customer);
console.log(customer === null || customer === void 0 ? void 0 : customer.birthday);
