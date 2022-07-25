using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioSource coinCollectSnd;
    
    private void OnTriggerEnter(Collider other){ //function belongs to coin, other would be player in most cases
        //check if the collision was done by a player
        //to check that we can get the PlayerInventory Component from the object collided and since the player only has this component, we know its player. 
        
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if(playerInventory != null){//we know this is player
            playerInventory.CoinsCollected();
            
            coinCollectSnd.Play();
            gameObject.SetActive(false); //this came object is the coin.

        }

    }
    void Update(){
        transform.Rotate(new Vector3(100f,0f,0f) * Time.deltaTime);
    }
}
