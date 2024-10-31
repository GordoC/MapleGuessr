import React from "react";
import "./InputField.scss";

interface InputFieldProps {
  label: string;
  type: string;
  value: string;
  onChange: (e: React.ChangeEvent<HTMLInputElement>) => void;
}

const InputField: React.FC<InputFieldProps> = ({ label, type, value, onChange }) => (
  <div className="inputContainer">
    <label>{label}</label>
    <input type={type} value={value} onChange={onChange} className="inputField" required />
  </div>
);

export default InputField;