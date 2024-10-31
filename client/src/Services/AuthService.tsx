import axios from "axios";
import { UserProfileToken } from "../Models/User";
import { handleError } from "../Helpers/ErrorHandler";

const server = "https://localhost:7215/server";

export const loginAPI = async (username: string, password: string) => {
    try {
        const data = await axios.post<UserProfileToken>(server + "/account/login", { 
            username: username,
            password: password
        });
        return data;
    } catch (error) {
        handleError(error);
    }
}

export const registerAPI = async (username: string, email: string, password: string) => {
    try {
        const data = await axios.post<UserProfileToken>(server + "/account/register", { 
            username: username,
            email: email,
            password: password
        });
        return data;
    } catch (error) {
        handleError(error);
    }
}