 //Criando o express
var express = require("express");

//Variável app recebendo função EXPRESS(Criando uma instancia do framework)
const app = express(); 

//Criando rota principal
app.get("/", function(req, res){
	res.sendFile(__dirname + "/templates/index.html");
});

//rota sobre
app.get("/sobre", function(req, res){
	res.send("Minha pagina sobre! hehe");
});

//rota blog
app.get("/blog", function(req, res){
	res.send("<h1>Pagina blog<h1>");
});

app.get("/ola/:name/:cargo", function(req, res){
	res.send(`<h1>Ola ${req.params.name}</h1><br><h2>Seu cargo e: ${req.params.cargo}</h2>`);
})

//Criando o servidor {Tem que ser a ultima linha do código}
app.listen(3128, function(){
	console.log("Sevidor rodando na url htttp://localhost:3128")
});
