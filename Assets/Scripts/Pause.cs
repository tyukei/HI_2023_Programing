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
            if(KeyDef.L()){ // KeyDef.R() && KeyDef.L() -> KeyDef.R() && KeyDef.L() -> KeyDef.L() 
                isLeft = false;
                OnClick_Lbtn();

            }

            if(KeyDef.R()){ // KeyDef.Right() -> KeyDef.Left() -> KeyDef.R() 
                isLeft = false;
                OnClick_Rbtn();
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
    // Giveup
    public void OnClick_Lbtn(){
        timer.Resume();
        // destory all Pause_Canvas(Clone)
        GameObject[] pauseCanvas = GameObject.FindGameObjectsWithTag("Pause");
        foreach(GameObject obj in pauseCanvas){
            Destroy(obj);
        }
        SceneManager.LoadScene("StartScene");
    }

    // Resume
    public void OnClick_Rbtn(){
        timer.Resume();
        // destory all Pause_Canvas(Clone)
        GameObject[] pauseCanvas = GameObject.FindGameObjectsWithTag("Pause");
        foreach(GameObject obj in pauseCanvas){
            Destroy(obj);
        }
    }
}
