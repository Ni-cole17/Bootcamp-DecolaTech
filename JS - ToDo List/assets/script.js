//Crie um campo de input de texto e um botão para adicionar a tarefa à lista;
//Quando o botão for pressionado, o texto deve aparecer na lista com um checkbox ao lado;
//Quando o usuário selecionar o checkbox, o item correspondente deve ficar com o texto riscado. (ex.: tarefa completa.dica: você pode resolver isso facilmente com CSS)
var count = 0
function criar_lista(){
    let id = count;
    var lista = document.querySelector('.lista');
    var elementos = document.getElementById('elementos'); //usei getElementById() por opção você pode resgatar a referência do seu node como quiser.
    var input = document.getElementById("Resplista").value;
    var clone = elementos.cloneNode(true); //aqui você terá seu clone armazenado em variável mas ainda não incluido no Documento, sem parentNode.
    clone.setAttribute('id', 'elementos' + id.toString());
    clone.children[0].setAttribute('id', 'elem' + id.toString());
    clone.children[1].setAttribute('for', 'elem' + id.toString());
    label = clone.children[1];
    label.innerHTML = input;
    lista.appendChild(clone);
    count=count + 1;
}

function riscar(id){
    console.log(id)
    var label = "label[for=" + id+"]";
    var input = document.getElementById(id);
    if(input.checked == true){
    document.querySelector(label).style.textDecoration = "line-through";
    }
    else{
        document.querySelector(label).style.textDecoration = "none";
    }
}