using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperators : MonoBehaviour
{
    /*
    ====================================================================
    Este script muestra cómo utilizar los operadores aritméticos de C#
    ====================================================================
    */
    
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    private float result;
    
    [SerializeField] private int coins;
    
    [SerializeField] private int hour;

    private void Start()
    {
        // Podemos sumar directamente dos valores numéricos
        Debug.Log(2 + 5);
        
        // Podemos sumar una variable numérica y un valor numérico
        Debug.Log(num1 + 10);

        // Podemos guardar el resultado de una suma en otra variable numérica
        result = num1 + num2;
        Debug.Log(result);
        
        // Podemos modificar una variable con una suma y guardar el resultado en esa misma variable
        Debug.Log($"Monedas: {coins}"); // Mostramos el antes
        // coins = coins + 10; // Esta línea y la siguiente son la equivalentes
        coins += 10;
        Debug.Log($"Monedas: {coins}"); // Mostramos el después

        // Mostramos las 4 operaciones aritméticas básicas
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
        
        // Operación de módulo
        // Si calculamos módulo 5, los posibles resultados son: 0, 1, 2, 3 ,4
        Debug.Log(hour % 5);
        
    }
}
