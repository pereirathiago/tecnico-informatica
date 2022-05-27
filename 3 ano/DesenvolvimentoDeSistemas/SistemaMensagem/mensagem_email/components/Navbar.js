import { useState, useEffect } from "react";
import { IoExitOutline } from 'react-icons/io5';

import cookie from 'js-cookie'
import Image from "next/image"
import Link from "next/link";

import styles from '../styles/Navbar.module.css'

export default function Navbar(){

    const [cookieAuth, setCookieAuth] = useState(false)

    useEffect(() => {
        setCookieAuth(cookie.get('user-auth') || false)
    }, [])

    return (
        <>
            {cookieAuth && 
            <nav className={styles.navbar}>
                    <div className={styles.logo}>
                        <Image src="/mail.svg" width="30" height="30" alt="Mail"/>
                        <h1>Gmail²</h1>
                    </div>
                <ul className={styles.link_items}>
                        <li>
                            <Link href="/">
                                <a>
                                    <IoExitOutline />
                                    Sair
                                </a>
                            </Link>
                        </li>
                </ul>
            </nav>
            }
        </>
    )
}