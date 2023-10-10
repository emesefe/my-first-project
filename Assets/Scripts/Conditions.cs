using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    [SerializeField] private int num;

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
        // Dado un precio y el dinero que tenemos, ¿tengo dinero?
        //    suficiente para comprar el artículo?
        // Dada una variable booleana (con [SerializeField])   
        //    llamada isOn, mostrar mensaje "Está encendido"
        //    si la variable vale true y "Está aapagado"
        //    en caso contrario
    }
}
