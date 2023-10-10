using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    [SerializeField] private int num;
    [SerializeField] private int age;

    [SerializeField] private float price = 20.5f;
    [SerializeField] private float myMoney = 100f;

    [SerializeField] private bool isOn = true;

    private void Start()
    {
        // CASO PAR
        if (num % 2 == 0)
        {
            Debug.Log($"{num} es par");
        }
        else 
        {
            Debug.Log($"{num} es impar");
        }

        /*
        // CASO IMPAR
        if (num % 2 == 1)
        {
            Debug.Log($"{num} es impar");
        }
        
        // CASO IMPAR
        if (num % 2 != 0)
        {
            Debug.Log($"{num} es impar");
        }
        */




        if (num > 0)
        {
            Debug.Log($"{num} es positivpo");
        }
        else
        {
            Debug.Log($"{num} es negativo o 0");
        }
        
        // ¿Es mayor de edad? 
        if (age >= 18)
        {
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("Es menor de edad");
        }
        
        // Dado un precio y el dinero que tenemos, ¿tengo dinero?
        //    suficiente para comprar el artículo?
        if (myMoney >= price)
        {
            Debug.Log("Me lo llevo");
        }
        else
        {
            Debug.Log("Otra vez será");
        }
        
        // Dada una variable booleana (con [SerializeField])   
        //    llamada isOn, mostrar mensaje "Está encendido"
        //    si la variable vale true y "Está aapagado"
        //    en caso contrario
        if (isOn) // isOn == true
        {
            Debug.Log("Está encendido");
        }
        else
        {
            Debug.Log("Está apagado");
        }
        
        
    }
}
