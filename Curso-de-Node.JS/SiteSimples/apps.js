var http = require('http');

http.createServer(function(req, res) {
	res.end("Hello World! Welcome to my website");
}).listen(3128); //Criar servidor e selecionar a porta

console.log("O servidor estah rodando!")