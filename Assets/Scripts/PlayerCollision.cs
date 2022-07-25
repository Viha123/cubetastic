using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource collisionSnd;
    void OnCollisionEnter(Collision collisionInfo){ //when object collides with something
        if(collisionInfo.collider.tag == "Obstacle"){
            collisionSnd.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }//what if I did this for jump? in case rb.position.y doesnt work, we can try this
}
