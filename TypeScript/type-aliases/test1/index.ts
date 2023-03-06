
type Employee = {
    readonly id: number,
    firstName: string,
    retire: (date: Date) => void
}

const employee: Employee = {
    id: 0,
    firstName: 'Mark',
    retire: (date: Date) => {
        console.log(date);
    }
}
