using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverMruvTiempoVariable : MonoBehaviour
{
    private float posicionIinicial;
    public float velocidad;
    public float aceleracion;
    public Slider sliderTiempo;

    private void Start()
    {
        // La posicion inicial va a ser en la que se encuentra este GameObject
        this.posicionIinicial = transform.position.x;
    }

    void FixedUpdate()
    {
        // Veo el valor que esta puesto en el slider y calculo todo en base a eso
        var tiempo = sliderTiempo.value;

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
