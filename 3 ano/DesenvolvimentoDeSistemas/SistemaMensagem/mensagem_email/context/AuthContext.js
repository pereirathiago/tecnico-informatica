import { createContext, useState, useEffect } from "react";
import { useRouter } from 'next/router'
import cookie from 'js-cookie'

import Alert from '../components/Alert'

export const AuthContext = createContext();

export function AuthProvider({ children }) {
    const [user, setUser] = useState(null)
    const [loading, isLoading] = useState(false)

    const router = useRouter()

    const loginUser = async (dados) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/user/login`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify({"usuario": dados.name, "senha": dados.password})
        })
        .then(((resp) => {
            isLoading(true)
            setTimeout(() => {
                if(resp.status == 200) {
                    isLoading(false)
                    cookie.set('user-auth', dados.name, { expires: 1 })
                    router.push('/') 
                }
                else {
                    isLoading(false)
                    Alert({message: 'Usuário ou senha incorretos', type: 'error'})
                }
            }, 300)
        }))
        .catch(err => console.error(err))   
    }

    const getUserLogger = (username) => {
        fetch(`${process.env.NEXT_PUBLIC_API_URL}/user/${username}`, {
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
            if(data) {
                setUser(data)
            }
        }))
        .catch(err => console.error(err))
    }

    const logout = () => {
        cookie.remove('user-auth')
        setUser(null)
        router.push('/login')
    }

    return <AuthContext.Provider value={{
        user,
        loading,
        loginUser,
        getUserLogger,
        logout
    }}>{children}</AuthContext.Provider>
}