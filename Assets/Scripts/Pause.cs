using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Pause : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject tutorial;

    [SerializeField] private GameObject advertise;
    [SerializeField] private GameObject advertisementBtn;
    [SerializeField] private GameObject map;
    [SerializeField] private TextMeshProUGUI uiText;
    private bool isRight = false;
    private bool isOpenAd = false;
    public static bool watchedAd = false;

    private bool isLeft;

    void Start(){
        isLeft = false;
        isRight = false;
    }

    void Update(){
        if(KeyDef.Left() && !pausePanel.activeSelf){
            StartCoroutine(OpenPause());
        }
    }
    IEnumerator OpenPause(){
        yield return new WaitForSeconds(0.5f);
        OnClickLeftArrow();

        while(pausePanel.activeSelf){
            yield return null;
            if(KeyDef.L()){ 
                yield return new WaitForSeconds(0.5f);
                OnClick_Lbtn();
            }
            if(KeyDef.R()){ 
                yield return new WaitForSeconds(0.5f);
                OnClick_Rbtn();
            }
            if(KeyDef.Right() && !watchedAd && !tutorial.activeSelf){
                Debug.Log("open map");
                yield return new WaitForSeconds(0.5f);
                StartCoroutine(OpenMapCorutine());
            }
        }
         
    }
    public void OnClickLeftArrow(){
        pausePanel.SetActive(true);
    }
    // Giveup
    public void OnClick_Lbtn(){
        timer.Resume();
        pausePanel.SetActive(false);
        SceneManager.LoadScene("StartScene");
    }

    // Resume
    public void OnClick_Rbtn(){
        timer.Resume();
        pausePanel.SetActive(false);
    }

    IEnumerator OpenMapCorutine()
    {
        if (!isRight)
        {
            isRight = true;
            if (!isOpenAd)
            {
                isOpenAd = true;
                advertise.SetActive(true); // https://www.irasutoya.com/2018/03/blog-post_618.html
                uiText.text = "5";
                yield return new WaitForSeconds(1f);
                uiText.text = "4";
                yield return new WaitForSeconds(1f);
                uiText.text = "3";
                yield return new WaitForSeconds(1f);
                uiText.text = "2";
                yield return new WaitForSeconds(1f);
                advertisementBtn.SetActive(true);
                isRight = false;
            }
            else
            {
                advertise.SetActive(false);
                advertisementBtn.SetActive(false);
                map.SetActive(true);
                watchedAd = true;
                isRight = false;
                // 広告表示後に自動でゲームスタート
                timer.Resume();
                pausePanel.SetActive(false);
            }
        }
    }
}
