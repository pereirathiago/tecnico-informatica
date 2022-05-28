import styles from '../styles/Loading.module.css'
import Image from 'next/image'


export default function Loading() {
    return (
        <div className={styles.loader_container}>
            <Image src="/loading.svg" alt="Carregando..." width={50} height={50} className={styles.loader}/>
        </div>
    )
}