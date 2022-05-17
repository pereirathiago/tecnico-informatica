import { Router } from 'express'
import { PrismaClient } from '@prisma/client'

const router = Router()

const prisma = new PrismaClient()

router.post("/user", async (req, res) => {
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
})

export { router }