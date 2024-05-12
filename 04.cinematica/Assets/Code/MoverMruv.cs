using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMruv : MonoBehaviour
{
    private float posicionIinicial;
    public float velocidad;
    public float aceleracion;
    private float tiempo;

    private void Start()
    {
        // La posicion inicial va a ser en la que se encuentra este GameObject
        this.posicionIinicial = transform.position.x;

        // Arranca el tiempo en 0
        this.tiempo = 0f;
    }

    void FixedUpdate()
    {
        // Sumo el tiempo que paso desde el ultimo FixedUpdate al tiempo total del ejercicio
        this.tiempo += Time.deltaTime;

        // Actualizo la posicion en base a la ecuacion de MRU
        float nuevaPosicion = EcuacionMruv(posicionIinicial, tiempo, velocidad, aceleracion);

        // Actualizo la posicion de este GameObject en base a la nueva posicion en x que calcule arriba
        transform.position = new Vector3(
            nuevaPosicion,
            transform.position.y,
            transform.position.z
        );
    }

    // Ecuacion que calcula la nueva posicion de un cuerpo segun la cuenta de MRUV
    // Aca hay aceleracion, asi que la velocidad va cambiando en funcion del tiempo
    private float EcuacionMruv(float posicionIinicial, float tiempo, float velocidad, float aceleracion)
    {
        return 0.5f * aceleracion * tiempo * tiempo + velocidad * tiempo + posicionIinicial;
    }
}
