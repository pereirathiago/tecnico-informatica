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
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

}