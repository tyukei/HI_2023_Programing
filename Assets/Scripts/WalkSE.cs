using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSE : MonoBehaviour
{
    [SerializeField] SEContoroller seContoroller;
    // Update is called once per frame
    void Update()
    {
        if(KeyDef.ALLStick()){
            Debug.Log("WalkSE");
            seContoroller.PlayWalkSE();
        }
    }
}
