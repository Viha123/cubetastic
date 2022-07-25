using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource endLevelSnd;
    // Start is called before the first frame update
    void OnTriggerEnter(){
        endLevelSnd.Play();
        gameManager.CompleteLevel();
    }
}
