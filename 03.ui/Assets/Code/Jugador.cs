using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    private const int VELOCIDAD = 18;

    void Start()
    {
        Debug.Log("Hola desde Jugador!");
    }

    public void OnMove(InputValue valor)
    {
        var movimiento = valor.Get<Vector2>();
        Debug.Log(movimiento);

        var posicion = transform.position;
        // posicion.x = posicion.x + movimiento.x;
        posicion.x += movimiento.x * VELOCIDAD;
        posicion.y += movimiento.y * VELOCIDAD;
        transform.position = posicion;
    }
}