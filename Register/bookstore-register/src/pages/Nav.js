import { Link, NavLink } from "react-router-dom";
import "./Nav.css";

export default function Nav() {
  return (
    <>
      <nav>
        <ul>
          <li>
            <NavLink className="link-btn" to="/register" activeClassName="active">Register</NavLink>
          </li>
          <li>
            <NavLink className="link-btn" to="/inventory-management" activeClassName="active">Inventory</NavLink>
          </li>
          <li>
            <NavLink className="link-btn" to="/customer-management" activeClassName="active">Customers</NavLink>
          </li>
          <li>
            <NavLink className="link-btn" to="/receipts" activeClassName="active">Receipts</NavLink>
          </li>
          <li>
            <NavLink className="link-btn" to="/dashboard" activeClassName="active">Dashboard</NavLink>
          </li>
          <li>
            <NavLink className="link-btn" to="/user-management" activeClassName="active">Users</NavLink>
          </li>
        </ul>
      </nav>
    </>
  );
}
