import { Router } from 'express'
import UserController from './controllers/UserController'
import MsgController from './controllers/MsgController'

const router = Router()

router.post("/user", UserController.createUser)
router.get("/users", UserController.findAllUsers)
router.get("/user/:usuario", UserController.findUser)
router.put("/user/:usuario", UserController.updateUser)
router.delete("/user/:usuario", UserController.deleteUser)
router.post("/user/login", UserController.loginUser)

router.post("/msg/user/:usuario", MsgController.sendMsg)
router.get("/msgs", MsgController.findAllMsg)
router.get("/msgs/user/:usuario", MsgController.findMsg)
router.delete("/msg/:id", MsgController.deleteMsg)

export { router }