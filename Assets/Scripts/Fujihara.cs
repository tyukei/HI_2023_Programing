using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fujihara : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0)){
            //ジョイコンLの横持ちの時の下ボタンの反応を確認 or ジョイコンRのAボタン
            Debug.Log("ボタン0おした");
        }
        if(Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1)){
            //ジョイコンLの横持ちの時の右ボタンの反応を確認 or ジョイコンRのXボタン
            Debug.Log("ボタン1おした");
        }
        if(Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Joystick2Button2)){
            //ジョイコンLの横持ちの時の左ボタンの反応を確認 or ジョイコンRのBボタン
            Debug.Log("ボタン2おした");
        }
        if(Input.GetKey(KeyCode.Joystick1Button3) || Input.GetKey(KeyCode.Joystick2Button3)){
            //ジョイコンLの横持ちの時の上ボタンの反応を確認 or ジョイコンRのYボタン
            Debug.Log("ボタン3おした");
        }
        if(Input.GetKey(KeyCode.Joystick1Button10) || Input.GetKey(KeyCode.Joystick2Button10)
        || Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.Joystick2Button11)){
            //ジョイコンの接続順によってJoystick1とJoystick2が定義される
            //ジョイコンLのスティックの押し込みの反応を確認
            Debug.Log("スティック押し込んだ");
        }
        if(Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.Joystick2Button5)){
            //ジョイコンの接続順で変わるため、左右逆転するかもしれないです
            Debug.Log("Lボタン押した");
        }
        if(Input.GetKey(KeyCode.Joystick1Button5) || Input.GetKey(KeyCode.Joystick2Button4)){
            //ジョイコンの接続順で変わるため、左右逆転するかもしれないです
            Debug.Log("Rボタン押した");
        }

        //Projectごとのジョイコンの接続順によってJoystick1とJoystick2が定義されるので
        //edit>project settingsの設定確認をするように
        if(Input.GetAxis("Horizontal1") != 0){

            //以下ジョイコンRの場合
            //横持ちのときの上下のスティックが反応
            if(Input.GetAxis("Horizontal1") < 0){
                
                Debug.Log("上"+Input.GetAxis("Horizontal1"));
            }
            else{
                
                Debug.Log("下"+Input.GetAxis("Horizontal1"));
            }
        }
        if(Input.GetAxis("Vertical1") != 0){
            //横持ちのときの左右のスティックが反応
            if(Input.GetAxis("Vertical1") < 0){
                
                Debug.Log("左"+Input.GetAxis("Vertical1"));
            }
            else{
                
                Debug.Log("右"+Input.GetAxis("Vertical1"));
            }
        }

        //SwitchControllerAnyKeyDown();
        

    }
    /*private void SwitchControllerAnyKeyDown(){
        if (Input.anyKeyDown) {
            foreach (SwitchController code in Enum.GetValues(typeof(SwitchController))) {
                if (Input.GetKeyDown ((KeyCode)code)) Debug.Log(code);
            }
        }
    }*/

}

public enum SwitchController{
    A = 350,
    B = 352,
    X = 351,
    Y = 353,
    UpArrow = 372,
    LeftArrow = 370,
    RightArrow = 373,
    DownArrow = 371,
    LStick = 380,
    RStick = 361,
    L = 384,
    R = 364,
    ZL = 385,
    ZR = 365,
    LeftSL = 374,
    LeftSR = 375,
    RightSL = 354,
    RightSR = 355,
    Minus = 378,
    Plus = 359,
    HOME = 362,
    Capture = 383 
}
