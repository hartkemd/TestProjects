
const movies = [
    {title: 'a', year: 2018, rating: 4.5},
    {title: 'b', year: 2018, rating: 4.7},
    {title: 'c', year: 2018, rating: 3},
    {title: 'd', year: 2017, rating: 4.5},
];

// Get all movies in 2018 with rating > 4
// Sort them by rating in desc order
// Display only their title property (should be: b, a)

const result = movies.filter(x => x.year === 2018 && x.rating > 4)
                     .sort((a, b) => a.rating - b.rating)
                     .reverse()
                     .map(x => x.title);

console.log(result);
