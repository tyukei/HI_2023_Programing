using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDef
{
    public static bool Up(){
        return Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1);
    }
    public static bool Down(){
        return Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0);
    }



    public static bool StickUp(){
        return Input.GetAxis("Horizontal1") > 0;
    }
    public static bool StickDown(){
        return Input.GetAxis("Horizontal1") < 0;
    }
    public static bool StickRight(){
        return Input.GetAxis("Vertical1") > 0;
    }
    public static bool StickLeft(){
        return Input.GetAxis("Vertical1") < 0;
    }
    

}