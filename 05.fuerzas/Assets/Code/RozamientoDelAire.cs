using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RozamientoDelAire : MonoBehaviour
{
    public float rozamiento = 0f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.drag = rozamiento * rb.mass;
    }
}
