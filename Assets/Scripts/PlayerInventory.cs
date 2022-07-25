using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //updates the inventory
    public int NumberOfCoins{get; private set;} 
    public void CoinsCollected(){
        NumberOfCoins ++;
    }
    
}
