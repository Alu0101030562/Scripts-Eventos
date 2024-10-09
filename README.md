# Scripts Eventos

## 1. Implementar una UI que permita configurar con qué velocidad te moverás: turbo o normal. También debe mostar la cantidad de objetos recolectados y si chocas con alguno especial restar fuerza.

Lo primero que tenemos que hacer será crear un objeto de tipo **Canvas** y en el inspector debemos cambia el *UI Scale Mode* a "Scale With Screen Size" para que la UI se adapte a distintas pantallas y ponemos la resolucion de referencia (*Reference Resolution*) a 1920x1080.

Una vez hecho esto, crearemos un objeto (cápsula) y del paquete **Starter Assets**, añadiremos algunos componentes para darle movimiento al objeto. Estos componentes son **Character Controller**, **Player Input**, **Third Person Controller** y **Starter Asstets Inputs**.

![ObjetoMovimiento](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/1.%20objectos.PNG)

Ahora debemos añadir dos botones que serán los encargados de establecer la velocidad del personaje.

![Botones](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/2.%20Botones.PNG)

Lo siguiente será crear la lógica mediante un script, teniendo dos variables para la velocidad (Normal y Turbo) y dos métodos que estableceran la velocidad del personaje

[Script de selección de velocidad](https://github.com/Alu0101030562/Scripts-Eventos/blob/main/Assets/Scripts/SpeedSelector.cs)

Una vez realizado el script, tendremos que establecer los métodos de velocidad correspondiente a cada botón desde el inspector.

![Foto Botones COnfigurados](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/2.1%20botones%20configurados.PNG)

Resultado Ejercicio 1:

![Ejercicio1](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/ejercicio1.gif)

## 2. Agrega un personaje que al clickar sobre un botón de la UI se dirija hacia un objetivo estático en la escena.

Ahora haremos una escena con un objeto que se va a mover (*cubo*) hacia un objetivo (*torre*) pulsando sobre un botón en la pantalla.

![escena](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/3.%20objetos.PNG)

Tras eso debemos crear un script que hará que el personaje (*cubo*) se mueva hacia el objetivo indicado cuando se pulse el botón.

[Script movimiento personaje](https://github.com/Alu0101030562/Scripts-Eventos/blob/main/Assets/Scripts/FollowObjective.cs)

![Script en personaje](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/4.%20script%20personaje.PNG)

También debemos asignar el método `GoTarget()` al botón para que cuando este sea pulsado se dirija al objetivo.

![Script en botón](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/5.%20Script%20Boton.PNG)

Resultado Ejercicio 2:

![Ejercicio2](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/ejercicio2.gif)

## 3. Agregar a tu escena un objeto que al ser recolectado por el jugador haga que otros dos objetos en la escena realicen las siguientes acciones: el objeto A se desplaza hacia el jugador. El objeto B se ubica en un punto fijo en la escena.
 
Como dice en el apartado, debemos tener en nuestra escena un objeto que será recolectado (*Esfera amarilla*), un objeto que hará de personaje (*Cubo rojo*) y dos objetos, el Objeto A (*Cubo Azul*) una vez recolectado el objeto irá tras el personaje mientras que el objeto B (*Cubo verde*) se desplazará hasta un punto definido en la escena

![Escena3](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/6.%20Objetos.PNG)

![Esfera](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/7.%20Objetivo.PNG)

Ahora implementaremos el primero de los scripts, el cual se encargará de la lógica del personaje y hace que cuando recolectemos el objeto, activará la lógica de los objetivos A y B.

[Script del personaje](https://github.com/Alu0101030562/Scripts-Eventos/blob/main/Assets/Scripts/CollectItem.cs)

![Script del personaje](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/8.%20Script%20Personaje2.PNG)

Una vez implementado el script de los objetivos, debemos seleccionar desde el inspector, el objetivo al cual ir (Perseguir al jugador o ir al punto definido en la escena)

[Script objetivos](https://github.com/Alu0101030562/Scripts-Eventos/blob/main/Assets/Scripts/ObjectTarget.cs)

![Script Objetivos](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/9.%20Script%20objetivos.PNG)

Resultado Ejercicio 3:

![Ejercicio3](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/Scrpts-eventos/ejercicio3.gif)
