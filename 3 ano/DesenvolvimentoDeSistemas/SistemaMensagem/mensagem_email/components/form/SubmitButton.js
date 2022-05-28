import {FaSpinner} from 'react-icons/fa'
import styles from '../../styles/SubmitButton.module.css'

export default function SubmitButton({text}) {
    return (
        <div>
            <button className={styles.btn}>
                {text ? text : <FaSpinner icon="spinner" className={styles.spinner} />}
            </button>
        </div>
    )
}