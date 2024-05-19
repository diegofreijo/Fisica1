using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    public Rigidbody2D rb;
    public float propulsion;
    public ForceMode2D modo;

    void Start()
    {
        // Aplico una fuerza hacia la derecha segun cuanta propulsion tengo y que modo me dieron
        rb.AddForce(new Vector2(propulsion, 0), modo);
    }
}
