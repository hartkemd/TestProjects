
function createWeapon(maxDamage, type, weight) {
    return {
        maxDamage,
        type,
        weight,
    }
}

function printWeapon(weapon) {
    for (let key in weapon)
        console.log(key, weapon[key]);
}

const dagger = createWeapon(5, 'melee', 1);
printWeapon(dagger);
