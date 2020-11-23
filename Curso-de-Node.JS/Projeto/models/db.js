//Importando Sequelize
const Sequelize = require("sequelize");

// Conexão do Banco de Dados
		const sequelize = new Sequelize('postapp', 'root', 'root', {
			host: "localhost",
			dialect: "mysql"
		});

module.exports = {
	Sequelize: Sequelize,
	sequelize: sequelize
}