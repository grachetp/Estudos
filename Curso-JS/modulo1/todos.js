//Puxandos elementos da página
var listElement = document.querySelector('#app ul');
var inputElement = document.querySelector('#app input');
var buttonElement = document.querySelector('#app button');

//Array dos itens
//Converte os valores armazenados no Storage de JSON para Array
var todos = JSON.parse(localStorage.getItem('list_todos')) || [];

//Função para rederenizar os itens
function renderTodos(){
    //Setando itens para null, para não ficar duplicado quando atualizar a página.
    listElement.innerHTML = '';
    
    //Dando um for na lista pra ler e exibir no html
    for(todo of todos){
        //criando o item com a tag li
        var todoElement = document.createElement('li');
        //Criando uma var pra guardar o texto do item do array
        var todoText = document.createTextNode(todo);

        //criando um elemento de tag a
        var linkElement = document.createElement('a');
        //setando atributos no elemento de tag a
        linkElement.setAttribute('href', '#');

        //guardando a posicao do item do todo para posteriormente instanciar ele na tag a
        var pos = todos.indexOf(todo);

        //setando um atributo na tag a com evento onclick com posicao
        linkElement.setAttribute('onclick', 'deleteTodo(' + pos + ')');

        //setando um texto na variavel pra jogar dentro do link
        var linkText = document.createTextNode('Excluir');

        //adicionando um texto no elemento do link
        linkElement.appendChild(linkText);

        //adicionando texto do todo no elemento
        todoElement.appendChild(todoText);
        //adicionando ling no todo do elemento
        todoElement.appendChild(linkElement);
        //adicionando o elemento na lista de todo
        listElement.appendChild(todoElement);
    }
}

//Chama função de renderenizar os TODO'S
renderTodos();

//Função para adicionar um TODO a lista de TODOS
function addTodo(){
    //pega o valor do input e joga em uma variável
    var todoText = inputElement.value;
    //adiciona o valor passado por referencia no fim do array
    todos.push(todoText);
    //Zera o input
    inputElement.value = '';
    //Rendereniza a lista de TODOS
    renderTodos();
    saveToStorage();
};

//Adiciona a funcao de onclick no button, com referencia da funcao addTodo();
buttonElement.onclick = addTodo;

//Deletear um item da lista por posicao do array passado por referencia
function deleteTodo(pos){
    //remove o item naquela posicao e o primeiro daquela posicao
    todos.splice(pos, 1);
    //rendereniza tudo de novo
    renderTodos();
    saveToStorage();
}


function saveToStorage(){
    //Converte os valores do array para JSON para armazenar no localStorage
    localStorage.setItem('list_todos', JSON.stringify(todos));
}
//Caro Sr. Pedro Grachet, creio que você esteja vendo esse código daqui uns 10 ou 20 anos. Hoje é dia 11/02/2020, e minha perspectiva de futuro é que eu esteja formado em ciencia da computacao com pelo menos um mestrado e que esteja trabalhando ou pra mim ou em uma empresa que seja bem nomeada com uma equipe fabulosa e que eu possa ajudar os estagiários assim como o rafael me ajudou.
//De eu, para mim mesmo.