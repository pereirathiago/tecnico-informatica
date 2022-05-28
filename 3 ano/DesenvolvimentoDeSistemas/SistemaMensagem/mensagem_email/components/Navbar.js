import { useState, useEffect } from "react";
import { IoExitOutline } from 'react-icons/io5';

import cookie from 'js-cookie'
import Image from "next/image"
import Link from "next/link";

import { useContext } from 'react'
import { AuthContext } from '../context/AuthContext'

import styles from '../styles/Navbar.module.css'

export default function Navbar(){

    const [cookieAuth, setCookieAuth] = useState(false)
    const { logout } =  useContext(AuthContext)

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
                            <button onClick={logout} href="/login">
                                <a >
                                    <IoExitOutline />
                                    Sair
                                </a>
                            </button>
                        </li>
                </ul>
            </nav>
            }
        </>
    )
}