using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSE : MonoBehaviour
{
    [SerializeField] SEContoroller seContoroller;
    [SerializeField] private GameObject pause;

    void Update()
    {
        if(KeyDef.Up() && !pause.activeSelf){
            Debug.Log("JumpSE");
            seContoroller.PlayJumpSE();
        }
    }
}
