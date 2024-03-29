import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'
import { IoArrowUndoSharp } from 'react-icons/io5'

import { useContext } from 'react'
import { MsgsContext } from "../../context/MsgsContext"
import Link from 'next/link'

export default function Row({msg, username, loading}) {  
    
    const { deleteMsgs, getMsgs } =  useContext(MsgsContext)
    async function deleteMsg(e) {
        await deleteMsgs(msg.id, username)
    }

    function replayMsg() {
        alert('replay')
    }

    const formatDate = (date) => {
        date = date.slice(0, -14);
        let year = date.substring(0, 4);
        let month = date.substring(7, 5);
        let day = date.substring(10, 8);

        return `${day}/${month}/${year}`;
    }

    return (
        <>
                <tr className={styles.row}>
                    <Link href={`/mails/${msg.id}`}>
                        <td>{msg.remetente}</td>
                    </Link>
                    <Link href={`/mails/${msg.id}`}>
                        <td>{msg.destinatario}</td>
                    </Link>
                    <Link href={`/mails/${msg.id}`}>
                        <td>{msg.assunto}</td>
                    </Link>
                    <Link href={`/mails/${msg.id}`}>
                        <td>{formatDate(msg.data)}</td>
                    </Link>
                    <Link href={`/mails/${msg.id}`}>
                    <td>
                        <div className={styles.msgDivDiv}>
                            <div className={styles.msgTable}>
                                {msg.mensagem}
                            </div>
                        </div>
                    </td>
                    </Link>
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