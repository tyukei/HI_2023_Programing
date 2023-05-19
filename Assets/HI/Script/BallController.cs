using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float speed = 3.0f;
 
    void Update()
    {
        // Wキー（前方移動）
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }
 
        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
 
        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }
 
        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }

        // ジョイコンの上下左右をボールの動きと対応させる->実際に動かせることを確認
        // しかしこれは3人称視点であるので, 1人称視点に直す必要がある
        // https://www.popii33.com/unity-first-person-camera/
        // 上記のURLを閲覧すると、1人称視点にはなったが、
        // 迷路などを作製していないので、自分の位置を見失う可能性あり
        // 流れとしては迷路作成してから、1人称視点にしたほうがよさそう
        // なお一度feature/tanakaにコミット&プルをしてからもう一回実行したら、
        // ArgumentException Input Axis Horizontal1 is not setupと出てきてエラーとなった
        /*
        if(Input.GetAxis("Horizontal1") != 0){

            //以下ジョイコンRの場合
            //横持ちのときの上下のスティックが反応
            if(Input.GetAxis("Horizontal1") < 0){
                Debug.Log("上"+Input.GetAxis("Horizontal1"));
            }
            else{
                Debug.Log("下"+Input.GetAxis("Horizontal1"));
            }
        }
        if(Input.GetAxis("Vertical1") != 0){
            //横持ちのときの左右のスティックが反応
            if(Input.GetAxis("Vertical1") < 0){
                Debug.Log("左"+Input.GetAxis("Vertical1"));
            }
            else{
                Debug.Log("右"+Input.GetAxis("Vertical1"));
            }
        }
        */
    }
}
