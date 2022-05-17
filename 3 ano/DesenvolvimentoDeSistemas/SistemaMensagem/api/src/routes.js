import { Router } from 'express'
import UserController from './controllers/UserController'

const router = Router()

router.post("/user", UserController.createUser)
router.get("/users", UserController.findAllUsers)

export { router }