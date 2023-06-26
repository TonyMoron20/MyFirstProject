using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    //variable que funciona para ver cada cuanto se destruira el gameObject.
    public float destroyDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Destruye el gameObject indicado despues del tiempo que se indique.
        Destroy(this.gameObject, destroyDelay);
    }
}
