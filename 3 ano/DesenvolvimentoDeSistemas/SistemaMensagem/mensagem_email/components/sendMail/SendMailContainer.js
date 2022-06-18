import styles from '../../styles/Home.module.css'
import ButtonMail from './ButtonMail'
import InputMail from './InputMail'

export default function SendMailContainer() {
    return (
        <div className={styles.container}>
            <h1 className={styles.h1}>Enviar Mensagem</h1>
            <InputMail />
            <ButtonMail text="Enviar Mensagem"/>
        </div>
    )
}