using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public Rigidbody2D rb;
    public float propulsion;

    void FixedUpdate()
    {
        // Aplico una fuerza hacia la derecha segun cuanta propulsion tengo
        rb.AddForce(new Vector2(propulsion, 0));

        // Otra forma en la que se suele escribir la linea de arriba
        // rb.AddForce(Vector2.right * propulsion);
    }


}
