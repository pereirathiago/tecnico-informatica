import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'
import { AiFillEdit } from 'react-icons/ai'

import { useContext } from 'react'
import { UserContext } from '../../context/UserContext'
import { MsgsContext } from '../../context/MsgsContext'
import Alert from '../Alerts/Alert'

export default function Row({user}) {  
    
    const { deleteUsers } =  useContext(UserContext)
    const { getMsgs, msgs } = useContext(MsgsContext)
    async function deleteUser(e) {
        await getMsgs(user.usuario)
        alert(msgs)
        if(msgs.length >= 0) {
            await deleteUsers(user.usuario)
        } else {
            Alert({message: 'Não é possível deletar um usuário com mensagens', type: 'error'})
        }
    }

    function replayMsg() {
        alert('replay')
    }

    return (
        <>
            <tr className={styles.row}>
                <td>{user.usuario}</td>
                <td>{user.nome}</td>
                <td>*******</td>
                <td>
                    <div className={styles.actions}>
                        <div className={styles.btns} title="Editar">
                            <AiFillEdit onClick={replayMsg} className={styles.btnExclui} />
                        </div>
                        <div className={styles.btns} title="Excluir">
                            <BsFillTrashFill onClick={deleteUser} className={styles.btnExclui} />
                        </div>
                    </div>
                </td> 
            </tr>
        </>
    )
}