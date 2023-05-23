using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_detect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        //ボールにぶつかったとき
        //Debug.Log("ぶつかった！");
        //Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Player"){
            Debug.Log("Hit");
            SceneManager.LoadScene("ClearScene");
        }
    }
}
