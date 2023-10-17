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
    
    private bool isMonday = false; 
    private bool isTuesday = false; 
    private bool computersWork = true;
    
    private bool isGameOver = true;
    private bool isOnTheFloor = true;
    private int maxJumps = 2;
    private int totalJumps = 0;

    private int age = 18;
    
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
        
        // AND (&&)
        // c1 && c2
        // t && t -> t
        // t && f -> f
        // f && t -> f
        // f && f -> f

        if (isMonday && computersWork)
        {
	        Debug.Log("Tenemos clase de RPMI");
        }
        else
        {
	        Debug.Log("No hay clase");
        }
    
        // OR(||)
        // c1 || c2
        // t || t -> t
        // t || f -> t
        // f || t -> t
        // f || f -> f

        if (isMonday || isTuesday)
        {
	        if (computersWork)
	        {
		        Debug.Log("Hay clase de RPMI");
	        }
        }

        if ((isMonday || isTuesday) && computersWork)
        {
	        Debug.Log("Hay clase de RPMI");
        }
        else
        {
	        Debug.Log("NO hay clase de RPMI");
        }
        
        // NOT !
        // !true = false
        // !false = true

        if (!isGameOver)
        {
            Debug.Log("Estamos vivos");
        }
        else
        {
            Debug.Log("Game over");
        }

        if (!isOnTheFloor)
        {
            if (totalJumps < maxJumps) {
                // Saltamos
                totalJumps++;
            }
        }

        if (age >= 18)
        {

        }

        // ==
        // !=
        // >
        // <
        // >=
        // <=

        // == y !=
        // > y <=
        // < y >=
    }
}
