using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    private int myNumber = 7;
    private void Start()
    {
        /*
        SayHelloTo("Pepito");
        SayHelloTo("Mariluz");
        SayHelloTo("Mariconchi");

        Debug.Log($"La suma de los 3 números es: {SumThreeIntNumbers(19, 22, 43)}");
        
        Debug.Log(ShowUserInfo("emesefe", 45));
        */
        
        /*
        Calculator(5, 3);
        Calculator(10, 7);
        Calculator(90, 23);
        
        Debug.Log(HelloWorldMessage());
        */
        
        Debug.Log($"¿Es el {myNumber} par?: {IsEven(myNumber)}");
    }
    
    // Sin outputs y sin inputs
    private void HelloWorld()
    {
        // Cuerpo de la función
        Debug.Log("Hello World");
    }

    // Sin outputs y con inputs
    private void SayHelloTo(string name)
    {
        Debug.Log($"Hello, {name}");
    }

    private void Calculator(float num1, float num2)
    {
        Debug.Log($"{num1} + {num2} = {num1 + num2}");
        Debug.Log($"{num1} - {num2} = {num1 - num2}");
        Debug.Log($"{num1} * {num2} = {num1 * num2}");
        Debug.Log($"{num1} / {num2} = {num1 / num2}");
    }
    
    
    // Con outputs y con inputs
    private int SumThreeIntNumbers(int num1, int num2, int num3)
    {
        int result = num1 + num2 + num3;
        return result;
    }

    private string ShowUserInfo(string username, int level)
    {
        string message = $"El usuario {username} tiene nivel {level}";
        return message;
    }
    
    // Con output y sin inputs
    private string HelloWorldMessage()
    {
        return "Hello World!";
    }
    
    
    
    
    // EJEMPLOS
    private bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            // El número number es par
            return true;
        }
        else
        {
            // El número es impar
            return false;
        }
    }
    
    
}
