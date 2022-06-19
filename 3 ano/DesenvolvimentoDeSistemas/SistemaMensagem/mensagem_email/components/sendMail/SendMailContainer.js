import styles from '../../styles/Home.module.css'
import ButtonMail from './ButtonMail'
import InputMail from './InputMail'
import TextAreaMail from './TextAreaMail'

import { UserContext } from '../../context/UserContext'
import { useEffect, useContext } from 'react'

export default function SendMailContainer() {
    const { users, getAllUsers } =  useContext(UserContext)
    
    const [destinatario, setDestinatario] = useState()
    const [assunto, setAssunto] = useState()
    const [mensagem, setMensagem] = useState()

    useEffect(() => {
        getAllUsers()
    }, [])

    


    return (
        <div className={styles.container}>
            <form onSubmit={null}>
                <h1 className={styles.h1}>Enviar Mensagem</h1>
                <select name="select" required>
                    <option value={null} disabled selected>Selecione um usuário</option>
                    {users.map((user, index) => {
                        return <option key={index} value={user.usuario}>{user.nome}</option>
                    }
                    )}
                </select>
                <InputMail />
                <TextAreaMail />

                <ButtonMail text="Enviar Mensagem"/>
            </form>
        </div>
    )
}