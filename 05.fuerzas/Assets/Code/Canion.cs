using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public GameObject prefabMisil;
    public float potencia;
    public float angulo;
    public ForceMode2D modo;

    void Start()
    {
        // Creo un nuevo misil (un GameObject) basandome en el prefab que me pasaron
        GameObject goMisil = Instantiate(prefabMisil);

        // Muevo el nuevo misil a la misma posicion donde esta este canion
        goMisil.transform.position = transform.position;

        // Obtengo el rigidbody del misil (si no hay un rigidbody, tira excepcion)
        var rbMisil = goMisil.GetComponent<Rigidbody2D>();

        // Lo lanzo
        AddForceAtAngle(potencia, angulo, rbMisil, modo);
    }

    /// <summary>
    /// Funcion que aplica cierta fuerza en cierto angulo a un rigidbody2d.
    /// Si no entendes bien como calcula la direccion, no te preocupes. No entra en esta materia.
    /// </summary>
    private void AddForceAtAngle(float potencia, float angulo, Rigidbody2D rb, ForceMode2D modo)
    {
        Vector3 direccion = Quaternion.AngleAxis(angulo, Vector3.forward) * Vector3.right;
        rb.AddForce(direccion * potencia, modo);
    }
}
