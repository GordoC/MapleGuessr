import React from "react";
import * as Yup from "yup";
import { yupResolver } from "@hookform/resolvers/yup";
import { useAuth } from "../../Context/useAuth";
import { useForm } from "react-hook-form";

type RegisterFormInputs = {
    userName: string;
    email: string;
    password: string;
};

const validation = Yup.object().shape({
    userName: Yup.string().required("Username is required"),
    email: Yup.string().required("Email is required"),
    password: Yup.string().required("Password is required"),
});

const RegisterPage = () => {
    const { registerUser } = useAuth();
    const { register, handleSubmit, formState: { errors } } = useForm<RegisterFormInputs>({
        resolver: yupResolver(validation)
    });

    const handleRegister = (form: RegisterFormInputs) => {
        registerUser(form.userName, form.email, form.password);
    };

    return (
        <section>
            <div>
                <div>
                    <div>
                        <h1>Register your account</h1>
                        <form onSubmit={handleSubmit(handleRegister)}>
                            <div>
                                <label htmlFor="email">Email</label>
                                <input
                                    type="text"
                                    id="email"
                                    placeholder="Email"
                                    {...register("email")}
                                />
                                {errors.email && <p>{errors.email.message}</p>}
                            </div>
                            <div>
                                <label htmlFor="username">Username</label>
                                <input
                                    type="username"
                                    id="username"
                                    placeholder="Username"
                                    {...register("userName")}
                                />
                                {errors.userName && <p>{errors.userName.message}</p>}
                            </div>
                            <div>
                                <label htmlFor="password">Password</label>
                                <input
                                    type="password"
                                    id="password"
                                    placeholder="••••••••"
                                    {...register("password")}
                                />
                                {errors.password && <p>{errors.password.message}</p>}
                            </div>
                            <button type="submit">Register</button>
                        </form>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default RegisterPage;