using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision colission)
    {
        Debug.Log("Contacto");
        Destroy(colission.gameObject);
    }
}
