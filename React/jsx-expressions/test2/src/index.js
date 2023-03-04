import React from "react";
import ReactDOM from "react-dom";

const firstName = "Mark";
const lastName = "Hartkemeyer";
const currentYear = new Date().getFullYear();

ReactDOM.render(
  <div>
    <p>
      Created by: {firstName} {lastName}
    </p>
    <p>&copy; {currentYear}</p>
  </div>,
  document.getElementById("root")
);
