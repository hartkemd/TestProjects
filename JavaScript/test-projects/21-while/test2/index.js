var i = 1;

while (i <= 6) {
    console.log(getRandom());
    i++;
}

function getRandom() {
    var random = Math.random() * 100;
    random = Math.floor(random) + 1;
    return random;
}
