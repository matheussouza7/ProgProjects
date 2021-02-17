async function dol(){
    
    let req = await fetch(new Request('https://api.exchangeratesapi.io/latest?base=USD'))
    let valor = await req.json()
    let br = document.querySelector('.lista')
    console.log(br);
    /*let eur = document.querySelector('.eur')
    let isk = document.querySelector('.isk')
    let gbp = document.querySelector('.gbp')*/
    
    /*br.innerHTML =`Dolar em BR $${valor.rates.BRL.toFixed(2)}`
    eur.innerHTML =`Dolar em EUR $${valor.rates.EUR.toFixed(2)}`
    isk.innerHTML =`Dolar em ISK $${valor.rates.ISK.toFixed(2)}`
    gbp.innerHTML =`Dolar em GBP $${valor.rates.GBP.toFixed(2)}`*/
    /*br.innerHTML = "";*/
    var keys = Object.keys(valor.rates);
    console.log(keys);
    for(let key of keys) {
        console.log(key);
        br.innerHTML += `<li>Dolar em ${key}: $${valor.rates[key].toFixed(2)}</li>`
    }
}
dol();

