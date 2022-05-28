import Swal from 'sweetalert2'

import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'

import { useState } from 'react'
import { useRouter } from 'next/router'

import styles from '../styles/Login.module.css'

export default function Login() {
    const [user, setUser] = useState([])

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
            if(resp.status == 200) {
                router.push('/')
            }
            else if(resp.status == 401) {
                Swal.fire(
                    'Erro',
                    'Verifique seu usuário e senha!',
                    'error'
                  )
            }
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
                    <Image src="/envelope.svg" alt="Gmail²" width={300} height={300} />
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