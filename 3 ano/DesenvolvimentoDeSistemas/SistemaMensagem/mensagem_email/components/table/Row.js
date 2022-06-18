import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'
import { IoArrowUndoSharp } from 'react-icons/io5'

import { useContext } from 'react'
import { MsgsContext } from "../../context/MsgsContext"

export default function Row({msg}) {  
    
    const { deleteMsgs } =  useContext(MsgsContext)
    function deleteMsg() {
        deleteMsgs(msg.id)
    }

    function replayMsg() {
        alert('replay')
    }

    const dataFormatada = new Date(
        msg.data
    ).toLocaleString()

    return (
        <>
            <tr className={styles.row}>
                <td>{msg.remetente}</td>
                <td>{msg.destinatario}</td>
                <td>{msg.assunto}</td>
                <td>{dataFormatada}</td>
                <td>
                    <div className={styles.msgDivDiv}>
                        <div className={styles.msgTable}>
                            {msg.mensagem}
                        </div>
                    </div>
                </td>
                <td>
                    <div className={styles.actions}>
                        <div className={styles.btns} title="Responder">
                            <IoArrowUndoSharp onClick={replayMsg} className={styles.btnExclui} />
                        </div>
                        <div className={styles.btns} title="Excluir">
                            <BsFillTrashFill onClick={deleteMsg} className={styles.btnExclui} />
                        </div>
                    </div>
                </td> 
            </tr>
        </>
    )
}