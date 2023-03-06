
type Person = {
    firstName: string
}

type User = {
    userID: string
}

type Employee = Person & User;

let employee: Employee = {
    firstName: 'Mark',
    userID: 'mh0001'
}
