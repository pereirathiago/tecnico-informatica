import styles from '../../styles/Input.module.css'
import { BsFillEyeFill, BsFillEyeSlashFill } from 'react-icons/bs'
import {useState} from 'react'

export default function Input({type, text, name, placeholder, handleOnChange, value}) {

    const [isShowPassword, setShowPassword] = useState(false)

    function showPassword() {
        setShowPassword(!isShowPassword)
        isShowPassword ? document.getElementById(name).type = 'password' : document.getElementById(name).type = 'text'
    }

    return (
        <div className={styles.form_control}>
            <label forhtml={name}>{text}:</label>
            <input type={type} name={name} id={name} placeholder={placeholder} onChange={handleOnChange} value={value} required/>
            {type==="password" && (isShowPassword ? 
            <BsFillEyeSlashFill onClick={showPassword} className={styles.password_icon}/> : 
            <BsFillEyeFill onClick={showPassword} className={styles.password_icon}/>)}
        </div>
    )
}