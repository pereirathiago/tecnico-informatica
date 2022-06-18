import styles from '../../styles/ButtonMail.module.css'

export default function ButtonMail({text, func, styleClass}) {
    return (
        <div className={styles.btnContainer}>
            <button className={styleClass == 'btn1' ? styles.btn1 : styles.btn2} onClick={func}>{text}</button>
        </div>
    )
}