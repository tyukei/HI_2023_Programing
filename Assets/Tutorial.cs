using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject tutorial1;
    [SerializeField] private GameObject tutorial2;
    [SerializeField] private GameObject pause;
    private bool isTutorial = false;
    // Update is called once per frame
    void Update()
    {
        if(KeyDef.Left() && pause.activeSelf && !isTutorial){
            Debug.Log("Tutorial");
            StartCoroutine(OpenTutorial());
        }
    }
    IEnumerator OpenTutorial(){
        isTutorial = true;
        tutorial.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        while(tutorial.activeSelf){
            yield return null;
            if(KeyDef.Left()){
                Debug.Log("Left");
                yield return new WaitForSeconds(0.5f);
                tutorial.SetActive(false);
                isTutorial = false;
                yield break;
            }
            if(KeyDef.Right()){
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
        }
        
    }
}
