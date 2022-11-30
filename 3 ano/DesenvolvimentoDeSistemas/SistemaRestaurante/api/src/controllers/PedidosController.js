import { PrismaClient } from '@prisma/client'
const prisma = new PrismaClient()

export default{
    async createPedido(req, res) {
        try {
            const { idPrato, nome_pedido, mesa, status } = req.body

            let pedido = await prisma.pedido.create({
                data: {
                    idPrato,
                    nome_pedido,   
                    mesa,
                    status: 'Em espera',
                },
            })
            return res
                .status(201)
                .json({ message: 'Pedido created', pedido })
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findAllPedidosEmEspera(req, res) {
        try {
            const pedidos = await prisma.pedido.findMany({
                where: {status: "Em espera"},
                orderBy: {
                    mesa: 'asc',
                },
            })
            return res.status(200).json(pedidos)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    }, 

    async findAllPedidosEmAndamento(req, res) {
        try {
            const pedidos = await prisma.pedido.findMany({
                where: {status: "Em andamento"},
                orderBy: {
                    mesa: 'asc',
                },
            })
            return res.status(200).json(pedidos)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findAllPedidosPronto(req, res) {
        try {
            const pedidos = await prisma.pedido.findMany({
                where: {status: "Pronto"},
                orderBy: {
                    mesa: 'asc',
                },
            })
            return res.status(200).json(pedidos)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async findPedido(req, res) {
        try {
            const { mesa } = req.params
            const pedido = await prisma.pedido.findMany({ 
                where: { mesa: mesa }
            })
            if (!pedido)
                return res.status(404).json({ message: 'Nenhum pedido em espera na mesa' })
            return res.status(200).json(pedido)
        } catch (error) {
            return res.json({ error })
        } finally {
            ;async () => {
                await prisma.$disconnect()
            }
        }
    },

    async updatePedido(req, res) {
        try {
            const { idp } = req.params
            const { status } = req.body

            let pedido = await prisma.pedido.findUnique({ where: { id: parseInt(idp) } })
            if (!pedido)
                return res.status(404).json({ message: 'Pedido não encontrado' })

                pedido = await prisma.pedido.update({
                where: { id: parseInt(idp) },
                data: { status }
            })

            return res.status(200).json({
                message: 'Pedido atualizado com sucesso',
                pedido,
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