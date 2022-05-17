import { Router } from 'express'
import UserController from './controllers/UserController'

const router = Router()

router.post("/user", UserController.createUser)
router.get("/users", UserController.findAllUsers)
router.get("/user/:usuario", UserController.findUser)
router.put("/user/:usuario", UserController.updateUser)
router.delete("/user/:usuario", UserController.deleteUser)

export { router }