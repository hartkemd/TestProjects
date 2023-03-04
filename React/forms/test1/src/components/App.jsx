import React, { useState } from "react";

function App() {
  const [name, setName] = useState("");
  const [greeting, setGreeting] = useState("Hello!");

  function handleChange(event) {
    setName(event.target.value);
  }

  function handleClick(event) {
    setGreeting(`Hello, ${name}!`);

    event.preventDefault();
  }

  return (
    <div className="container">
      <h1>{greeting}</h1>
      <form onSubmit={handleClick}>
        <input
          type="text"
          placeholder="What's your name?"
          onChange={handleChange}
          value={name}
        />
        <button type="submit" onClick={handleClick}>
          Submit
        </button>
      </form>
    </div>
  );
}

export default App;
