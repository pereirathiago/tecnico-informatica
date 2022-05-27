import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'

import { useState } from 'react'

import styles from '../styles/Login.module.css'

export default function Login() {

    const [user, setUser] = useState('')
    const [password, setPassword] = useState('')

    const submit = (e) => {
        e.preventDefault()
        if(user == 'admin' && password == '1234') {
            window.location.href = '/admin'
        } else {
            verifyLogin()
        }
    }

    const verifyLogin = async () => {
        const response = await fetch(`${process.env.API}/user/login`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({user, password})
        })
        const data = await response.json()
        if(data.status == 200) {
            alert('conectado')
        } else {
            alert('Usuário ou senha incorretos')
        }
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
                        <Input type="text" text="Seu Usuário" name="user" placeholder="Digite seu usuário" handleOnChange={(e) => e.target.value} value={user}/>
                        <Input type="password" text="Sua senha" name="password" placeholder="Digite sua senha" handleOnChange={(e) => e.target.value} value={password}/>
                        <SubmitButton text={'Entrar'}/>
                    </form>
                </div>
            </div>
        </>
    )
}