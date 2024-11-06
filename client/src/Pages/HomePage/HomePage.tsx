import React from "react";
import "./HomePage.scss";
import logo from "./logo.png";
import { Link } from "react-router-dom";

const HomePage = () => {
    return (
        <div className="homepage">
            <main className="hero-section">
                <div className="hero-text">
                    <h1>MapleGuessr</h1>
                    <p>
          an interactive map-based guessing game inspired by the world of MapleStory.
                    </p>
                    <div className="hero-buttons">
                        <Link to="/game" className="primary-button">Play Now</Link>
                    </div>
                </div>
                <div className="hero-image">
                    <img src={logo} alt="logo" />
                </div>
            </main>
        </div>
    );
};

export default HomePage;
