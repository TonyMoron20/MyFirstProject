using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // Se crea una variable publica que guardara al Game Manager.
    public GameManager gameManager;

    private void Start()
    {
        // Se inicializa la variable con el Game Manager que existe en la jerarquia.
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            // Se destruira el padre del collider
            Destroy(this.transform.parent.gameObject );
            // A traves del "gameManager" se accede a la variable que es publica y que permite añadir valores a las variables privadas del Game Manager.
            Debug.Log("Item recolectado");
            gameManager.Items++;
        }
    }
}
