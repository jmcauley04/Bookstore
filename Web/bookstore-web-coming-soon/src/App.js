import "./App.css";
import Connect from "./components/Connect";
import EmailInput from "./components/EmailInput";
import Logo from "./components/Logo";

function App() {
    
  return (
    <div className="App">
      <div className="page-wrapper">
        <div className="left">
          <div className="header-image">
            <div><Logo /></div>
          </div>
        </div>
        <div className="right">
            <div className="slogan"><span id="slogan-books">Books</span>, <span id="slogan-community">community</span>, & <br/><span id="slogan-souther-charm">a little Southern charm</span></div>
            <span
              style={{
                fontSize: "20px",
                fontWeight: 500,
                letterSpacing: ".1em"
              }}
            >
              coming soon.
            </span>     
            <EmailInput />
          <div className="footer">
            {/* <Connect /> */}
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
