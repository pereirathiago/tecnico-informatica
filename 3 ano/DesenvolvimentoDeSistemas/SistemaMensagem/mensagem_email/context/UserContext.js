import { useState, createContext } from 'react'

export const UserContext = createContext()

export function UserProvider({ children }) {
    const [users, setUsers] = useState([])

    const getAllUsers = () => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/users`, {
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
                return Alert({message: 'Nenhum usuário encontrado', type: 'error'})
            }
        })).then(((data) => {
            setUsers(data)
        }
        )).catch(err => console.error(err))
    }

    return <UserContext.Provider value={{
        getAllUsers,
        users
    }}>{children}</UserContext.Provider>
}