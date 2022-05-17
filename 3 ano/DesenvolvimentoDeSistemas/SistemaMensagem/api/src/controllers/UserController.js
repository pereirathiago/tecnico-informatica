import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default {
    async createUser(req, res) {
        try {
            const { usuario, nome, senha } = req.body
            let user = await prisma.usuario.findUnique({ where: { usuario } })

            if (user) {
                return res.status(409).json({ message: 'User is already used' })
            }

            user = await prisma.usuario.create({
                data: {
                    usuario,
                    nome,
                    senha
                },
            })
            return res
                .status(201)
                .json({ message: 'User created', user })
        } catch (error) {
            return res.json({ error })
        }
    },

    async findAllUsers(req, res) {
        try {
            const users = await prisma.usuario.findMany()
            return res.status(200).json(users)
        } catch (error) {
            return res.json({ error })
        }
    },

    async findUser(req, res) {
        try {
            const { usuario } = req.params
            const user = await prisma.usuario.findUnique({ where: { usuario } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })
            return res.status(200).json(user)
        } catch (error) {
            return res.json({ error })
        }
    },

    async updateUser(req, res) {
        try {
            const { usuario } = req.params
            const { nome, senha } = req.body

            let user = await prisma.usuario.findUnique({ where: { usuario } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })

            user = await prisma.usuario.update({
                where: { usuario },
                data: { nome, senha }
            })

            return res.status(200).json({
                message: 'Usuário atualizado com sucesso',
                user,
            })
        } catch (error) {
            return res.json({ error })
        }
    },

    async deleteUser(req, res) {
        try {
            const { usuario } = req.params
            const user = await prisma.usuario.findUnique({ where: { usuario } })
            if (!user)
                return res.status(404).json({ message: 'Usurario não encontrado' })

            await prisma.usuario.delete({ where: { usuario } })

            return res.status(200).json({
                message: 'Usuário deletado com sucesso',
                user,
            })
        } catch (error) {
            return res.json({ error })
        }
    }
}