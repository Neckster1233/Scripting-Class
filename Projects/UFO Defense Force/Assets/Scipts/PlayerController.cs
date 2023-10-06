using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;
    public Transform blaster;
    public GameObject laser;
    

    // Update is called once per frame
    void Update()
    {
        // Added horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Left Side Wall
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3( -xRange, transform.position.y, transform.position.z);
        }    
        // Right Side Wall
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
        }
        // Create Laser at the Blaster point
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate( laser, blaster.transform.position, laser.transform.rotation);
        }    
    }
    //Delete any object that hits the player
    /* Doesn't work for some reason
     testing out multiline comments
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    */
}
