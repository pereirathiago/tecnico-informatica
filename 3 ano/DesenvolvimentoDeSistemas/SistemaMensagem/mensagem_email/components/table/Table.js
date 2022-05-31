import Row from "./Row";

import styles from '../../styles/Table.module.css'

export default function Table() {
    return (
        <div>
            <table className="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Remetente</th>
                        <th scope="col">Destinatario</th>
                        <th scope="col">Assunto</th>
                        <th scope="col">Data</th>
                        <th scope="col">Mensagem</th>
                    </tr>
                </thead>
                <tbody>
                    <Row />
                    <Row />
                    <Row />
                </tbody>
            </table>
        </div>
    )
}