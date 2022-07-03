import Head from 'next/head'
import {useState, useEffect, useContext } from 'react'

import { MsgsContext } from "../../context/MsgsContext" 

import Navbar from '../../components/Navbar'
import styles from '../../styles/Home.module.css'

import { useRouter } from 'next/router'

export default function Home({mail}) {
  const { query } = useRouter()
  const { msg, getMsg } =  useContext(MsgsContext)

  useEffect(() => {
    getMsg(query.mail)
  }, [])

  return (
    <>
      <Head>
        <script dangerouslySetInnerHTML={{
          __html: `if(!document.cookie || !document.cookie.includes('user-auth')){
              window.location.href = "/login"
          }`,
        }} />
      </Head>
      <Navbar />
      <div className={styles.container}>
        <div className="center">
          <h1>Recebido de <span className={styles.spanName}> {msg.remetente}</span></h1>

        </div>
      </div>
    </>
  )
}
