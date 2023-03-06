
function processData(keepGoing: boolean | string): void {
    if (typeof keepGoing === 'boolean')
        if (keepGoing) console.log('keep processing data...');
        else console.log('stop processing!');
    else {
        let boolValue = keepGoing == 'true';
        if (boolValue)
            console.log('keep processing data...');
        else console.log('stop processing!');
    }
}

processData(true);
processData('true');
processData(false);
processData('false');
