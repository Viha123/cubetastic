using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//use when new scene or other stuff
//GameManager handles endGame, pause game, and other stuff.
//when player collides with game , EndGame function will be called
public class GameManager : MonoBehaviour 
{
    bool gameHasEnded = false;
    public float timeDelay = 1f;
    public GameObject levelComplete;
    // Start is called before the first frame update
    public void EndGame(){
        if(!gameHasEnded){
            gameHasEnded = true;
            Invoke("Restart", timeDelay);
        }
    }
    void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel(){
        levelComplete.SetActive(true);
    }
}
