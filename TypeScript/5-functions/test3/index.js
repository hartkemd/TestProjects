function calculateTax(income, taxYear) {
    if (taxYear === void 0) { taxYear = 2022; }
    if (taxYear < 2022)
        return income * 0.2;
    return income * 0.3;
}
console.log(calculateTax(50000));
