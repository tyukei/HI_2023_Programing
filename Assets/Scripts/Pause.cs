using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject pausePanel;

    void Update(){
        if(KeyDef.Left()){
            OnClickLeftArrow();
        }

        if(KeyDef.R() && KeyDef.L()){
            OnClickLeftRight();
        }
    }
    public void OnClickLeftArrow(){
        if(GameObject.FindGameObjectsWithTag("Pause").Length > 0){
            return;
        }
        Instantiate(pausePanel);
        timer.Pause();
    }
    public void OnClickLeftRight(){
        timer.Resume();
        // destory all Pause_Canvas(Clone)
        GameObject[] pauseCanvas = GameObject.FindGameObjectsWithTag("Pause");
        foreach(GameObject obj in pauseCanvas){
            Destroy(obj);
        }
    }

}
