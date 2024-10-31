// src/Pages/LoginPage.tsx
import React, { useState } from "react";
import InputField from "../../Components/InputField/InputField";
import "./LoginPage.scss";

const LoginPage = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [username, setUsername] = useState("");
  const [isRegistering, setIsRegistering] = useState(false);

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (isRegistering) {
      console.log("Registering with:", { email, password });
    } else {
      console.log("Logging in with:", { email, password });
    }
  };

  return (
    <div className="container">
      <h2>{isRegistering ? "Register" : "Login"}</h2>
      <form onSubmit={handleSubmit} className="form">
        {isRegistering && (
            <InputField
                label="Username"
                type="text"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
            />
        )}
        <InputField
          label="Email"
          type="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        <InputField
          label="Password"
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />
        <button type="submit" className="submitButton">
          {isRegistering ? "Register" : "Login"}
        </button>
      </form>
      <p className="switchText">
        {isRegistering ? "Already have an account?" : "Don't have an account?"}
        <span onClick={() => setIsRegistering(!isRegistering)} className="switchLink">
          {isRegistering ? " Login" : " Register"}
        </span>
      </p>
    </div>
  );
};

export default LoginPage;
