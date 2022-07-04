import Head from 'next/head'
import { useEffect, useContext } from 'react'
import { BiArrowBack } from 'react-icons/bi'
import { MsgsContext } from "../../context/MsgsContext" 

import ButtonMail from '../../components/sendMail/ButtonMail'
import Navbar from '../../components/Navbar'
import styles from '../../styles/Home.module.css'
import styles2 from '../../styles/Mail.module.css'

import { useRouter } from 'next/router'

export default function Home({mail}) {
  const { query } = useRouter()
  const { msg, getMsg, deleteMsgs } = useContext(MsgsContext)

  useEffect(() => {
    getMsg(query.mail)
  }, [])

  async function deleteMsg(e) {
    await deleteMsgs(msg.id, msg.destinatario)
  }

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
        <BiArrowBack className={styles2.back} onClick={() => window.history.back()} />
        <div className={styles2.container}>
          <h1>Recebido de <span className={styles.spanName}> {msg.remetente}</span></h1>
          <br/>
          <div className={styles2.data}>
            <p><b>Assunto: </b> {msg.assunto}</p>
            <p>{msg.data}</p>
          </div>
          <br/>
          <div className={styles2.msg}>
            <p>{msg.mensagem}</p>
          </div>
          <br/>
          <div className={styles2.actions}>
            <ButtonMail text="Deletar mensagem" func={deleteMsg} styleClass="btnContainer"/>
          </div>
        </div>
      </div>
    </>
  )
}
