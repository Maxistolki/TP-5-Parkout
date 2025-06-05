using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public moneyManager MoneyManager;
     void Start()
    {
        MoneyManager = FindObjectOfType<moneyManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // actualizar el dinero p/c compra
            MoneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}
