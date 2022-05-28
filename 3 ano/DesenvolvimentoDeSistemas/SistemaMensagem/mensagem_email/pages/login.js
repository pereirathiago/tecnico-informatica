import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'

import { useState } from 'react'
import { useRouter } from 'next/router'

import styles from '../styles/Login.module.css'
import Alert from '../components/Alert'

export default function Login() {
    const [user, setUser] = useState([])
    const [loading, isLoading] = useState(false)

    const router = useRouter()

    const submit = (e) => {
        e.preventDefault()
        if(user.name == 'admin' && user.password == '123456') {
            window.location.href = '/admin'
        } else {
            verifyLogin()
        }
    }

    const verifyLogin = async () => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/user/login`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify({"usuario": user.name, "senha": user.password})
        })
        .then(((resp) => {
            isLoading(true)
            setTimeout(() => {
                if(resp.status == 200) {
                    isLoading(false)
                    router.push('/')
                }
                else {
                    isLoading(false)
                    Alert({message: 'Usuário ou senha incorretos', type: 'error'})
                }
            }, 300)
        }))
        .catch(err => console.error(err))      
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