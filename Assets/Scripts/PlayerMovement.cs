using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public bool isJump = false;
    public float jumpForce = 300f;
    // public bool isGrounded = true;
    // Start is called before the first frame update
    public AudioSource jumpSnd;
    public AudioSource turnSnd;

    // Update is called once per frame
    void FixedUpdate() //do this instead of just Update when using Physics stuff
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
            turnSnd.Play();
        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-sideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
            turnSnd.Play();
        }
        if(rb.position.y < -1){
            FindObjectOfType<GameManager>().EndGame();
        }
        if(isJump == false && (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))){
            rb.AddForce(0,jumpForce*Time.deltaTime,0,ForceMode.VelocityChange);
            jumpSnd.Play();
            isJump = true;
            
        }

        
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.collider.tag == "Ground")
        {
            isJump = false;
        }
    }
 
 //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.collider.tag == "Ground")
        {
            isJump = true;
        }
    }


}
