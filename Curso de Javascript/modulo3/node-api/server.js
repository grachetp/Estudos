const express = require('express');
const cors = require('cors');
const mongoose = require('mongoose');
const requireDir = require('require-dir');

//Iniciando o App
const app = express();
//Permitir o envio de dados via JSON
app.use(express.json());
app.use(cors());

//Iniciando o BD
mongoose.connect(
  'mongodb://localhost:27017/nodeapi', 
  {
   useNewUrlParser: true,
   useUnifiedTopology: true
});

//Importando os Models
requireDir('./src/models');

//Rotas
app.use('/api', require('./src/routes'));

//Rodando a aplicação
app.listen(3001);