using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour
{
    public string myName;
    
    //Use this for initialization
    void start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}
