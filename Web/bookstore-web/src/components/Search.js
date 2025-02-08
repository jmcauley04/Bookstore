import React from "react";
import SVGSearch from "../icons/SVGSearch";
import "./Search.css";

export default function Search() {
  return (
    <div className="search">
      <label>
        <SVGSearch />
      </label>
      <input type="text" />
    </ div>
  );
}
