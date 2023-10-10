using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    Comentario línea 1
    Comentario línea 2
    Comentario línea 3
    */
    
    // Variable que representa la edad de un jugador
    [SerializeField] private int age = 18; // = 0;
    // Variable que representa la velocidad del jugador
    [SerializeField] private float speed; // = 0.0f;
    // Variable que representa si el jugador está muerto o vivo
    [SerializeField] private bool isGameOver; // = false
    // Variable que representa el nombre del jugador
    [SerializeField] private string username; // = "";

    [SerializeField] private float num1;
    [SerializeField] private float num2;

    [SerializeField] private int coins;

    private float result;

    [SerializeField] private int hour;



    private void Start()
    {
        /*
        Debug.Log("Hola, mundo!");
        Debug.Log(username);
        Debug.Log(isGameOver);
        Debug.Log(speed);
        Debug.Log(age);
        
        // Forma 1
        Debug.Log($"El nombre de usuario es: {username}");
        
        // Forma 2
        Debug.Log(string.Format("La velocidad del usuario es {0} m/s", speed));
        Debug.Log(string.Format("El usuario {0} va a {1} m/s",username,speed));
        
        // Forma 3
        Debug.Log("El usuario tiene " + age + " años.");
        */
        
        /*
        Debug.Log(2 + 5);
        Debug.Log(num1 + 10);

        result = num1 + num2;
        Debug.Log(result);
        
        Debug.Log($"Monedas: {coins}");
        // coins = coins + 10;
        coins += 10;
        Debug.Log($"Monedas: {coins}");
        */
        
        /*
        Debug.Log($"{num1} + {num2} = {num1 + num2}");
        Debug.Log($"{num1} - {num2} = {num1 - num2}");
        Debug.Log($"{num1} * {num2} = {num1 * num2}");
        Debug.Log($"{num1} / {num2} = {num1 / num2}");
        
        // +=
        coins = coins + 5;
        coins += 5;

        coins += 1;
        coins++;
        
        // -=
        coins = coins - 5;
        coins -= 5;
        
        coins -= 1;
        coins--;
        
        // *=
        coins = coins * 5;
        coins *= 5;
        
        // /=
        coins = coins / 5;
        coins /= 5;
        */
        
        /*
        // 0, 1, 2, 3 ,4
        Debug.Log(hour % 5);
        */
        
        // OPERADORES CONDICIONALES
        // Igualdad ==
        // true si los objetos son iguales
        // false si los objetos son diferentes
        // Debug.Log(num1 == num2); 

        // Desigualdad !=
        // true si los objetos son diferentes
        // false si los objetos son iguales
        // Debug.Log(num1 != num2);
        
        // Menor <
        // true si el número de la izq es más pequeño que el de la der
        // false si el número de la izq es mayor o igual al de la der
        Debug.Log(num1 < num2);
        
        // Mayor >
        // true si el número de la izq es más grande que el de la der
        // false si el número de la izq es menor o igual al de la der
        Debug.Log(num1 > num2);
        
        // Menor o igual <=
        // true si el número de la izq es menor o igual al de la der
        // false si el número de la izq es mayor al de la der
        Debug.Log(num1 <= num2);
        
        // Mayor o igual >=
        // true si el número de la izq es mayor o igual al de la der
        // false si el número de la izq es menor al de la der
        Debug.Log(num1 >= num2);
    }
}
