function experiencia(anos){
    switch(true){
        case anos >= 0 && anos <= 1:
            console.log('Iniciante');
            break;
        case anos >= 1 && anos <= 3:
            console.log('Intermediário');
            break;
        case anos >=3 && anos <=6:
            console.log('Avançado');
            break;
        case anos >= 7:
            console.log('Jedi Master');
            break;
    }
}
var anosEstudo = 3;
experiencia(anosEstudo);