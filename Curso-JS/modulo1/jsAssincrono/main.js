//Para fazer requisições via API, podendo passar varior parametros dentro desse valor
axios.get('https://api.github.com/users/grachetp')
//Chama a método da funcao minhaPromisse e espera retornar algum valor
//fazendo o tratamento de dados, retornando o valor de resposta;
    .then(function(response){
        console.log(response);
    })
    .catch(function(error){
        console.warn(error);
    });