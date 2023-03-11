
let customers2: { id?: number, firstName?: string }[] = [{}];

console.log(customers2[0]);
console.log(customers2[0].firstName);

customers2.push({ id: 0, firstName: 'Mark'});
console.log(customers2[1]);
