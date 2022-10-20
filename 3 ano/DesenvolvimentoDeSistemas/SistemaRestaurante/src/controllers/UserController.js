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

}