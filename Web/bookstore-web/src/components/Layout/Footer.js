import React from "react";
import "./Footer.css";
import Connect from "../Connect";

export default function Footer() {
  return (
    <footer>
      <div className="footer-top">
        <div className="footer-column">
          <h4>About</h4>
          <ul>
            <li>Our Story</li>
            <li>Meet the Booksellers</li>
            <li>Contact Us</li>
          </ul>
        </div>
        <div className="footer-column">
          <h4>Customer Service</h4>
          <ul>
            <li>Help</li>
            <li>Returns</li>
            <li>Shipping</li>
            <li>Terms of Service</li>
            <li>Privacy Policy</li>
          </ul>
        </div>
        <div className="footer-column">
          <h4 style={{marginBottom: "1em"}}>Connect</h4>
          <Connect />
        </div>
      </div>

      <div className="footer-bottom">
        &copy; {new Date().getFullYear()} Paperback Porch, LLC
      </div>
    </footer>
  );
}
