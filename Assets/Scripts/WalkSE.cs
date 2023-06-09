using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSE : MonoBehaviour
{
    [SerializeField] SEContoroller seContoroller;
    [SerializeField] private GameObject pause;
    // Update is called once per frame
    void Update()
    {
        if(KeyDef.ALLStick() && !pause.activeSelf){
            Debug.Log("WalkSE");
            seContoroller.PlayWalkSE();
        }
    }
}
