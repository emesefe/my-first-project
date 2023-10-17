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
        
        // OPERADORES DE DECISIÓN 
    }
}
