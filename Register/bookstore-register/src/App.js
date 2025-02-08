import './App.css';
import MainLayout from './layouts/MainLayout';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Home from './pages/Home';
import Register from './pages/Register';
import Inventory from './pages/Inventory';
import Customers from './pages/Customers';
import Receipts from './pages/Receipts';
import Dashboard from './pages/Dashboard';
import Users from './pages/Users';

function App() {
  return (
    <BrowserRouter>
        <Routes>
            <Route path="/" element={<MainLayout />}>
                <Route index element={<Home />} /> 
                <Route path="/register" element={<Register />} /> 
                <Route path="/inventory-management" element={<Inventory />} />                 
                <Route path="/customer-management" element={<Customers />} />
                <Route path="/receipts" element={<Receipts />} />
                <Route path="/dashboard" element={<Dashboard />} />
                <Route path="/user-management" element={<Users />} />
            </Route>
        </Routes>
    </BrowserRouter>
  );
}

export default App;
