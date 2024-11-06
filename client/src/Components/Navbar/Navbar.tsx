import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.scss';
import { useAuth } from "../../Context/useAuth";

const Navbar = () => {
    const { isLoggedIn, user, logoutUser } = useAuth();
    return (
        <nav className="navbar">
            <div className="navbar-title">
                <h1>MapleGuessr</h1>
            </div>
            <div >
                { isLoggedIn() ? (
                    <div className="navbar-links">
                        <div>Welcome, {user?.userName}</div>
                        <div onClick={logoutUser}>Logout</div>
                    </div>
                ) : (
                    <div className="navbar-links">
                        <Link to="/login" className="navbar-link">Login</Link>
                        <Link to="/register" className="navbar-link">Signup</Link>
                    </div>
                )}
            </div>
        </nav>
    );
};

export default Navbar;
