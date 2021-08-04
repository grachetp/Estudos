const mongoose = require("mongoose");
const Schema = mongoose.Schema;

//Configurando Mongoose
  mongoose.Promise = global.Promise;
  mongoose.connect("mongodb://localhost/aprendendo", {
    useNewUrlParser: true,
    useUnifiedTopology: true
  }).then(() => {
    console.log("MongoDB conectado com sucesso!")
  }).catch((err) => {
    console.log("Houve um erro ao se conectar ao mongoDB: " + err)
  })

// Model - Usuários

//Definindo o Model
  const UsuarioSchema = new Schema({
    nome: {
      type: String,
      require: true
    },
    sobrenome:{
      type: String,
      require: true
    },
    email:{
      type: String,
      require: true
    },
    idade:{
      type: Number,
      require: true
    },
    pais: {
      type: String
    }
  })

  //Collection
  mongoose.model('usuarios', UsuarioSchema)

  const Pedro = mongoose.model('usuarios')

  //Criando Usuário
  new Pedro({
    nome: "Pedro",
    sobrenome: "Grachet",
    email: "pedro.grachet@gmail.com",
    idade: 18,
    pais: "Brasil"
  }).save().then(() => {
    console.log("Salvo com sucesso!")
  }).catch((err) => {
    console.log("Erro ao criar usuário: " + err)
  })