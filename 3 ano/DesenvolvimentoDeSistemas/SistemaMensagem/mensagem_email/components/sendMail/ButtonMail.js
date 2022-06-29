import styles from '../../styles/ButtonMail.module.css'

export default function ButtonMail({text, func, styleClass}) {
    return (
        <div className={styles[styleClass]}>
            <button className={styles.btn1} onClick={func}>{text}</button>
        </div>
    )
}