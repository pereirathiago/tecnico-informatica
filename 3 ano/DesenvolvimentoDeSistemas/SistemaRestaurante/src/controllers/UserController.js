import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default {
    async createUser(req, res) {
        try {
            const { username, nome, senha } = req.body
            let user = await prisma.admin_users.findUnique({ where: { username } })

            if (user) {
                return res.status(409).json({ message: 'User is already used' })
            }

            user = await prisma.admin_users.create({
                data: {
                    username,
                    nome,   
                    senha
                },
            })
            return res
                .status(201)
                .json({ message: 'User created', user })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findAllUsers(req, res) {
        try {
            const users = await prisma.admin_users.findMany()
            return res.status(200).json(users)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    }, 

    async findUser(req, res) {
        try {
            const { username } = req.params
            const user = await prisma.admin_users.findUnique({ where: { username } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })
            return res.status(200).json(user)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async updateUser(req, res) {
        try {
            const { username } = req.params
            const { nome, senha } = req.body

            let user = await prisma.admin_users.findUnique({ where: { username } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })

            user = await prisma.admin_users.update({
                where: { username },
                data: { nome, senha }
            })

            return res.status(200).json({
                message: 'Usuário atualizado com sucesso',
                user,
            })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async deleteUser(req, res) {
        try {
            const { username } = req.params
            const user = await prisma.admin_users.findUnique({ where: { username } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })

            await prisma.admin_users.delete({ where: { username } })

            return res.status(200).json({
                message: 'Usuário deletado com sucesso',
                user,
            })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async loginUser(req, res) {
        try {
            const { username, senha } = req.body
            const user = await prisma.admin_users.findUnique({ where: { username: username }})
    
            if(user){
                if(senha == user.senha){
                    return res.status(200).json({ message: 'login feito' }) 
                }
            }
            return res.status(401).json({message: "usuário ou senha incorreto"})
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    }
}