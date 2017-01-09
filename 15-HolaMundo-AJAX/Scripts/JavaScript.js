// AJAX TYPE
//++++++++++++++++++++++++++++++++++


document.getElementById("btnPedirHolaMundo").addEventListener("click", llamada);
document.getElementById("pedirDesp").addEventListener("click", desplegable);

// Si queremos imprimir el xml podriamos usar llamadaET pero para tratar con los datos usaremos el otro.
document.getElementById("btnPedirXML").addEventListener("click", llamadaGETxml);


//Funcion que se encargara de hacer un hola mundo
function llamada() {
    //Codigo de debugger para saber que esta dentro
    //alert("its into");

    //Instancia de objeto
    var oXML = new XMLHttpRequest();

    // Definir el Objeto Open, por defecto es async.
    oXML.open("GET", "../Server/HolaMundo.html");

    //Definir cabeceras, GET no necesario.

    // Definir que hacemos cuando va cambiando el estado

    oXML.onreadystatechange = function () {

        //Codigo de debugger, pasa del 1 al 4, en 4 significa ya que nos ha respondido el servidor
        //alert("readyState: " + oXML.readyState + " & State: " + oXML.status);

        //Cuando recibimos una respuesta mayor mayor a 3 significa que nos ha respondido el servidor, con 200 significa que ha sido
        // recogido con exito

        if (oXML.readyState < 4) {
            document.getElementById("txtContenedor").innerHTML = "Cargando...";
        } else if (oXML.readyState == 4 && oXML.status == 200) {
            //Cuando todo esta OK trabajaremos con los datos

            document.getElementById("txtContenedor").innerHTML = oXML.responseText; // En caso de ser xml seria responsexml
        }
    }

    // Enviar la solicitud
    oXML.send();
}

function desplegable() {
    var oXML = new XMLHttpRequest();

    oXML.open("GET", "../Server/Desplegable.html");

    oXML.onreadystatechange = function () {

        if (oXML.readyState < 4) {
            document.getElementById("txtContenedor").innerHTML = "Cargando...";
        } else if (oXML.readyState == 4 && oXML.status == 200) {

            document.getElementById("txtContenedor").innerHTML = oXML.responseText;
        }
    }
    oXML.send();
}

function llamadaGETxml() {
    var oXML = new XMLHttpRequest();

    oXML.open("GET", "../Server/Persona.xml");

    oXML.onreadystatechange = function () {

        if (oXML.readyState < 4) {
            document.getElementById("txtContenedor").innerHTML = "Cargando...";

        } else if (oXML.readyState == 4 && oXML.status == 200) {
            document.getElementById("txtContenedor").innerHTML = "";
            var respXML = oXML.responseXML;
            escribirPersonas(respXML);
        }
    }
    oXML.send();
}

function escribirPersonas(respXML) {
    var table = document.createElement("table");
    table.id = "tablePersonas";
    table.border = 1;
    document.getElementById("txtContenedor").appendChild(table);
    var arrayPersonas = respXML.getElementsByTagName("persona");

    for (var i = 0; i < arrayPersonas.length; i++) {
        //Columna
        var tr = document.createElement("tr");

        //Fila de nombres
        var td = document.createElement("td");
        var text = document.createTextNode(arrayPersonas[i].getElementsByTagName("nombre")[0].firstChild.nodeValue);
        td.appendChild(text);
        tr.appendChild(td);

        //Fila de apellidos
        var td = document.createElement("td");
        var text = document.createTextNode(arrayPersonas[i].getElementsByTagName("apellido")[0].firstChild.nodeValue);
        td.appendChild(text);
        tr.appendChild(td);

        //Inserccion de esta en la tabla
        table.appendChild(tr);
    }
    
    //document.getElementById("txtContenedor").innerHTML = respXML.getElementsByTagName("nombre")[0].childNodes[0].nodeValue;
}
