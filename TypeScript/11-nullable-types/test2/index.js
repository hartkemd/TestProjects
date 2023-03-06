function getPrice(itemName) {
    if (typeof itemName === 'string')
        return 10;
    else
        return 0;
}
console.log(getPrice('toothbrush'));
console.log(getPrice(null));
