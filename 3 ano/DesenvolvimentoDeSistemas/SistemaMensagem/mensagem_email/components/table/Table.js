import Row from "./Row";
import { useContext, useEffect } from 'react'

import styles from '../../styles/Table.module.css'
import { MsgsContext } from "../../context/MsgsContext"

export default function Table({username}) {
    const { msgs, getMsgs } =  useContext(MsgsContext)

    useEffect(() => {
        getMsgs(username)
    }, [])

    return (
        <div className="center">
            <table className={styles.table}>
                <thead>
                    <tr className={styles.tr}>
                        <th scope="col" className={styles.th}>Remetente</th>
                        <th scope="col" className={styles.th}>Destinatario</th>
                        <th scope="col" className={styles.th}>Assunto</th>
                        <th scope="col" className={styles.th}>Data</th>
                        <th scope="col" className={styles.th}>Mensagem</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        msgs.map((msg, index) => {
                            console.log(msg);
                            <p>{msg}</p>
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}