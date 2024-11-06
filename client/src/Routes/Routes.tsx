import React from "react";
import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Pages/HomePage/HomePage";
import LoginPage from "../Pages/LoginPage/LoginPage";
import RegisterPage from "../Pages/RegisterPage/RegisterPage";
import GamePage from "../Pages/GamePage/GamePage";
import LeaderboardPage from "../Pages/LeaderboardPage/LeaderboardPage";
import ProtectedRoute from "./ProtectedRoute";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App />,
        children: [
            { path: "", element: <HomePage /> },
            { path: "login", element: <LoginPage /> },
            { path: "register", element: <RegisterPage /> },
            { path: "game", element: <GamePage /> },
            {
                path: "leaderboard",
                element: (
                    <ProtectedRoute>
                        <LeaderboardPage />
                    </ProtectedRoute>
                ),
            },
        ],
    },
]);