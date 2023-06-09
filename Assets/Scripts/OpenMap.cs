using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenMap : MonoBehaviour
{
    private bool isRight = false;
    private bool isOpenAd = false;
    public static bool watchedAd = false;
    [SerializeField] private GameObject advertisement;
    [SerializeField] private GameObject advertisementBtn;
    [SerializeField] private GameObject map;
    [SerializeField] private TextMeshProUGUI uiText;
    void Start(){
        isRight = false;
        isOpenAd = false;
        watchedAd = false;
    }

    void Update()
    {
        if (KeyDef.Right() && !watchedAd)
        {
            StartCoroutine(OpenMapCorutine());
        }
    }

    IEnumerator OpenMapCorutine()
    {
        if (!isRight)
        {
            isRight = true;
            if (!isOpenAd)
            {
                isOpenAd = true;
                advertisement.SetActive(true); // https://www.irasutoya.com/2018/03/blog-post_618.html
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
                advertisement.SetActive(false);
                advertisementBtn.SetActive(false);
                map.SetActive(true);
                watchedAd = true;
                isRight = false;
            }
        }
    }
}
