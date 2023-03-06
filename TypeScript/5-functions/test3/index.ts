
function calculateTax(income: number, taxYear:number = 2022): number {
    if (taxYear < 2022)
        return income * 0.2;
    return income * 0.3;
}

console.log(calculateTax(50_000));
