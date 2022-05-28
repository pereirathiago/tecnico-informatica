import Navbar from "./Navbar";
import Head from 'next/head'

export default function Layout({children}) {
    return (
        <>
        <Head>
            <link rel="shortcut icon" href="/mail.ico"/>
            <title>Gmail²</title>
        </Head>
            <main className="container">{children}</main>
        </>
    )
}