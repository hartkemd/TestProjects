import React from "react";

function App() {
  setInterval(updateTime, 1000);

  const initialTime = new Date().toLocaleTimeString("en-US", { hour12: false });
  const [time, setTime] = React.useState(initialTime);

  function updateTime() {
    const currentTime = new Date().toLocaleTimeString("en-US", {
      hour12: false
    });
    setTime(currentTime);
  }

  return (
    <div className="container">
      <h1>{time}</h1>
      <button onClick={updateTime}>Get Time</button>
    </div>
  );
}

export default App;
