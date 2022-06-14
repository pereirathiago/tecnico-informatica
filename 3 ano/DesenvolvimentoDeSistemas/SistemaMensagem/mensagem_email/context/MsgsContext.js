import { useEffect, useState, createContext } from 'react'

import Alert from '../components/Alerts/Alert'

export const MsgsContext = createContext() 

export function MsgsProvider({ children }){
    const [msgs, setMsgs] = useState([])

    const getMsgs = (username) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/msgs/user/${username}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        })
        .then(((resp) => {
            if(resp.status == 200) {
                return resp.json()
            }
            else {
                return Alert({message: 'Usuário não encontrado', type: 'error'})
            }
        }))
        .then(((data) => {
            setMsgs(data)
        }))
        .catch(err => console.error(err))
    }

    const deleteMsgs = (idMsg) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/msg/${idMsg}`,{
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        }).then(((resp) => {
            if(resp.status == 200) {
                Alert({message: 'Mensagem excluída com sucesso', type: 'confirm'})
                return resp.json()
            }
            else {
                return Alert({message: 'Erro ao deletar mensagem', type: 'error'})
            }
        }))
        .catch(err => console.error(err))
    }


    return <MsgsContext.Provider value={{
        getMsgs,
        deleteMsgs,
        msgs
    }}>{children}</MsgsContext.Provider>
}