
showNumbers(10);

function showNumbers(limit) {
    for (let i = 0; i <= limit; i++) {
        let message;

        if (i % 2 === 0) message = 'Even';
        else message = 'Odd';

        console.log(i, message);
    }
}
