using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PuntosJugador : MonoBehaviour
{
    public AudioSource point;
    public AudioSource win;
    public Text marcador;
    public Text terminaste;
    private int numeroTotalItems = 20;
    int contador;

    void Awake()
    {
        contador = 0;
        ActualizarMarcador();
        terminaste.gameObject.SetActive(false);
        
    }


    void OnTriggerEnter(Collider other)
    {
        point.Play();

        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizarMarcador();
        if(contador >= numeroTotalItems)
        {
            win.Play();
            terminaste.gameObject.SetActive(true);
        }
    }

    void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }
}
