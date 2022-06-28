import { useEffect, useState, createContext } from 'react'

import Swal from 'sweetalert2'
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

    const deleteMsgs = async (idMsg) => {
        Swal.fire({
            title: 'Deseja excluir a mensagem?',
            text: "Isso não pode ser desfeito!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sim, deletar!'
          }).then((result) => {
            if (result.isConfirmed) {
                fetch(`${process.env.NEXT_PUBLIC_API_URL}/msg/${idMsg}`,{
                    method: 'DELETE',
                    headers: {
                        'Content-Type': 'application/json; charset=utf-8'
                    }
                }).then(((resp) => {
                    if(resp.status == 200) {
                        Alert({message: `Mensagem deletada com sucesso`, type: 'success'})
                        return true
                    }
                    else {
                        return Alert({message: 'Erro ao deletar mensagem', type: 'error'})
                    }
                }))
                .catch(err => console.error(err))
            } else {
                Alert({message: 'Mensagem não deletada', type: 'info'})
            }
          })
    }


    return <MsgsContext.Provider value={{
        getMsgs,
        deleteMsgs,
        msgs
    }}>{children}</MsgsContext.Provider>
}