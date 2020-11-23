const Sequelize = require('sequelize'); //Importando sequelize
const sequelize = new Sequelize('teste', 'root', 'root', {
	host: "localhost",
	dialect: 'mysql'
}); //criando conexão ao banco


//Testando conexão
sequelize.authenticate().then(function(){
	console.log('Conectado com sucesso!')
}).catch(function(erro) {
		console.log(`Falha ao conectar. Erro: ${erro}`)
});


//Criando um model de postagem
//define a tabela e os campos dentro do dicionário
const Postagem = sequelize.define('postagens', {
	titulo: {
		type: Sequelize.STRING
	},
	conteudo: {
		type: Sequelize.TEXT
	}
})

//chamando objeto Postagem e sincronizando no banco de dados
//Postagem.sync({
//	force: trues
//})


//Inserir no banco de dados
Postagem.create({
	titulo: "TItulo qualuqer",
	conteudo: "odfhodifhlsdfhldfhkksdhfl"
})


const Usuario = sequelize.define('usuarios', {
	nome: {
		type: Sequelize.STRING
	},
	sobrenome: {
		type: Sequelize.STRING
	},
	idade: {
		type: Sequelize.INTEGER
	},
	email: {
		type: Sequelize.STRING
	}
})


//Usuario.sync({
//	force: true
//})

Usuario.create({
	nome: "Pedro",
	sobrenome: "Grachet",
	idade: 20,
	email: "pedro.grachet@gmail.com"
})