import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'

import { useState } from 'react'

import styles from '../styles/Login.module.css'

export default function Login() {
    const [user, setUser] = useState([])

    const submit = (e) => {
        e.preventDefault()
        if(user.name == 'admin' && user.password == '123456') {
            window.location.href = '/admin'
        } else {
            verifyLogin()
        }
    }

    const verifyLogin = async () => {
        try{
            fetch('http://localhost:3030/user/login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(user)
            })
        }catch (e) {
            console.log(e)
        }
    }

    function handleChange(e) {
        setUser({ ...user, [e.target.name]: e.target.value })
    }   

    return (
        <>
            <Head>
                <script dangerouslySetInnerHTML={{
                    __html: `if(document.cookie.includes('user-auth')){
                        window.location.href = "/"
                    }`,
                }} />
            </Head>

            <div className={styles.login_page}>
                <div className={styles.image}>
                    <Image src="/mailbox_re_dvds.svg" alt="Gmail²" width={300} height={300} />
                </div>
                <div className={styles.form}>
                    <form onSubmit={submit}>
                        <h1>Login</h1>
                        <Input type="text" text="Seu Usuário" name="name" placeholder="Digite seu usuário" handleOnChange={handleChange} value={user.name ? user.name : ''}/>
                        <Input type="password" text="Sua senha" name="password" placeholder="Digite sua senha" handleOnChange={handleChange} value={user.password ? user.password : ''}/>
                        <SubmitButton text={'Entrar'}/>
                    </form>
                </div>
            </div>
        </>
    )
}