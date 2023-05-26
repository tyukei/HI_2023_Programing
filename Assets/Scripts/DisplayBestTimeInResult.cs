using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestTimeInResult : MonoBehaviour
{
    public static float goaltime;
    public static float besttime;
    
    // Start is called before the first frame update
    void Start()
    {
        goaltime = PlayerPrefs.GetFloat("TIME");
        besttime = PlayerPrefs.GetFloat("BESTTIME", float.PositiveInfinity);//今までのベストタイム
        if(besttime == 0){
            besttime = float.PositiveInfinity;
        }
    }

    void OnDestroy(){
        PlayerPrefs.SetFloat("BESTTIME", besttime);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        Text uiText = GetComponent<Text> ();

        if(goaltime < besttime){ //新記録を更新していたら
            besttime = goaltime;
        }else{ //更新していなかったら
            //何もしない
        }

        float t =  Mathf.Floor(besttime * 100) / 100;   //ミリ秒表示
        uiText.text = "BESTTIME : " + t;
    }
}
