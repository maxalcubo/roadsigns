using UnityEngine;
using System.Collections;

public class ComportamientoDeGiro : MonoBehaviour
{

    Vector3 velocidadRotacion = new Vector3(15, 30, 45);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( velocidadRotacion * Time.deltaTime);
    }
}
