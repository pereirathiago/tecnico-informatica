import styles from '../../styles/Row.module.css'

export default function Row({msg}) {  

    return (
        <>
            <tr className={styles.row}>
                <td>{msg.remetente}</td>
                <td>{msg.destinatario}</td>
                <td>{msg.assunto}</td>
                <td>{msg.data}</td>
                <td>
                    <div className={styles.msgTable}>
                        {msg.mensagem}
                    </div>
                </td>
            </tr>
        </>
    )
}