using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialContoroller : MonoBehaviour
{
    [SerializeField] private GameObject tutorial_Canvas;
    [SerializeField] private GameObject tutorial1;
    [SerializeField] private GameObject tutorial2;

    void OnEnable(){
        StartCoroutine(CheckKey());
    }

    IEnumerator CheckKey(){
        while(true){
        if(KeyDef.Right() && tutorial_Canvas.activeSelf == true){
            if(tutorial1.activeSelf){
                tutorial1.SetActive(false);
                tutorial2.SetActive(true);
                yield return new WaitForSeconds(0.5f);
            }
            else{
                tutorial1.SetActive(true);
                tutorial2.SetActive(false);
                yield return new WaitForSeconds(0.5f);
            }
        }
        if(KeyDef.Left() && tutorial_Canvas.activeSelf == true){
            yield return new WaitForSeconds(0.5f);
            tutorial_Canvas.SetActive(false);
        }
        yield return null;
        }
    }
}
