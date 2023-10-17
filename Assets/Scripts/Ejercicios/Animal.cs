using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int totalLegs = 4;
    [SerializeField] private string name;
    private bool hasMoreThanTwoLegs;

    private void Start()
    {
        hasMoreThanTwoLegs = totalLegs > 2;

        if (hasMoreThanTwoLegs == true)
        {
            Debug.Log($"{name} tiene {totalLegs} patas: {hasMoreThanTwoLegs}");
        }
        
        
    }
}
