import { Router } from 'express'
import UserController from './controllers/UserController'

const router = Router()

router.post("/user", UserController.createUser)
router.get("/users", UserController.findAllUsers)
router.get("/user/:username", UserController.findUser)
router.put("/user/:username", UserController.updateUser)
router.delete("/user/:username", UserController.deleteUser)
router.post("/user/login", UserController.loginUser)

export { router }