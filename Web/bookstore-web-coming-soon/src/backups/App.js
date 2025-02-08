import "./App.css";
import Connect from "./components/Connect";
import SouthernPages from "./components/SouthernPages";

function App() {
  const nameStyle = {
    position: "absolute",
    left: "50%",
    top: 0,
    transform: "translate(-50%, 0)",
    width: "max-content",
  };
  const connectStyle = {
    position: "absolute",
    left: "50%",
    bottom: "10px",
    transform: "translate(-50%, 0)",
    width: "max-content",
  }

  return (
    <div className="App">
      <header className="App-header">
        <div className="header-image"></div>
        <div style={nameStyle}>
          <SouthernPages />
        </div>
        <div>
          <span
            style={{
              fontSize: "20px",
              fontWeight: 300,
              letterSpacing: ".1em",
              filter: "drop-shadow(0 0 2px rgba(0, 0, 0, .9)",
            }}
          >
            coming soon.
          </span>
          <div className="notify">
            <input placeholder="Enter email address" />
            <button>Notify me</button>
          </div>
        </div>
        <div style={connectStyle}>
            <Connect />
        </div>
      </header>
    </div>
  );
}

export default App;
