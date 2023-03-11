
type Customer3 = {
    id: number,
    firstName: string
}

let customers3: Customer3 [] | null = null;

console.log(customers3?.[0]);

customers3 = [];
customers3.push({ id: 0, firstName: 'Mark'});
console.log(customers3?.[0]);
