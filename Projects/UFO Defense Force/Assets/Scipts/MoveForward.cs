using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 25.0f;
    
    // Update is called once per frame
    void Update()
    {
        //Move game object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
