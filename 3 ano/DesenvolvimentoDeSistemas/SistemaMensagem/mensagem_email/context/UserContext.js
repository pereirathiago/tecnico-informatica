import { useState, createContext } from 'react'
import Swal from 'sweetalert2'
import Alert from '../components/Alerts/Alert'

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

    const deleteUsers = async (user) => {
        Swal.fire({
            title: 'Deseja excluir o usuario?',
            text: "Isso não pode ser desfeito!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sim, deletar!'
          }).then((result) => {
            if (result.isConfirmed) {
                fetch(`${process.env.NEXT_PUBLIC_API_URL}/user/${user}`,{
                    method: 'DELETE',
                    headers: {
                        'Content-Type': 'application/json; charset=utf-8'
                    }
                }).then(((resp) => {
                    if(resp.status == 200) {
                        Alert({message: `Usuario deletada com sucesso`, type: 'success'})
                        return getMsgs(user)
                    }
                    else {
                        return Alert({message: 'Erro ao deletar Usuario', type: 'error'})
                    }
                }))
                .catch(err => console.error(err))
            } else {
                Alert({message: 'Usuario não deletado', type: 'info'})
            }
          })
    }

    const createUser = async (data) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/user`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify(data)
        }).then(((resp) => {
            if(resp.status == 201) {
                Alert({message: `Usuario criado com sucesso`, type: 'success'})
                return getAllUsers()
            } else if(resp.status == 409 ){
                Alert({message: 'Usuario já existe', type: 'error'})
            }
            else {
                return Alert({message: 'Erro ao criar Usuario', type: 'error'})
            }
        }))
            .catch(err => console.error(err))
    }

    return <UserContext.Provider value={{
        getAllUsers,
        deleteUsers,
        createUser,
        users
    }}>{children}</UserContext.Provider>
}