
const blogPost1 = {
    title: 'title',
    body: 'body',
    author: 'Mark',
    views: 0,
    comments: [{author: 'Tim', body: 'body2'},
               {author: 'Mosh', body: 'body3'}],
    isLive: false
};

const post = new Post('title', 'body', 'Mark');
console.log(post);

function Post(title, body, author) {
    this.title = title;
    this.body = body;
    this.author = author;
    this.views = 0;
    this.comments = [];
    this.isLive = false;
}
