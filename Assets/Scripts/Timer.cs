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
    }

    // Update is called once per frame
    void Update()
    {
        //if(Goal.goal == false){
        time += Time.deltaTime;
        //}

        // float t = Mathf.FloorToInt(time);
        float t =  Mathf.Floor(time * 100) / 100;
        Text uiText = GetComponent<Text> ();
        uiText.text = "Time : " + t;
    }
}
