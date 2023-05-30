using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickStart(){ //画面に表示されたボタンをマウスでクリックしたら
        SceneManager.LoadScene("StartScene");
    }

    void Update() {
        // if(Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0)
        //     || Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1)
        //     || Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Joystick2Button2)
        //     || Input.GetKey(KeyCode.Joystick1Button3) || Input.GetKey(KeyCode.Joystick2Button3)
        //     || Input.GetKey(KeyCode.Joystick1Button10) || Input.GetKey(KeyCode.Joystick2Button10)
        //     || Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.Joystick2Button11)
        //     || Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.Joystick2Button5)
        //     || Input.GetKey(KeyCode.Joystick1Button5) || Input.GetKey(KeyCode.Joystick2Button4)){

        if((Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0)) // A,B,X,Yいずれかのボタンを押したら
            || (Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1))
            || (Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Joystick2Button2))
            || (Input.GetKey(KeyCode.Joystick1Button3) || Input.GetKey(KeyCode.Joystick2Button3))){
            
            SceneManager.LoadScene("StartScene");
        }
    }
}
