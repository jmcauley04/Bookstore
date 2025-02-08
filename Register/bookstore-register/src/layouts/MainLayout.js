import React, { useState } from "react";
import { Outlet, Link, useLocation } from "react-router-dom";
import "./MainLayout.css";
import Nav from "../pages/Nav";

export default function MainLayout() {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  return (
    <>
      <main>
        <div className="sidebar">
            <header>
                <h1 id='logo'>Southern Pages</h1>
            </header>
            <Nav />
        </div>
        <Outlet />
      </main>
    </>
  );
}
