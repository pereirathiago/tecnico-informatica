import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default{
    async createDish(req, res) {
        try {
            const { nome, descricao, preco } = req.body
            let dish = await prisma.admin_pratos.findUnique({ where: { nome } })

            if (dish) {
                return res.status(409).json({ message: 'Name is already used' })
            }

            dish = await prisma.admin_pratos.create({
                data: {
                    nome,
                    descricao,   
                    preco,
                },
            })
            return res
                .status(201)
                .json({ message: 'Prato created', dish })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findAllDishes(req, res) {
        try {
            const dishs = await prisma.admin_pratos.findMany()
            return res.status(200).json(dishs)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    }, 

    async findDish(req, res) {
        try {
            const { idp } = req.params
            const dish = await prisma.admin_pratos.findUnique({ 
                where: { id: parseInt(idp) }
            })
            if (!dish)
                return res.status(404).json({ message: 'Prato não encontrado' })
            return res.status(200).json(dish)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async updateDish(req, res) {
        try {
            const { idp } = req.params
            const { nome, descricao, preco } = req.body

            let dish = await prisma.admin_pratos.findUnique({ where: { id: parseInt(idp) } })
            if (!dish)
                return res.status(404).json({ message: 'Prato não encontrado' })

            dish = await prisma.admin_pratos.update({
                where: { id: parseInt(idp) },
                data: { nome, descricao, preco }
            })

            return res.status(200).json({
                message: 'Prato atualizado com sucesso',
                dish,
            })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async deleteDish(req, res) {
        try {
            const { idp } = req.params
            const dish = await prisma.admin_pratos.findUnique({ where: { id: Number(idp) } })
            if (!dish)
                return res.status(404).json({ message: 'Usurario não encontrado' })

            await prisma.admin_pratos.delete({ where: { id: Number(idp)} })

            return res.status(200).json({
                message: 'Usuário deletado com sucesso',
                dish,
            })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },
}