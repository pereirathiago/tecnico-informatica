import express from 'express';

import {router} from './routes'

var cors = require('cors')


const app = express();

app.use(cors()) 
app.use(express.json())
app.use(router)

app.listen(3030, () => console.log('Server listening on port 3030'))