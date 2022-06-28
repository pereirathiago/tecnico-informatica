import Row from "./Row";
import { useContext, useEffect, useState } from 'react'

import Loading from '../Loading'

import styles from '../../styles/Table.module.css'
import { MsgsContext } from "../../context/MsgsContext"
import { IoReloadCircleSharp } from 'react-icons/io5'

export default function Table({username}) {
    const { msgs, getMsgs } =  useContext(MsgsContext)
    const [removeLoading, setRemoveLoading] = useState(true)

    useEffect(() => {
        getMsgs(username)
    }, [])

    const updateTable = (e) => {
        e.preventDefault()
        handleLoading()
        getMsgs(username)
    }

    const handleLoading = () => {
        setRemoveLoading(false)
        setTimeout(() => {
            setRemoveLoading(true)
        } , 1000)
    }

    return (
        <div className="center">
            <table className={styles.table}>
                <thead className={styles.thead}>
                    <tr className={styles.tr}>
                        <th scope="col" className={styles.th}>Remetente</th>
                        <th scope="col" className={styles.th}>Destinatario</th>
                        <th scope="col" className={styles.th}>Assunto</th>
                        <th scope="col" className={styles.th}>Data</th>
                        <th scope="col" className={styles.th}>Mensagem</th>
                        <th scope="col" className={`${styles.th} ${styles.thReload}`}>
                            Ações
                            <IoReloadCircleSharp className={styles.reload} onClick={updateTable}/>
                        </th>
                    </tr>
                </thead>
                {!removeLoading && <td colSpan={6}><div className={styles.loading}><Loading/></div></td>}
                {removeLoading && 
                    <tbody>
                        {
                            msgs.map((msg, index) => (
                                <Row key={index} msg={msg} username={username} loading={handleLoading} />
                                ))
                            }
                    </tbody>
                }
            </table>
        </div>
    )
}