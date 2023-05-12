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
        || Input.GetKey(KeyCode.Joystick2Button10) || Input.GetKey(KeyCode.Joystick2Button11)){
            //ジョイコンの接続順によってJoystick1とJoystick2が定義される
            //ジョイコンLのスティックの押し込みの反応を確認
            Debug.Log("スティック押し込んだ");
        }
        if(Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.Joystick2Button5)
        || Input.GetKey(KeyCode.Joystick2Button4) || Input.GetKey(KeyCode.Joystick2Button5)){
            //ジョイコンの接続順によってJoystick1とJoystick2が定義される
            //ジョイコンLのスティックの押し込みの反応を確認
            Debug.Log("スティック押し込んだ");
        }


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
        

    }

}
