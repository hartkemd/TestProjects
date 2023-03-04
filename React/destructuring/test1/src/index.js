import React from "react";
import ReactDOM from "react-dom";
import animals from "./data";

const [cat, dog] = animals;

ReactDOM.render(
  <div>
    <h1>{cat.name}</h1>
    <p>{cat.sound}</p>
    <h1>{dog.name}</h1>
    <p>{dog.sound}</p>
  </div>,
  document.getElementById("root")
);
