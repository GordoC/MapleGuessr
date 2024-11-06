import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from "./Pages/HomePage/HomePage";
import GamePage from "./Pages/GamePage/GamePage";
import Navbar from "./Components/Navbar/Navbar";
import LoginPage from "./Pages/LoginPage/LoginPage";
import { ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { UserProvider } from "./Context/useAuth";
import RegisterPage from "./Pages/RegisterPage/RegisterPage";

function App() {
    return (
        <Router>
            <UserProvider>
                <Navbar />
                <ToastContainer />
                <Routes>
                    <Route path="/" element={<HomePage />} />
                    <Route path="/game" element={<GamePage />} />
                    <Route path="/login" element={<LoginPage />} />
                    <Route path="/register" element={<RegisterPage />} />    
                </Routes>
            </UserProvider>
        </Router>
    );
}

export default App;