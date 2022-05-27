import Head from 'next/head'
import styles from '../styles/Home.module.css'

export default function Home() {
  return (
    <>
      <Head>
        <script dangerouslySetInnerHTML={{
          __html: `if(!document.cookie || !document.cookie.includes('user-auth')){
              window.location.href = "/login"
          }`,
        }} />
      </Head>
    </>
  )
}
