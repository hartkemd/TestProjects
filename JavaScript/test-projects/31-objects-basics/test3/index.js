
const weapon = {
    damage: 5,
    critChance: 0.12,
    weight: 1,
    type: 'melee',
    name: 'dagger',
    attack() {
        let random = Math.random() * this.damage;
        random = Math.floor(random) + 1;
        console.log(`You strike your target for ${random} points of damage.`);
    }
}

weapon.attack();
