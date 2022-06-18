import Head from 'next/head'
import { useEffect, useState } from 'react'
import { useContext } from 'react'

import { AuthContext } from '../context/AuthContext'

import Navbar from '../components/Navbar'
import styles from '../styles/Home.module.css'
import Table from '../components/table/Table'

export async function getServerSideProps(context) {
  const cookie = context.req.cookies['user-auth'];
  const res = await fetch(`${process.env.NEXT_PUBLIC_API_URL}/user/${cookie}`)
  const data = await res.json()
  
  return {
    props: {user: data},
  };
}
export default function Home({ user }) {
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
        <h1 className={styles.h1}>Bem-vindo <span className={styles.spanName}>{user.nome}</span></h1>
        <Table username={user.usuario}/>
      </div>
    </>
  )
}
