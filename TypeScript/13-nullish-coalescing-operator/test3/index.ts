
let firstName: string | null = null;
let person = {
    firstName: firstName ?? 'Mike'
}

console.log(person.firstName);
