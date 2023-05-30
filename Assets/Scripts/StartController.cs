using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] private Image startbutton;
    private float alpha; 

    void Start(){
        alpha = startbutton.color.a;
        StartCoroutine(BecomeDark_Light());
        StartCoroutine(StartButtonCoroutine());
    }

    IEnumerator BecomeDark_Light(){
        while(true){
            if(alpha <= 1){
                alpha += 0.05f;
                startbutton.color = new Color(1, 1, 1, alpha);
                yield return new WaitForSeconds(0.1f);
            }
            if(alpha >= 1){
                while(alpha > 0){
                    alpha -= 0.05f;
                    startbutton.color = new Color(1, 1, 1, alpha);
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
        yield break;
    }

    IEnumerator StartButtonCoroutine(){
        while(true){
            if(KeyDef.ALLKey()){
                OnClickStart();
            }
            yield return null;
        }
    }

    public void OnClickStart(){
       SceneManager.LoadScene("GameScene");
    }
}
