using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    Comentario línea 1
    Comentario línea 2
    Comentario línea 3
    */
    
    // Variable que representa la edad de un jugador
    [SerializeField] private int age = 18; // = 0;
    // Variable que representa la velocidad del jugador
    [SerializeField] private float speed; // = 0.0f;
    // Variable que representa si el jugador está muerto o vivo
    [SerializeField] private bool isGameOver; // = false
    // Variable que representa el nombre del jugador
    [SerializeField] private string username; // = "";

}
