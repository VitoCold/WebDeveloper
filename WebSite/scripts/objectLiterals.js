var miModulo = {
    miPropiedad: "valor0",
    miConfiguracion: {
        usarEspanol:true,
        usaMascara:false
    },
    miMetodo1: function () {
        console.log("metodo1");
    },
    miMetodo2: function () {
        console.log("La mascara esta " + (this.miConfiguracion.usaMascara) ? 'habilitada' : 'deshabilitada');
    },
    miMetodo3: function (configuracion) {
        if (typeof configuracion =='object') {
            this.miConfiguracion = configuracion;
            console.log(this.miConfiguracion.usarEspanol);
        }
    }
};

console.log(miModulo.miPropiedad);
miModulo.miMetodo1();