using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTimeInResult : MonoBehaviour
{
    public static float goaltime;
    
    // Start is called before the first frame update
    void Start()
    {
        goaltime = PlayerPrefs.GetFloat("TIME");
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.Floor(goaltime * 100) / 100;
        Text uiText = GetComponent<Text> ();
        uiText.text = "TIME : " + t;
    }
}
