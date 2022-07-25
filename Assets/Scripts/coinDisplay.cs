using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI coinD;
    public PlayerInventory playerInventory;
    void Start()
    {
        coinD.SetText("Coins: 0");
    }

//     // Update is called once per frame
    void Update()
    {
        coinD.SetText("Coins: " + playerInventory.NumberOfCoins.ToString());
    }
}
