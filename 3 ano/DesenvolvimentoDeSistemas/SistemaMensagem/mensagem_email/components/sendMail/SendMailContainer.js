import styles from '../../styles/SendMailContainer.module.css'
import ButtonMail from './ButtonMail'

import Swal from 'sweetalert2'
import Alert from '../Alerts/Alert'

import { UserContext } from '../../context/UserContext'
import { useEffect, useContext, useState } from 'react'
import { MsgsContext } from '../../context/MsgsContext'

export default function SendMailContainer({btnCancel, usuario}) {
    const { users, getAllUsers } =  useContext(UserContext)
    const { sendMsg } =  useContext(MsgsContext)
    
    const [msgData, setMsgData] = useState([])

    useEffect(() => {
        getAllUsers()
    }, [])

    function handleChange(e) {
        setMsgData({ ...msgData, [e.target.name]: e.target.value })
    } 

    const sendMail = async () => {
        if(msgData.destinatario == null){
            Alert({message: 'Selecione um destinatário', type: 'error'})
            return
        }
        if(msgData.assunto == '' || msgData.mensagem == ''){
            Swal.fire({
                title: 'Atenção',
                text: "Não é recomendado enviar mensagem sem assunto e conteudo",
                icon: 'info',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Confirmar'
              }).then((result) => {
                if (result.isConfirmed) {
                    sendMail2()
                }
              }
            )
        } else {
            sendMail2()
        }
    }

    async function sendMail2(){
        await sendMsg(msgData,usuario)
        setMsgData({destinatario: 'null', assunto: '', mensagem: ''})
    }

    return (
        <div className={styles.container} id="sendMailContainer">
            <form onSubmit={null} className={styles.form}>
                <h1 className={styles.h1}>Enviar Mensagem</h1>

                <label>Destinatario</label>
                <select 
                value={msgData.destinatario}
                onChange={handleChange}
                name="destinatario" required>
                    <option value={'null'} disabled selected>Selecione um usuário</option>
                    {users.map((user, index) => {
                        return <option key={index} value={user.usuario}>{user.nome}</option>
                    }
                    )}
                </select>

                <label htmlFor="assunto">Assunto</label>
                <input 
                type="text" 
                placeholder="Assunto..." 
                name="assunto"  
                onChange={handleChange} 
                value={msgData.assunto ? msgData.assunto : ''}
                required/>

                <label>Mensagem</label>
                <textarea 
                placeholder="Mensagem..." 
                name="mensagem" 
                cols="30"
                rows="10"
                onChange={handleChange}
                value={msgData.mensagem ? msgData.mensagem : ''}
                required></textarea>

            </form>
                <div className={styles.buttons}>
                    <ButtonMail styleClass="btnContainerCenter" func={sendMail} text="Enviar Mensagem"/>
                    <ButtonMail styleClass="btnContainerCenter" func={btnCancel} text="Cancelar Mensagem"/>
                </div>
        </div>
    )
}