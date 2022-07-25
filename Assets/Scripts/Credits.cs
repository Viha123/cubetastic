using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    //button must be public
    public AudioSource gameFinishSnd;
    void Start(){
        gameFinishSnd.Play();
    }
    public void Quit(){
        
        Application.Quit();
    }
}
