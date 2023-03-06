
type Weapon = {
    damage: number,
    type: string,
    attack: () => void
}

const dagger: Weapon = {
    damage: 5,
    type: 'melee',
    attack: () => {
        console.log('attacking...');
    }
}
