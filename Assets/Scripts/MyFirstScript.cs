using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int carDoors = 4;
    public int x = 0;
    public int y = 0;

    List<string> justiceLeague = new List<string>() { "Batman", "Superman", "Flash", "Wonder Woman", "Green Lantern"};

    // Start is called before the first frame update
    void Start()
    {
        sumas();
        Debug.LogFormat("Los miembros de la liga de la justicia son: {0}, {1}, {2}, {3}, {4}",
                        justiceLeague[0], justiceLeague[1], justiceLeague[2], justiceLeague[3], justiceLeague[4]);

        pruebaForeac();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sumas()
    {
        Debug.Log(3 + 5);
        Debug.Log(carDoors);
        Debug.Log(carDoors - 3);
        Debug.Log(x + y);
    }

    void pruebaForeac()
    {
        foreach(string miembro in justiceLeague)
        {
            Debug.Log(miembro);
        }
    }
}
