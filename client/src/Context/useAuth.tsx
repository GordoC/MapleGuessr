import React, { createContext, useEffect, useState } from "react";
import { UserProfile } from "../Models/User";
import { useNavigate } from "react-router-dom";
import { loginAPI, registerAPI } from "../Services/AuthService";
import { toast } from "react-toastify";
import axios from "axios";

type UserContextType = {
    user: UserProfile | null;
    token: string | null;
    registerUser: (username: string, email: string, password: string) => void;
    loginUser: (email: string, password: string) => void;
    logoutUser: () => void;
    isLoggedIn: () => boolean;
}

type Props = { children: React.ReactNode };

const UserContext = createContext<UserContextType>({} as UserContextType);

export const UserProvider = ({ children }: Props) => {
    
    const navigate = useNavigate();
    const [token, setToken] = useState<string | null>(null);
    const [user, setUser] = useState<UserProfile | null>(null);
    const [isReady, setIsReady] = useState<boolean>(false);

    useEffect(() => {
        const user = localStorage.getItem("user");
        const token = localStorage.getItem("token");
        if (user && token) {
            setUser(JSON.parse(user));
            setToken(token);
            axios.defaults.headers.common["Authorization"] = `Bearer ${token}`;
        }
        setIsReady(true);
    }, []);

    const registerUser = async (username: string, email: string, password: string) => {
        await registerAPI(username, email, password).then((res) => {
            if (res) {
                const userObj = {
                    userName: res?.data.userName,
                    email: res?.data.email
                };
                localStorage.setItem("user", JSON.stringify(userObj));
                localStorage.setItem("token", res?.data.token);
                setUser(userObj);
                setToken(res?.data.token);
                toast.success("Registration successful!");
                navigate("/game");
            }
        }).catch(() => toast.warning("Server error occured"));
    };

    const loginUser = async (email: string, password: string) => {
        await loginAPI(email, password).then((res) => {
            if (res) {
                const userObj = {
                    userName: res?.data.userName,
                    email: res?.data.email
                };
                localStorage.setItem("user", JSON.stringify(userObj));
                localStorage.setItem("token", res?.data.token);
                setUser(userObj);
                setToken(res?.data.token);
                toast.success("Login successful!");
                navigate("/game");
            }
        }).catch(() => toast.warning("Server error occured"));
    };

    const isLoggedIn = () => {
        return !!user;
    };

    const logoutUser = () => {
        localStorage.removeItem("user");
        localStorage.removeItem("token");
        setUser(null);
        setToken(null);
        navigate("/");
    };

    return (
        <UserContext.Provider value={{ user, token, registerUser, loginUser, logoutUser, isLoggedIn }}>
            {isReady ? children : null}
        </UserContext.Provider>
    );
};

export const useAuth = () => React.useContext(UserContext);

