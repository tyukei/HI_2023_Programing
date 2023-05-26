using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void OnClickStart(){
       SceneManager.LoadScene("GameScene");
    }

    public void JoystickButton0(){
        SceneManager.LoadScene("GameScene");
    }

    

    void FixedUpDate(){
        /*if(Input.GetKey(KeyCode.Joystick1Button10) || Input.GetKey(KeyCode.Joystick2Button10)
        || Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.Joystick2Button11)){
          //ジョイコンの接続順によってJoystick1とJoystick2が定義される
          //ジョイコンLのスティックの押し込みの反応を確認
          Debug.Log("スティック押し込んだ");
          SceneManager.LoadScene("GameScene");
        }*/
    }
}
