import React from "react";
import "./Nav.css";
import { NavLink } from "react-router-dom";
import Connect from "../Connect";

export default function Nav() {
  const [isOpen, setIsOpen] = React.useState(false);

  const toggleMenu = () => {
    setIsOpen(!isOpen);
  };

  return (
    <>
      <div className="hamburger" onClick={toggleMenu}>
        <div className={isOpen ? "bar open" : "bar"}></div>
        <div className={isOpen ? "bar open" : "bar"}></div>
      </div>
      <nav className={isOpen ? "nav open" : "nav"}>
        <div className="nav-wrapper">
          <div className={isOpen ? "exit open" : "exit"} onClick={toggleMenu}>
            x
          </div>
          <div className="storename">Paperback Porch</div>
          <hr />
          <ul className="nav-links">
            <li>
              <NavLink onClick={toggleMenu} to="/">Home</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/books">Books</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/who-we-are">Who We Are</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/subscriptions">Subscriptions</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/merch-and-gifts">Merch & Gifts</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/events">Events</NavLink>
            </li>
            <li>
              <NavLink onClick={toggleMenu} to="/about-us">About Us</NavLink>
            </li>
          </ul>
          <hr />
          <div className="account-options">
            <NavLink onClick={toggleMenu} to="/user/login">Log in</NavLink>
            <NavLink onClick={toggleMenu} to="/user/create">Create an account</NavLink>
          </div>
          <div className="connect-options">
            <Connect />
          </div>
        </div>
      </nav>
    </>
  );

  return (
    <nav>
      <ul>
        <li>
          <NavLink to="/">Home</NavLink>
        </li>
        <li>
          <NavLink to="/books">Books</NavLink>
        </li>
        <li>
          <NavLink to="/who-we-are">Who We Are</NavLink>
        </li>
        <li>
          <NavLink to="/subscriptions">Subscriptions</NavLink>
        </li>
        <li>
          <NavLink to="/merch-and-gifts">Merch & Gifts</NavLink>
        </li>
        <li>
          <NavLink to="/events">Events</NavLink>
        </li>
        <li>
          <NavLink to="/about-us">About Us</NavLink>
        </li>
      </ul>
    </nav>
  );
}
