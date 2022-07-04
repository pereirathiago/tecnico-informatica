import styles from '../../styles/SendMailContainer.module.css'
import ButtonMail from './../sendMail/ButtonMail'

import Swal from 'sweetalert2'
import Alert from '../Alerts/Alert'

import { UserContext } from '../../context/UserContext'
import { useEffect, useContext, useState } from 'react'

export default function SendMailContainer({btnCancel, user, type}) {
    const { users, createUser } =  useContext(UserContext)
    
    const [UserData, setUserData] = useState([])

    function handleChange(e) {
        setUserData({ ...UserData, [e.target.name]: e.target.value })
    } 

    const createdUser = async () => {
        if(UserData == null || UserData.length == 0){
            Alert({ message: 'Preencha todos os campos', type: 'error'} )
        } else if(UserData.senha.length < 6) {
            Alert({ message: 'A senha deve ter no mínimo 6 caracteres', type: 'error'} )
        } else if(UserData.usuario.indexOf(" ") >= 0) {
            Alert({ message: 'O usuario não pode conter espaços', type: 'error'} )
        } else if(UserData.usuario.length > 10) {
            Alert({ message: 'O usuario não pode conter mais de 10 caracteres', type: 'error'} )
        }
        else {
            await createUser(UserData)
            setUserData({'usuario': '', 'senha': '', 'nome': ''})
        }
    }

    return (
        <div className={styles.container} id="sendMailContainer">
            <form onSubmit={null} className={styles.form}>
                <h1 className={styles.h1}>{type} Usuario</h1>

                <label>Usuario</label>
                <input type="text" className={styles.input} name="usuario" placeholder="Digite o Usuario" onChange={handleChange} value={UserData.usuario || user[0]}/>

                <label htmlFor="nome">Nome</label>
                <input 
                type="text" 
                placeholder="Digite o nome..." 
                name="nome"  
                onChange={handleChange} 
                value={UserData.nome ? UserData.nome : '' || user[1]}
                required/>

                <label>Senha</label>
                <input 
                type="password" 
                placeholder="Digite a senha..." 
                name="senha"  
                onChange={handleChange} 
                value={UserData.senha ? UserData.senha : '' || user[2]}
                required/>

            </form>
                <div className={styles.buttons}>
                    <ButtonMail styleClass="btnContainerCenter" func={createdUser} text={type}/>
                    <ButtonMail styleClass="btnContainerCenter" func={btnCancel} text="Cancelar"/>
                </div>
        </div>
    )
}