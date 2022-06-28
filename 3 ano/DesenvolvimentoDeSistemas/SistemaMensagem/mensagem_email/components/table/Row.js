import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'
import { IoArrowUndoSharp } from 'react-icons/io5'

import { useContext } from 'react'
import { MsgsContext } from "../../context/MsgsContext"

export default function Row({msg, username, loading}) {  
    
    const { deleteMsgs, getMsgs } =  useContext(MsgsContext)
    async function deleteMsg(e) {
        await deleteMsgs(msg.id, username)
    }

    function replayMsg() {
        alert('replay')
    }

    const dataFormatada = new Date(
        msg.data
    ).toString('yyyy-MM-dd')

    return (
        <>
            <tr className={styles.row}>
                <td>{msg.remetente}</td>
                <td>{msg.destinatario}</td>
                <td>{msg.assunto}</td>
                <td>{msg.data}</td>
                <td>
                    <div className={styles.msgDivDiv}>
                        <div className={styles.msgTable}>
                            {msg.mensagem}
                        </div>
                    </div>
                </td>
                <td>
                    <div className={styles.actions}>
                        {/* <div className={styles.btns} title="Responder">
                            <IoArrowUndoSharp onClick={replayMsg} className={styles.btnExclui} />
                        </div> */}
                        <div className={styles.btns} title="Excluir">
                            <BsFillTrashFill onClick={deleteMsg} className={styles.btnExclui} />
                        </div>
                    </div>
                </td> 
            </tr>
        </>
    )
}