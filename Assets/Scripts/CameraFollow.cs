using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Se crea un vector 3d para establecer la posición de la camara.
    public Vector3 cameraOffset = new Vector3(0.0f, 1.3f, -3.0f);

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        /* Se accede a la propiedad "postion" de la camara y se le da el valor que tenga el "target" (que es el objeto al que se desea seguir) pero trasladada tanto
           como se indique en el vector 3d. */
        this.transform.position = target.TransformPoint(cameraOffset);

        // Con esta función se logra que la camara siempre mire hacia donde esta viendo el objeto.
        this.transform.LookAt(target);
    }
}
