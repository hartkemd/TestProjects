
checkSpeed(70);
checkSpeed(74);
checkSpeed(80);
checkSpeed(200);

function checkSpeed(speed) {
    const speedLimit = 70;
    const kmphPerPoint = 5;
    const pointsForLicenseSuspension = 12;

    if (speed < speedLimit) {
        console.log('Ok');
        return;
    }

    let speedOverLimit = speed - speedLimit;
    if (speedOverLimit >= kmphPerPoint) {
        const points = Math.floor(speedOverLimit / kmphPerPoint);
        if (points >= pointsForLicenseSuspension) {
            console.log('License suspended');
        }
        else console.log(points + ' points');
    }
    else console.log('Ok');
}
