
function greet(name: string | null) {
    if (name)
        console.log(`Hello, ${name}!`);
    else
        console.log('Hello!');
}

greet('Mark');
greet(null);
