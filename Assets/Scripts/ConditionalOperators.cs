using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalOperators : MonoBehaviour
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private float num;
    [SerializeField] private int lives;
    
    private bool monday = false;
    private bool tuesday = false;
    private bool wednesday = false;
    private bool thursday = true;
    private bool friday = false;
    private bool saturday = false;
    
    [SerializeField] private int grade = 7;
    
    private void Start()
    {
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

        // OPERADORES DE DECISIÓN
        // OPERADOR DE DECISIÓN IF
        if (num > 0)
        {
            Debug.Log($"{num} es positivo");
        }

        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }
        
        // OPERADOR DE DECISIÓN IF-ELSE
        if (num > 0)
        {
            Debug.Log($"{num} es positivo");
        }
        else
        {
            Debug.Log($"{num} es negativo o 0");
        }
        
        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }
        else
        {
            Debug.Log("Todavía estoy vivo");   
        }
        
        // OPERADOR DE DECISIÓN IF-ELSE-IF
        // * Ejemplo con días de la semana
        if (monday)
        {
            Debug.Log("Es lunes");
        }
        else if (tuesday)
        {
            Debug.Log("Es martes");
        }
        else if (wednesday)
        {
            Debug.Log("Es miércoles");
        }
        else if (thursday)
        {
            Debug.Log("Es jueves");
        }
        else if (friday)
        {
            Debug.Log("Es viernes");
        } 
        else if (saturday)
        {
            Debug.Log("Es sábado");
        }
        else
        {
            Debug.Log("Es domingo");
        }
        
        // * Ejemplo con vidas restantes del jugador
        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }
        else if (lives <= 1)
        {
            Debug.Log("Solo te queda una vida");
        }
        else if (lives <= 5)
        {
            Debug.Log("Ve con precaución que te quedan pocas vidas");
        }
        
        // OPERADORES DE DECISIÓN ANIDADOS
        // Suspenso, Aprobado (>= 5), Notable bajo (=7), alto (=8) (>=7), Excelente (>= 9)
        if (grade >= 9)
        {
            Debug.Log("Excelente");
            if (grade == 9)
            {
                Debug.Log("Excelente");
            }
            if (grade == 10)
            {
                Debug.Log("Matrícula de honor");
            }
        }
        else if (grade >= 7)
        {
            Debug.Log("Notable");
            if (grade == 8)
            {
                Debug.Log("Notable alto");
            }
            else
            {
                Debug.Log("Notable bajo");
            }
        }
        else if (grade >= 5)
        {
            Debug.Log("Aprobado");
            if (grade == 6)
            {
                Debug.Log("Aprobado alto");
            }
            if (grade == 5)
            {
                Debug.Log("Aprobado bajo");
            }
        }
        else
        {
            Debug.Log("Suspenso");
        }
        
        // AND
    }
}
