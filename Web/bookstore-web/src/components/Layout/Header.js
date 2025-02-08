import React from "react";
import "./Header.css";
import Nav from "../Sections/Nav";
import Search from "../Search";
import UserIcon from "../UserIcon";
import Cart from "../Cart";

export default function Header() {
  return (
    <header>
      <div className="search">
        <Search />
      </div>
      <Nav />
      <UserIcon />
      <Cart />
    </header>
  );
}
