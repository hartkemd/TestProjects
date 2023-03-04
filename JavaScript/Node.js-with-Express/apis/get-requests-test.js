const express = require("express");
const https = require("https");

const app = express();

app.get("/", function(req, res) {
  const myAppId = "12345";
  const url = "https://api.openweathermap.org/data/2.5/weather?lat=39.103699&lon=-84.513611&units=imperial&appid=" + myAppId;
  https.get(url, function(response) {
    response.on("data", function(data) {
      const weatherData = JSON.parse(data);
      const temp = weatherData.main.temp;
      const description = weatherData.weather[0].description;
      const icon = weatherData.weather[0].icon;
      const imageUrl = "http://openweathermap.org/img/wn/" + icon + "@2x.png";
      res.write("<p>The weather is currently: " + description + "</p>");
      res.write("<h1>The temperature in Cincinnati is: " + temp + " degrees Fahrenheit</h1>");
      res.write("<img src=" + imageUrl + " alt='weather-image'>");
      res.send();
    });
  });
});

app.listen(3000, function() {
  console.log("Server running on port 3000.");
});
