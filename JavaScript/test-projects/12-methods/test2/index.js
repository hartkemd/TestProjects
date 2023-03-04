function Crop(name, isAnnual, plantingDepth) {
    this.name = name;
    this.isAnnual = isAnnual;
    this.plantingDepth = plantingDepth;
    this.grow = function() {
        console.log("I am growing!");
    }
}

var peppermint = new Crop("peppermint", false, 2);
peppermint.grow();
