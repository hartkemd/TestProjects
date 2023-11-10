const express = require("express");
const https = require("https");
const bodyParser = require("body-parser");

const app = express();

app.use(bodyParser.urlencoded({extended: true}));

app.post("/", function(req, res) {
    const firstName = "Mark";
    const lastName = "Hartkemeyer";
    const email = "mark@email.com";

    const data = {
        members: [
            {
                email_address: email,
                status: "subscribed",
                merge_fields: {
                    FNAME: firstName,
                    LNAME: lastName
                }
            }
        ]
    };

    const jsonData = JSON.stringify(data);
    const url = "https://us4.api.mailchimp.com/3.0/lists/12345";

    const options = {
        method: "POST",
        auth: "mark:123456-us4"
    }

    const request = https.request(url, options, function(response) {
        response.on("data", function(data) {
            console.log(JSON.parse(data));
        })
    })

    request.write(jsonData);
    request.end();
});

app.listen(3000, function() {
    console.log("Server is running on port 3000.");
});
