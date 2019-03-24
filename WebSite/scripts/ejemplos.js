var igv = 18;
var igv2 = "18";

console.log(igv);

console.log(igv2);
console.log(igv == igv2);
console.log(igv === igv2);

var dias = ["Lunes", "Martes", "Miercoles", "Jueves", "Viernes"];
console.log(dias[1]);
console.log(dias[5]);

var verdad = true;
console.log(verdad);

var fecha = new Date();
var fecha2 = new Date('8/29/2019');
console.log(fecha);
console.log(fecha2);

var visible = true;
var cantidad = 0;
var cantidad2 = 3;
var mensaje = "";
var mensaje2 = "ejemplo";

var edad = 15;

console.log(edad == 10 ? 5 : 10);

console.log(!visible);
console.log(!cantidad);
console.log(!cantidad2);
console.log(!mensaje);
console.log(!mensaje2);

if (edad < 12) {
    console.log("eres pequeño");
} else if (edad < 19) {
    console.log("eres adolescente");
} else if (edad < 35) {
    console.log("aun eres joven");
} else {
    console.log("a cuidarse");
}

var count = 0;
while (count<5) {
    console.log(count);
    count++;
}

for (var i in dias) {
    console.log(dias[i]);
}

var miAuto = new Object();
miAuto.modelo = "Toyota";
miAuto.marca = "Yaris";
miAuto["fabricacion"] = 2011;

console.log(miAuto.modelo);

    var miObjeto = new Object();
    miObjeto.MiMetodo = function () {
        console.log("Hola MiMetodo");
}

miObjeto.MiMetodo();

var miObjeto2 = {
    miMetodo2: function (parametro) {
        console.log("Hola mi método2 " + parametro);
    }
}

miObjeto2.miMetodo2("Miparam");

delete miAuto.marca;
console.log(miAuto.marca);


