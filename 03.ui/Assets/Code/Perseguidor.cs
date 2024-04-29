using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguidor : MonoBehaviour
{
    public GameObject acosado;

    void Update()
    {
        if (acosado != null)
        {
            var posicionAcosado = acosado.transform.position;
            transform.position = new Vector3(posicionAcosado.x, posicionAcosado.y, -10);
        }
    }
}
