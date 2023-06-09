using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] private Image startbutton;
    [SerializeField] private GameObject tutorial;
    private float alpha; 

    void Start(){
        alpha = startbutton.color.a;
        StartCoroutine(BecomeDark_Light());
    }

    void Update(){
        if(KeyDef.Right()  && tutorial.activeSelf == false){
            OnClickStart();
        }
        if(KeyDef.Left() && tutorial.activeSelf == false){
            StartCoroutine(Tutorial());
        }
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
    }

    IEnumerator Tutorial(){
        yield return new WaitForSeconds(0.5f);
        tutorial.SetActive(true);
    }

    public void OnClickStart(){
       SceneManager.LoadScene("Game2Scene");
    }
}
