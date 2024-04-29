using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    // public CreadorDeMonedas creadorDeMonedas;

    public event Action MonedaDestruida;

    private void OnCollisionEnter2D(Collision2D colision)
    {
        Debug.Log($"OnCollisionEnter2D: {colision.gameObject.name}");

        Destroy(colision.gameObject);

        // creadorDeMonedas.MonedaDestruida();
        MonedaDestruida.Invoke();
    }
}
