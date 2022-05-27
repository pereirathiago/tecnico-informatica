import Image from "next/image"
import Link from "next/link";

import styles from '../styles/Navbar.module.css'

export default function Navbar(){
    return (
        <nav className={styles.navbar}>
            <div className={styles.logo}>
                <Image src="/mail.svg" width="30" height="30" alt="Mail"/>
                <h1>Gmail²</h1>
            </div>
            <ul className={styles.link_items}>
            {{
                __html: `if(!document.cookie || !document.cookie.includes('controle-estagio-auth')){
                    window.location.href = "/login"
                }`,
            }}
                <li>
                    <Link href="/"><a>Home</a></Link>
                </li>
                <li>
                    <Link href="/about"><a>Sobre</a></Link>
                </li>
            </ul>
        </nav>
    )
}