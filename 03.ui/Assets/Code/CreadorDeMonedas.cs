using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreadorDeMonedas : MonoBehaviour
{
    public GameObject prefabMoneda;
    public Button botonCrearNueva;
    public TMPro.TMP_Text textoMonedasDestruidas;
    public Piso piso;

    private int monedasDestruidas = 0;

    private void Start()
    {
        piso.MonedaDestruida += SeDestruyoUnaMoneda;
    }

    public void CrearMoneda()
    {
        botonCrearNueva.interactable = false;
        Instantiate(prefabMoneda);
    }

    private void SeDestruyoUnaMoneda()
    {
        botonCrearNueva.interactable = true;

        // monedasDestruidas = monedasDestruidas + 1;
        // monedasDestruidas += 1;
        monedasDestruidas++;
        textoMonedasDestruidas.text = monedasDestruidas.ToString();
    }
}
