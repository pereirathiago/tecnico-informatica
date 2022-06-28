import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default {
    async sendMsg(req, res) {
        try {
            const { destinatario, assunto, mensagem } = req.body
            const { usuario } = req.params
            const msg = await prisma.mensagem.create({
                data: {
                    destinatario,
                    assunto,
                    mensagem,
                    remetente: usuario
                },
            })
            return res
                .status(201)
                .json({ message: 'Msg enviada', msg })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findAllMsg(req, res) {
        try {
            const msgs = await prisma.mensagem.findMany()
            return res.status(200).json(msgs)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findMsg(req, res) {
        try {
            const { usuario } = req.params
            const msgs = await prisma.mensagem.findMany({orderBy: [{data: 'desc'}]}, { where: { destinatario: usuario } })
            if (!msgs)
                return res.status(404).json({ message: 'Nehnuma mensagem encontrado' })
            
            return res.status(200).json(msgs)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async deleteMsg(req, res) {
        try {
            const { id } = req.params
            const msg = await prisma.mensagem.findUnique({ where: { id: Number(id) } })
            if (!msg)
                return res.status(404).json({ message: 'Mensagem não encontrado' })

            await prisma.mensagem.delete({ where: { id: Number(id) } })

            return res.status(200).json({
                message: 'Mensagem deletada com sucesso',
                msg,
            })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    }
}