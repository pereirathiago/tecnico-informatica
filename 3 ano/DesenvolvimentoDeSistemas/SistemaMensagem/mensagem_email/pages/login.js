import Head from 'next/head'
import Image from 'next/image'
import Input from '../components/form/Input'
import SubmitButton from '../components/form/SubmitButton'

import styles from '../styles/Login.module.css'

export default function Login() {
    const login = async (e) => {
        e.preventDefault()
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
                    <form onSubmit={login}>
                        <h1>Login</h1>
                        <Input type="text" text="Seu email" name="email" placeholder="Digite seu email"/>
                        <Input type="password" text="Sua senha" name="password" placeholder="Digite sua senha"/>
                        <SubmitButton text={'Entrar'}/>
                    </form>
                </div>
            </div>
        </>
    )
}