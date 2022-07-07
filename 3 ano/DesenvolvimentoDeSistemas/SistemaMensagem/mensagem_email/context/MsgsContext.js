import { useEffect, useState, createContext } from 'react'

import Swal from 'sweetalert2'
import Alert from '../components/Alerts/Alert'

export const MsgsContext = createContext() 

export function MsgsProvider({ children }){
    const [msgs, setMsgs] = useState([])
    const [msg, setMsg] = useState([])

    const getMsgs = async (username) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/msgs/user/${username}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            }
        })
        .then(((resp) => {
            setMsgs([])
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

    const sendMsg = (msg, user) => {
        if(msg.destinatario == ''){
            Alert({message: 'Selecione um destinatário', type: 'error'})
            return
        } else{
            fetch(`${process.env.NEXT_PUBLIC_API_URL}/msg/user/${user}`, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                },
                body: JSON.stringify(msg)
            })
            .then(((resp) => {
                console.log(resp)
                if(resp.status == 201) {

                    return Alert({message: 'Mensagem enviada com sucesso', type: 'success'})
                }
                else {
                    return Alert({message: 'Erro ao enviar mensagem', type: 'error'})
                }
            }))
            .then(((data) => {
                getMsgs(user)
            }))
            .catch(err => console.error(err))
        }
    }

    const deleteMsgs = async (idMsg, user) => {
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
                        window.location.href = '/'
                        return getMsgs(user)
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

    const verifyMsgs = async (user) => {
        setMsgs([])
        getMsgs(user).then(
            function (response) {
                alert(msgs.length)
                if(msgs.length == 0) {
                    return true
                } else {
                    return false
                }
            }
        )
    }

    const getMsg = async (id) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/msgs/msg/${id}`, {
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
                return Alert({message: 'Mensagem não encontrada', type: 'error'})
            }
        }))
        .then(((data) => {
            setMsg(data)
        }))
        .catch(err => console.error(err))
    }

    return <MsgsContext.Provider value={{
        getMsgs,
        deleteMsgs,
        sendMsg,
        verifyMsgs,
        getMsg,
        msg,
        msgs
    }}>{children}</MsgsContext.Provider>
}