import express from 'express'
const app  = express()

app.use(express.json())

app.listen(3030, () => console.log('Server is running in port 3030'))