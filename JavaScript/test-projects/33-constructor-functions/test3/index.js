
function Weapon(maxDamage, type, weight) {
    this.maxDamage = maxDamage;
    this.type = type;
    this.weight = weight;
    this.attack = function() {
        console.log('attacking...');
    }
}

const dagger = new Weapon(5, 'melee', 1);
dagger.attack();
