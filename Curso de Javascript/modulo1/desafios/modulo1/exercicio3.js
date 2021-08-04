function temHabilidade(skills){
    var result;
    //Valor de um resultado que não existe é -1
    if(skills.indexOf('Javascript') !== -1){
        console.log('True')
    }else{
        console.log('False');
    }
}

var skills = ["Javascript", "ReactJS", "ReactNative"];
temHabilidade(skills);