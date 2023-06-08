using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialContoroller : MonoBehaviour
{
    [SerializeField] private GameObject tutorial_Canvas;
    [SerializeField] private GameObject tutorial1;
    [SerializeField] private GameObject tutorial2;
    void Update()
    {
        if(KeyDef.Right()){
            if(tutorial1.activeSelf){
                tutorial1.SetActive(false);
                tutorial2.SetActive(true);
            }
            else{
                tutorial1.SetActive(true);
                tutorial2.SetActive(false);
            }
        }
        if(KeyDef.Left()){
            tutorial_Canvas.SetActive(false);
        }

        
    }
}
