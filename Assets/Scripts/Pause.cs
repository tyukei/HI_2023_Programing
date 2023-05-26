using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject pausePanel;
    
    void Update(){
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            OnClickLeftArrow();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.LeftArrow)){
            OnClickLeftRight();
        }
    }
    public void OnClickLeftArrow(){
        Instantiate(pausePanel);
        timer.Pause();
    }
    public void OnClickLeftRight(){
        timer.Resume();
        Destroy(pausePanel);
    }

}
