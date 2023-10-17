using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    /*
    ====================================================================
    Este script muestra cómo realizar mensajes por consola en Unity
    ====================================================================
    */
    
    [SerializeField] private int age = 18;
    [SerializeField] private float speed;
    [SerializeField] private bool isGameOver;
    [SerializeField] private string username;
    
    private void Start()
    {
        Debug.Log("Hola, mundo!");
        Debug.Log(username);
        Debug.Log(isGameOver);
        Debug.Log(speed);
        Debug.Log(age);
        
        // Forma 1
        Debug.Log($"El nombre de usuario es: {username}");
        
        // Forma 2
        Debug.Log(string.Format("La velocidad del usuario es {0} m/s", speed));
        Debug.Log(string.Format("El usuario {0} va a {1} m/s", username, speed));
        
        // Forma 3
        Debug.Log("El usuario tiene " + age + " años.");
    }
}
