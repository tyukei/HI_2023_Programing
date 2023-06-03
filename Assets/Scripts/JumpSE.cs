using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSE : MonoBehaviour
{
    [SerializeField] SEContoroller seContoroller;

    void Update()
    {
        if(KeyDef.Up()){
            Debug.Log("JumpSE");
            seContoroller.PlayJumpSE();
        }
    }
}
