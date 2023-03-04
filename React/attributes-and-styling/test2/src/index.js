import React from "react";
import ReactDOM from "react-dom";

const time = new Date().getHours();
let headingStyle = {
  color: ""
};

let greeting = "";

if (time <= 12) {
  greeting = "Good morning!";
  headingStyle.color = "red";
} else if (time <= 18) {
  greeting = "Good afternoon!";
  headingStyle.color = "green";
} else {
  greeting = "Good evening!";
  headingStyle.color = "blue";
}

ReactDOM.render(
  <h1 className="heading" style={headingStyle}>
    {greeting}
  </h1>,
  document.getElementById("root")
);
