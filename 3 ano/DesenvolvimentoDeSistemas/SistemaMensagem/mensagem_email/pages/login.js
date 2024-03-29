import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'
import cookie from 'js-cookie'

import { useState } from 'react'
import { useContext } from 'react'

import { AuthContext } from '../context/AuthContext';

import styles from '../styles/Login.module.css'

export default function Login() {
    const [user, setUser] = useState([])

    const { loginUser, loading } =  useContext(AuthContext)

    const submit = (e) => {
        e.preventDefault()
        if(user.name == 'admin' && user.password == '123456') {
            cookie.set('admin', 'admin', { expires: 1 })
            window.location.href = '/admin'
        } else {
            verifyLogin()
        }
    }

    const verifyLogin = async () => {
        loginUser(user)
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
                <script dangerouslySetInnerHTML={{
                    __html: `if(document.cookie.includes('admin')){
                        window.location.href = "/admin"
                    }`,
                }} />
            </Head>

            <div className={styles.login_page}>
                <div className={styles.image}>
                    <Image src="/envelope.svg" alt="Gmail²" width={400} height={400} />
                </div>
                <div className={styles.form}>
                    <form onSubmit={submit}>
                        <p>Bem-vindo de volta! 👋</p>
                        <h1>Faça login na sua conta</h1>
                        <Input type="text" text="Usuário" name="name" placeholder="Digite seu usuário" handleOnChange={handleChange} value={user.name ? user.name : ''}/>
                        <Input type="password" text="Senha" name="password" placeholder="Digite aqui sua senha" handleOnChange={handleChange} value={user.password ? user.password : ''}/>
                        <SubmitButton text={!loading ? 'Entrar' : ''}/>
                    </form>
                </div>
            </div>
        </>
    )
}