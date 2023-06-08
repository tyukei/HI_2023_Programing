using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDef
{
    public static bool Up()
    {
        return Input.GetKey(KeyCode.Joystick1Button3) || Input.GetKey(KeyCode.Joystick2Button3) || Input.GetKey(KeyCode.UpArrow);
    }
    public static bool Down()
    {
        return Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0) || Input.GetKey(KeyCode.DownArrow);
    }
    public static bool Right()
    {
        return Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1) || Input.GetKey(KeyCode.RightArrow);
    }
    public static bool Left()
    {
        return Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Joystick2Button2) || Input.GetKey(KeyCode.LeftArrow);
    }
    public static bool StickUp()
    {
        return Input.GetAxis("Horizontal1") > 0 || Input.GetAxis(KeyCode.W.ToString()) > 0;
    }
    public static bool StickDown()
    {
        return Input.GetAxis("Horizontal1") < 0 || Input.GetAxis(KeyCode.S.ToString()) < 0;
    }
    public static bool StickRight()
    {
        return Input.GetAxis("Vertical1") > 0 || Input.GetAxis(KeyCode.D.ToString()) > 0;
    }
    public static bool StickLeft()
    {
        return Input.GetAxis("Vertical1") < 0 || Input.GetAxis(KeyCode.A.ToString()) < 0;
    }
    public static bool L()
    {
        return Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.L);
    }
    public static bool R()
    {
        return Input.GetKey(KeyCode.Joystick1Button5) || Input.GetKey(KeyCode.K);
    }
    public static bool ALLStick()
    {
        return StickUp() || StickDown() || StickRight() || StickLeft();
    }
    public static bool ALLKey()
    {
        return Up() || Down() || Right() || Left() || StickUp() || StickDown() || StickRight() || StickLeft() || L() || R();
    }
}