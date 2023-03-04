const express = require("express");

const app = express();

app.get("/", function(req, res) {
  res.sendFile(__dirname + "/sending-files-in-responses-test.html");
});
