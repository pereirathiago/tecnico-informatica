import styles from '../../styles/Row.module.css'

export default function Row() {
    return (
        <>
            <tr className={styles.row}>
                <td>remetente</td>
                <td>dest</td>
                <td>assunto</td>
                <td>data</td>
                <td>
                    <div className={styles.msgTable}>
                        MensageMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemMensagemm
                    </div>
                </td>
            </tr>
        </>
    )
}