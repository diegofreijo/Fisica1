using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMru : MonoBehaviour
{
    private float posicionIinicial;
    public float velocidad;   
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
        float nuevaPosicion = EcuacionMru(posicionIinicial, tiempo, velocidad);
        
        // Actualizo la posicion de este GameObject en base a la nueva posicion en x que calcule arriba
        transform.position = new Vector3(
            nuevaPosicion,
            transform.position.y,
            transform.position.z
        );
    }

    // Ecuacion que calcula la nueva posicion de un cuerpo segun la cuenta de MRU
    // Aca no hay aceleracion, por lo que la velocidad es siempre la misma
    // Los 3 parametros que recibe son variables de la clase, asi que no hacia falta pasarlos por parametro.
    // Igualmente me parecio bueno para entender que valores necesita la ecuacion
    private float EcuacionMru(float posicionIinicial, float tiempo, float velocidad)
    {
        return velocidad * tiempo + posicionIinicial;
    }
}
