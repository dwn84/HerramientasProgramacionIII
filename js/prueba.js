alert("Hola mundo");

class rectangulo {

    constructor(a, b) {
        this.altura = a;
        this.anchura = b;
    }
    set Altura(a) {
        this.altura = a;
    }
    get Altura() {
        return this.altura;
    }
    area() {
        return this.altura * this.anchura;
    }
}

var r1 = new rectangulo(3, 8);
r1.Altura = 55;
console.log(r1.Altura);
console.log(r1.area());

var x = 0;

function incrementar() {
    x++;
    alert("nuevo valor de x: " + x);
    if(x%2==0){
        document.getElementById("p1").style.color = "blue";
        document.getElementById("p1").style.fontFamily = "Arial";
        document.getElementById("p1").style.fontSize = "larger";
        document.getElementById("p1").style.border = "1px solid";
    }else{
        document.getElementById("p1").style.color = "red";
        document.getElementById("p1").style.fontFamily = "Times new roman";
        document.getElementById("p1").style.fontSize = "20px";
        document.getElementById("p1").style.border = "3px dashed yellow";
    }
 


}

function cambiarTexto() {
    document.getElementById("demo").innerHTML = "Hola mundo #" + x;
}

function cambiarTipo() {
    document.getElementById("txtEdad").setAttribute("type", "radio");
}

function cambiarTipoAll() {
    for (var i in document.getElementsByTagName("input")) {
        document.getElementsByTagName("input")[i].setAttribute("type", "password");

    }

}

function borrarElemento(){
    if(document.getElementById("p1")){
        document.getElementById("p1").remove();
    }else{
        console.log("Ya no existe el párrafo...");
    }
    
}

function borrarAtributo(){
    document.getElementById("vinculo").removeAttribute("href");

}

function agregarBoton(){
    var b = document.createElement("button");
    b.innerHTML="Nuevo B";
    document.body.appendChild(b);

}

function agregarTexto(){
    var parrafo = document.createElement("p");
    var texto = document.createTextNode("Lorem X");
    parrafo.appendChild(texto);

    var endonde = document.getElementById("container");
    var referente = document.getElementById("p1");
    endonde.insertBefore(parrafo,referente);
}