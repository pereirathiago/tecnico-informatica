import { Router } from 'express'
import UserController from './controllers/UserController'
import PlatesController from './controllers/PlatesController'
import PedidosController from './controllers/PedidosController'

const router = Router()

router.post("/user", UserController.createUser)
router.get("/users", UserController.findAllUsers)
router.get("/user/:username", UserController.findUser)
router.put("/user/:username", UserController.updateUser)
router.delete("/user/:username", UserController.deleteUser)
router.post("/user/login", UserController.loginUser)

router.post("/prato", PlatesController.createDish)
router.get("/pratos", PlatesController.findAllDishes)
router.get("/prato/:idp", PlatesController.findDish)
router.put("/prato/:idp", PlatesController.updateDish)
router.delete("/prato/:idp", PlatesController.deleteDish)

router.post("/pedido", PedidosController.createPedido)
router.get("/pedidos", PedidosController.findAllPedidos)
router.get("/pedido/:idp", PedidosController.findPedido)
router.put("/pedido/:idp", PedidosController.updatePedido)

export { router }