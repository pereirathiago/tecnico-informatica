import Head from 'next/head'
import {useState, useContext, useEffect} from 'react'

import Navbar from '../components/Navbar'
import styles from '../styles/Home.module.css'
import styles2 from '../styles/Table.module.css'
import ButtonMail from '../components/sendMail/ButtonMail'
import ContainerUser from '../components/admin/ContainerUser'
import RowUser from '../components/table/RowUser'


import { IoReloadCircleSharp } from 'react-icons/io5'
import { UserContext } from '../context/UserContext'

export default function Admin() {
  const [removeLoading, setRemoveLoading] = useState(true)
  const { users, getAllUsers } =  useContext(UserContext)
  const [creating, setCreating] = useState(false)

  useEffect(() => {
    getAllUsers()
  } , [])

  const updateTable = (e) => {
    e.preventDefault()
    handleLoading()
    getAllUsers()
  }

  function createUser(){
    setCreating(!creating)
  }

  const handleLoading = () => {
    setRemoveLoading(false)
    setTimeout(() => {
        setRemoveLoading(true)
    } , 1000)
  }

  return (
    <>
      <Head>
        <script dangerouslySetInnerHTML={{
          __html: `if(!document.cookie || !document.cookie.includes('admin')){
              window.location.href = "/login"
          }`,
        }} />
      </Head>
      <Navbar />
      <div>
        <h1 className={styles.h1}>Bem-vindo ao painel de administração</h1>
        <ButtonMail text="Criar usuario" func={createUser} styleClass="btnContainer"/>
        <div className="center">
            <table className={styles2.table}>
                <thead className={styles2.thead}>
                    <tr className={styles2.tr}>
                        <th scope="col" className={styles2.th}>Usuário</th>
                        <th scope="col" className={styles2.th}>Nome</th>
                        <th scope="col" className={styles2.th}>Senha</th>
                        <th scope="col" className={`${styles2.th} ${styles2.thReload}`}>
                            Ações
                            <IoReloadCircleSharp className={styles2.reload} onClick={updateTable}/>
                        </th>
                    </tr>
                </thead>
                {!removeLoading && <td colSpan={6}><div className={styles2.loading}><Loading/></div></td>}
                {removeLoading && 
                    <tbody>
                        {
                            users.map((user, index) => (
                                <RowUser key={index} user={user} username={user.nome} loading={handleLoading} />
                                ))
                            }
                    </tbody>
                }
            </table>
        </div>
        {creating && <ContainerUser type="Criar" btnCancel={createUser} />}
      </div>
    </>
  )
}
