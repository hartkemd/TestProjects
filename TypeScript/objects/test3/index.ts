
let employee3: {
    readonly id: number,
    firstName: string,
    retire: (date: Date) => void } = {
        id: 0,
        firstName: 'Mark',
        retire: (date: Date) => {
            console.log(date);
        }
    };
