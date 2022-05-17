import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default {
    async createUser(req, res) {
        try {
            const { usuario, nome, senha } = req.body
            let user = await prisma.usuario.findUnique({ where: { usuario } })

            if (user) {
                return res.json({ error: 'Já existe um usuario com esse email' })
            }

            user = await prisma.usuario.create({
                data: {
                    usuario,
                    nome,
                    senha
                },
            })
            return res.json(user)
        } catch (error) {
            return res.json({ error })
        }
    },

    async findAllUsers(req, res) {
        try {
            const users = await prisma.usuario.findMany()
            return res.json(users)
        } catch (error) {
            return res.json({ error })
        }
    },

    async findUser(req, res) {
        try {
            const { usuario } = req.params;
            const user = await prisma.usuario.findUnique({ where: { usuario } })
            if(!user) 
                return res.json({error: 'Usuário não encontrado'})
            return res.json(user)
        } catch (error) {
            return res.json({ error })
        }
    },
}