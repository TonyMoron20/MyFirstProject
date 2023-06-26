using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            if(value > 0)
            {
                _itemsCollected = value;
                Debug.LogFormat("Items recolectados {0}", _itemsCollected);
            }
        }

    }

    private int _playerHp = 3;
    public int HP
    {
        get { return _playerHp; }
        set { _playerHp = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
