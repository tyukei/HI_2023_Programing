using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResetBestTIme : MonoBehaviour
{
    static bool doReset = false;

    // Start is called before the first frame update
    public void OnClickStart(){ //画面に表示されたボタンをマウスでクリックしたら
        Debug.Log("ぼたんを押したよ");
        doReset = true;
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.Joystick2Button5)) // R, Lボタンを同時押ししたら
        && (Input.GetKey(KeyCode.Joystick1Button5) || Input.GetKey(KeyCode.Joystick2Button4))){
            Debug.Log("LR押したよ");
            doReset = true;
        }

        if(doReset){ // マウスでのクリックかR+Lでリセットを実行
            PlayerPrefs.DeleteKey("BESTTIME");
            TextMeshProUGUI uiText = GetComponent<TextMeshProUGUI>();
            uiText.text = "Already RESET!";
            Debug.Log("りせっとしたよ");
            doReset = false;
        }
        else{
            // Debug.Log("りせっとしてないよ");
        }
    }
}
