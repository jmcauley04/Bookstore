import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "./App.css";
import Hero from "./components/Branding/Hero";
import Footer from "./components/Layout/Footer";
import Header from "./components/Layout/Header";
import Banner from "./components/Sections/Banner";
import Home from "./components/pages/home/Home";

function App() {
  return (
    <Router basename="/"> {/* for github, Bookstore/ */}
      <div className="App">
        <div className="page-wrapper">
          <Banner text="Save $ on orders over $100 by earning free shipping!" />
          <Header />
          <Hero />
          <main>
            <Routes>
                <Route path="/" element={<Home />} />
            </Routes>
          </main>
        </div>
        <Footer />
      </div>
    </Router>
  );
}

export default App;
