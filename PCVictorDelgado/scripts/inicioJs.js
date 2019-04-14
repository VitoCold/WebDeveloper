window.addEventListener('load', iniciandoPagina, false);


function iniciandoPagina() {

    var x = document.getElementsByTagName("BODY")[0];
    var divElement = document.createElement("div");
    divElement.className = "topnav";

    //Inicio

    var inicioAnchor = document.createElement("a");
    inicioAnchor.className = "inicioPage";
    var textoInicio = document.createTextNode('Inicio');
    inicioAnchor.appendChild(textoInicio);
    inicioAnchor.setAttribute('href', 'index.html');

    //Acerca de nosotros

    var acercaAnchor = document.createElement("a");
    acercaAnchor.className = "acercaPage";
    var textoAcerca = document.createTextNode('Acerca de nosotros');
    acercaAnchor.appendChild(textoAcerca);
    acercaAnchor.setAttribute('href', 'views/acerca.html');

    //Contacto

    var contactoAnchor = document.createElement("a");
    contactoAnchor.className = "contactPage";
    var textoAcerca = document.createTextNode('Contáctanos');
    contactoAnchor.appendChild(textoAcerca);
    contactoAnchor.setAttribute('href', 'views/contact.html');

    //Servicios

    var serviciosAnchor = document.createElement("a");
    serviciosAnchor.className = "ServiciosPage";
    var textoAcerca = document.createTextNode('Servicios');
    serviciosAnchor.appendChild(textoAcerca);
    serviciosAnchor.setAttribute('href', 'views/services.html');

    //llenando div

    divElement.appendChild(inicioAnchor);
    divElement.appendChild(acercaAnchor);
    divElement.appendChild(contactoAnchor);
    divElement.appendChild(serviciosAnchor);

    //Header
    var cabeza = document.createElement('header');

    cabeza.appendChild(divElement);

    x.appendChild(cabeza);
}

var HTMLGenerator = {

    a: function (texto) {
        var aEle = document.createElement("a");
        aEle.createTextNode(texto);
    },

    b: function (texto) {
        var aEle = document.createElement("b");
        aEle.createTextNode(texto);
    },

    p: function (texto) {
        var pEle = document.createElement("p");
        pEle.createTextNode(texto);
    },
    
    div: function (bloque, estilo) {
        var x = document.getElementsByTagName("BODY")[0];
        var div1 = document.createElement("div");
        div1.appendChild(bloque);
        div1.setAttribute = (estilo);
    },

};