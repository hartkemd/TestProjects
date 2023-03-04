import React from "react";
import ReactDOM from "react-dom";

const firstName = "Mark";
const lastName = "Hartkemeyer";
const favoriteNumber = 5;

ReactDOM.render(
  <div>
    <h1>
      Hello, {firstName} {lastName}
    </h1>
    <p>Your favorite number is: {favoriteNumber}</p>
  </div>,
  document.getElementById("root")
);
