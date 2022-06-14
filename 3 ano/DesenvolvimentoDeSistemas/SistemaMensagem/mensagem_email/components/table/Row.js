import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'

import { useContext } from 'react'
import { MsgsContext } from "../../context/MsgsContext"

export default function Row({msg, updateTable}) {  
    
    const { deleteMsgs } =  useContext(MsgsContext)
    function deleteMsg() {
        deleteMsgs(msg.id)
        updateTable
    }

    return (
        <>
            <tr className={styles.row}>
                <td>{msg.remetente}</td>
                <td>{msg.destinatario}</td>
                <td>{msg.assunto}</td>
                <td>{msg.data}</td>
                <td>
                    <div className={styles.msgTable}>
                        {msg.mensagem}
                    </div>
                </td>
                <td>
                    <BsFillTrashFill onClick={deleteMsg} className={styles.btnExclui} />
                </td> 
            </tr>
        </>
    )
}