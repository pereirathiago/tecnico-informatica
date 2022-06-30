import styles from '../../styles/Row.module.css'
import { BsFillTrashFill } from 'react-icons/bs'
import { AiFillEdit } from 'react-icons/ai'

import { useContext } from 'react'
import { UserContext } from '../../context/UserContext'
import { MsgsContext } from '../../context/MsgsContext'
import Alert from '../Alerts/Alert'

export default function Row({user}) {  
    
    const { deleteUsers } =  useContext(UserContext)
    const { verifyMsgs } = useContext(MsgsContext)
    async function deleteUser(e) {
        await fetch(`${process.env.NEXT_PUBLIC_API_URL}/msgs/user/${user.usuario}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        })
        .then(((resp) => {
            if(resp.status == 200) {
                return resp.json()
            }
            else {
                return Alert({message: 'Usuário não encontrado', type: 'error'})
            }
        })).then((data) =>{
            // alert(data.length)
            if(data.length == 0) {
                return deleteUsers(user.usuario)
            } else {
                return Alert({message: 'Não é possível deletar um usuário com mensagens', type: 'error'})
            }
        })
        .catch(err => console.error(err))
    }

    function replayMsg() {
        alert('editar')
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