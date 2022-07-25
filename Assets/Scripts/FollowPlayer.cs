using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset; //Vector3 is basically an array that holds 3 floating point values

    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //transform with lower case is the position of the game object

    }
}
