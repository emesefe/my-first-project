using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
