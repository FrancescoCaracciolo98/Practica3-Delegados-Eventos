# Práctica 3 - Delegados, Eventos
* **Asignatura:** Interfaces Inteligentes
* **Autor:** Francesco Caracciolo
* **Correo:** alu0101526621@ull.edu.es


## Cuando el jugador colisiona con un objeto de tipo A, el objeto B mostrará un texto en una UI de Unity. Cuando toca el objeto B se incrementará la fuerza del objeto A.

## Cilindros que cambian de color:
Cuando el jugador se aproxima a los cilindros de tipo A, los cilindros de tipo B cambian su color y las esferas se orientan hacia un objetivo ubicado en la escena con ese propósito.

Arreglamos esto en el script lookAt.

![Screenshot%20(5454)](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/Screenshot%20(5454).png)

Por tanto, el resultado final es:

![GIF](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/GIF.gif)


## Cuando el jugador se aproxima a los cilindros de tipo A, los cilindros de tipo B cambian su color y las esferas se orientan hacia un objetivo ubicado en la escena con ese propósito.
Para hacer esto utilizo los siguientes scripts:
![Screenshot%20(5497)](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/Screenshot%20(5497).png)
![Screenshot%20(5498)](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/Screenshot%20(5498).png)



![ezgif.com-gif-maker%20(18)](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/ezgif.com-gif-maker%20(18).gif)

## Implementar un controlador que mueva el objeto con wasd.

Para implementar este segundo controlador usamos las siguientes líneas de código:

`Input.GetKeyDown(KeyCode.W)` Para la tecla W.

`Input.GetKeyDown(KeyCode.A)` Para la tecla A.

`Input.GetKeyDown(KeyCode.S)` Para la tecla S.

`Input.GetKeyDown(KeyCode.D)` Para la tecla D.





## Buscar información de Debug.DrawRay y utilízala para depuración.

Como esta escrito en https://docs.unity3d.com/ScriptReference/Debug.DrawRay.html añadiendo 

`Debug.DrawRay(transform.position, transform.forward * 5, Color.red, 0.1f, true);`

nos mostraría líneas rojas en este caso de los movimientos, siendo transform.position el punto de partida y transform.forward la dirección.

Por tanto, el resultado final es:

![ezgif.com-gif-maker%20(17)](https://github.com/FrancescoCaracciolo98/Practica3-Delegados-Eventos/blob/main/ezgif.com-gif-maker%20(17).gif)
