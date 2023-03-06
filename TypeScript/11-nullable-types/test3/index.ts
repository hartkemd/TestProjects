
function getLength(word: string | undefined) {
    if (typeof word === 'string')
        return word.length;
    else
        return 0;
}

console.log(getLength('Hello'));
console.log(getLength(undefined));
