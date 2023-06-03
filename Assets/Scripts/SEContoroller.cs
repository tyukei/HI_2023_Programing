using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEContoroller : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip walkSE;
    [SerializeField] AudioClip jumpSE;
    [SerializeField] AudioClip dropSE;
    [SerializeField] AudioClip clearSE;
    private static bool isSE = false;

    public void PlayWalkSE()
    {
        if(isSE) return;
        StartCoroutine(PlaySE(walkSE));
    }

    public void PlayJumpSE()
    {
        if(isSE) return;
        StartCoroutine(PlaySE(jumpSE));
    }

    public void PlayDropSE()
    {
        if(isSE) return;
        StartCoroutine(PlaySE(dropSE));
    }

    public void PlayClearSE()
    {
        if(isSE) return;
        StartCoroutine(PlaySE(clearSE));
    }
    
    IEnumerator PlaySE(AudioClip clip)
    {
        Debug.Log("PlaySE");
        isSE = true;
        audioSource.PlayOneShot(clip);
        yield return new WaitForSeconds(clip.length);
        isSE = false;
    }
}
