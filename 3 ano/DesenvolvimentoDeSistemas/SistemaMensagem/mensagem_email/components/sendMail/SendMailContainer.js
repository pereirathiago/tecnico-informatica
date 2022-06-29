import styles from '../../styles/SendMailContainer.module.css'
import ButtonMail from './ButtonMail'

import Swal from 'sweetalert2'
import Alert from '../Alerts/Alert'

import { UserContext } from '../../context/UserContext'
import { useEffect, useContext, useState } from 'react'

export default function SendMailContainer({btnCancel}) {
    const { users, getAllUsers } =  useContext(UserContext)
    
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
        if(msgData.assunto == null || msgData.mensagem == null){
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
                    console.log(msgData)
                }
              }
            )
        } else {
            console.log(msgData)
        }
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
                    <option value={null} disabled selected>Selecione um usuário</option>
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