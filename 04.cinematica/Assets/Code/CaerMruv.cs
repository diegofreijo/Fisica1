using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaerMruv : MonoBehaviour
{
    private float alturaInicial;
    public float velocidad;
    public float gravedad;
    private float tiempo;

    private void Start()
    {
        // La posicion inicial va a ser en la que se encuentra este GameObject
        this.alturaInicial = transform.position.y;

        // Arranca el tiempo en 0
        this.tiempo = 0f;
    }

    void FixedUpdate()
    {
        // Sumo el tiempo que paso desde el ultimo FixedUpdate al tiempo total del ejercicio
        this.tiempo += Time.deltaTime;

        // Actualizo la posicion en base a la ecuacion de MRU
        float nuevaPosicion = EcuacionMruv(alturaInicial, tiempo, velocidad, gravedad);

        // Actualizo la posicion de este GameObject en base a la nueva posicion en y que calcule arriba
        transform.position = new Vector3(
            transform.position.x,
            nuevaPosicion,
            transform.position.z
        );
    }

    // Ecuacion que calcula la nueva posicion de un cuerpo segun la cuenta de MRUV
    // Aca hay aceleracion, asi que la velocidad va cambiando en funcion del tiempo
    private float EcuacionMruv(float alturaInicial, float tiempo, float velocidad, float gravedad)
    {
        return 0.5f * gravedad * tiempo * tiempo + velocidad * tiempo + alturaInicial;
    }
}
