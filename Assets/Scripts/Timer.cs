using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        // time = PlayerPrefs.GetFloat("TIME", 0); //TIMEという名前で保存されていれば読み込み、されていなければ0を代入
    }

    void OnDestroy(){
        PlayerPrefs.SetFloat("TIME", time);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Goal.goal == false){
        time += Time.deltaTime;
        //}

        // float t = Mathf.FloorToInt(time);        //秒表示
        float t =  Mathf.Floor(time * 100) / 100;   //ミリ秒表示
        Text uiText = GetComponent<Text> ();
        uiText.text = "Time : " + t;
    }

    public void Pause(){
        Time.timeScale = 0;
    }
    public void Resume(){
        Time.timeScale = 1;
    }
}
