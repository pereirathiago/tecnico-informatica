import { useEffect, useState, createContext } from 'react'

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


    return <MsgsContext.Provider value={{
        getMsgs,
        msgs
    }}>{children}</MsgsContext.Provider>
}