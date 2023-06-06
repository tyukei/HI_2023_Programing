using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamp_detect : MonoBehaviour
{

    public Image fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    private bool fadeout;          //フェードアウトのフラグ変数
    
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        alpha = fadealpha.color.a;
        fadeout = true;  
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player"){
            //transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
            StartCoroutine(BecomeDark_Light());
        }
    }

    IEnumerator BecomeDark_Light()
    {
        if(fadeout == true){
            int black_time = 10;
            fadeout = false;
            audioSource.PlayOneShot(audioSource.clip);
            while(alpha <= 1){
                alpha += 0.1f;
                fadealpha.color = new Color(0, 0, 0, alpha);
                yield return new WaitForSeconds(0.1f);
            }
            while(black_time > 0){
                black_time -= 1;
                yield return new WaitForSeconds(0.1f);
            }
            while(alpha > 0){
                alpha -= 0.01f;
                fadealpha.color = new Color(0, 0, 0, alpha);
                yield return new WaitForSeconds(0.1f);
            }
            fadeout = true;
            yield break;
        }
    }
}
