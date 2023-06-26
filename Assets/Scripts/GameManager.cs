using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string labelText = "Recolecta todos los items";
    public int maxItems = 2;
    public bool showWinScreen = false;

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            if(_itemsCollected >= maxItems)
            {
                labelText = "Has encontrado todos los items";
                showWinScreen = true;
                // Congela todo el juego, es poner en pausa el juego.
                Time.timeScale = 0.0f;
            }
            else
            {
                labelText = "item encontrado, te faltan: " + (maxItems - _itemsCollected);
            }
        }

    }

    private int _playerHp = 3;
    public int HP
    {
        get { return _playerHp; }
        set { _playerHp = value; }
    }

    private void OnGUI()
    {
        // Crea un area donde se mostrara un mensaje en la pantalla
        // Los parametros son (posX, posY, tamancho, tamalto) y mensaje a mostrar
        GUI.Box(new Rect(25, 25, 180, 25), "Vida: " + _playerHp);
        GUI.Box(new Rect(25, 65, 180, 25), "Items: " + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2.0f - 100, Screen.height - 50, 200, 50), labelText);

        if(showWinScreen)
        {
            // Si se pulsa el boton
            if (GUI.Button(new Rect(Screen.width / 2.0f - 200, Screen.height / 2.0f - 100, 400, 200), "¡¡HAS GANADO!!"))
            {
                // Carga nuevamente la escena
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }
    }

}
