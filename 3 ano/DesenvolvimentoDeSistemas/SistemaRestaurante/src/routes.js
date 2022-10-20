import { Router } from 'express'
import UserController from './controllers/UserController'

const router = Router()

router.post("/user", UserController.createUser)


export { router }