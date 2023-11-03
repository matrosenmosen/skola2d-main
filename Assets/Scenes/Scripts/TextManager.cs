using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class TextManager : MonoBehaviour
{

    public TMP_Text scoreText;
    public GameObject door;

    private int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = coins.ToString();

    }

    public void AddCoins()
    {
        coins++;

        if (coins >= 6)
        {
            door.SetActive(false);
        }
    }

}
