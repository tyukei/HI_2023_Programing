using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    private bool isRight = false;
    private bool isOpenAd = false;
    public static bool watchedAd = false;
    [SerializeField] private GameObject advertisement;
    [SerializeField] private GameObject advertisementBtn;
    [SerializeField] private GameObject hideMap;
    [SerializeField] private GameObject map;
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
                advertisement.SetActive(true);
                yield return new WaitForSeconds(3f);
                advertisementBtn.SetActive(true);
                isRight = false;
            }
            else
            {
                advertisement.SetActive(false);
                advertisementBtn.SetActive(false);
                hideMap.SetActive(false);
                map.SetActive(true);
                watchedAd = true;
                isRight = false;
            }
        }
    }
}
