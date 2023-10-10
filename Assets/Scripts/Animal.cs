using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int totalLegs = 4;
    [SerializeField] private string name;

    private void Start()
    {
        Debug.Log($"{name} tiene {totalLegs} patas");
    }
}
