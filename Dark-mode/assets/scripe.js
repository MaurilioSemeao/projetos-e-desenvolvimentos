const container = document.getElementById('div-container');
const h1 = document.getElementById('texth1');
const btn = document.querySelectorAll('button')[0];
const theme = "dark-mode";
const themePadrao = "light-mode";


function mudaClasse(){
    btn.classList.toggle(theme);
    btn.classList.toggle(themePadrao);
    h1.classList.toggle(theme);
    h1.classList.toggle(themePadrao);
    container.classList.toggle(theme);
    container.classList.toggle(themePadrao);

}

function mudaTexto(){
    const ligtString = "Ligth Mode";
    const darkString = "Dark Mode";

    if(container.classList.contains(theme)){
        btn.innerHTML = ligtString;
        h1.innerHTML = darkString + " On";
        return ;
    }

    btn.innerHTML = darkString;
    h1.innerHTML = ligtString + " On";
    return;
}


btn.addEventListener('click', function(e){
    mudaClasse();
    mudaTexto();
},false)