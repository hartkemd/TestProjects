function processData(keepGoing) {
    if (typeof keepGoing === 'boolean')
        if (keepGoing)
            console.log('keep processing data...');
        else
            console.log('stop processing!');
    else {
        var boolValue = keepGoing == 'true';
        if (boolValue)
            console.log('keep processing data...');
        else
            console.log('stop processing!');
    }
}
processData(true);
processData('true');
processData(false);
processData('false');
