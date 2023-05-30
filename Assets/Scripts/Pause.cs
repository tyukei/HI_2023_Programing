using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject pausePanel;

    private bool isLeft;

    void Start(){
        isLeft = false;
    }

    void Update(){
        if(KeyDef.Left()){
            isLeft = true;
            OnClickLeftArrow();
        }

        if(isLeft == true){
            if(KeyDef.R() && KeyDef.L()){
                isLeft = false;
                OnClickLR();

            }

            if(KeyDef.Right()){
                isLeft = false;
                OnClickRightArrow();
            }

        }
    }
    public void OnClickLeftArrow(){
        if(GameObject.FindGameObjectsWithTag("Pause").Length > 0){
            return;
        }
        Instantiate(pausePanel);
        timer.Pause();
    }
    public void OnClickLR(){
        timer.Resume();
        // destory all Pause_Canvas(Clone)
        GameObject[] pauseCanvas = GameObject.FindGameObjectsWithTag("Pause");
        foreach(GameObject obj in pauseCanvas){
            Destroy(obj);
        }
        SceneManager.LoadScene("StartScene");
    }
    public void OnClickRightArrow(){
        timer.Resume();
        // destory all Pause_Canvas(Clone)
        GameObject[] pauseCanvas = GameObject.FindGameObjectsWithTag("Pause");
        foreach(GameObject obj in pauseCanvas){
            Destroy(obj);
        }
    }
}
