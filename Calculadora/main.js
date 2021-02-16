var valor
var calculo

function botao(num){
    valor = document.calc.visor.value += num
}

function reset(){
    document.calc.visor = ""
}

function calcula(){
calc = eval(valor)
document.calc.visor.value = calc
}

function voltar(){
    let visor = document.calc.visor.value
    result = visor.substring(0, visor.length-1)
    document.calc.visor.value = result
}