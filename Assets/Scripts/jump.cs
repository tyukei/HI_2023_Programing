using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public CameraManager human_eye;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnTriggerStay(Collider other){
        //if (other.gameObject.name == "Plane")
        //    isGround = true;
        Debug.Log(other.gameObject.name);
    }
    void OnTriggerExit(Collider other){
        //if (other.gameObject.name == "Plane")
        //   isGround = false;
        Debug.Log(other.gameObject.name);
    }

    */
    void OnCollisionEnter(Collision other){
        human_eye.isGround = true;
        //Debug.Log(other.gameObject.tag); // untaged
    }
}
