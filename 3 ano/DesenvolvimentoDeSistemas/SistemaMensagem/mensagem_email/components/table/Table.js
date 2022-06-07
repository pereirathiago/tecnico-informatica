import Row from "./Row";

import styles from '../../styles/Table.module.css'

export default function Table() {
    return (
        <div className="center">
            <table className={styles.table}>
                <thead>
                    <tr className={styles.tr}>
                        <th scope="col" className={styles.th}>Remetente</th>
                        <th scope="col" className={styles.th}>Destinatario</th>
                        <th scope="col" className={styles.th}>Assunto</th>
                        <th scope="col" className={styles.th}>Data</th>
                        <th scope="col" className={styles.th}>Mensagem</th>
                    </tr>
                </thead>
                <tbody>
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                    <Row />
                </tbody>
            </table>
        </div>
    )
}