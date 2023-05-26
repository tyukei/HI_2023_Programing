using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1)){
          //ジョイコンLの横持ちの時の右ボタンの反応を確認 or ジョイコンRのXボタン
          SceneManager.LoadScene("GameScene");
        }

    }
}
