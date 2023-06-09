using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    Transform tf; //Main CameraのTransform
    Camera cam; //Main CameraのCamera
    Rigidbody hrb; //Human（親オブジェクト）のRigidbody
    float speed;
    float jumpPower;
    private bool isGround;
    [SerializeField] private GameObject pause;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを取得する。
        cam = this.gameObject.GetComponent<Camera>(); //Main CameraのCameraを取得する。
        hrb = transform.parent.gameObject.GetComponent<Rigidbody>(); //Human（親オブジェクト）のRigidbodyを取得する。
        speed = 2.0f;
        jumpPower = 4.0f;
        isGround = true;
    }

    void FixedUpdate()
    {

        //Projectごとのジョイコンの接続順によってJoystick1とJoystick2が定義されるので
        //edit>project settingsの設定確認をするように
        // if (Input.GetAxis("Horizontal1") != 0)
        if(KeyDef.StickUp() || KeyDef.StickDown())
        {

            //以下ジョイコンRの場合
            //横持ちのときの上下のスティックが反応
            // スティック操作時, 下(A)ボタンの押下の有無で, 速度を変える
            //if (Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0))
            if(KeyDef.Down())
            {
                //ジョイコンLの横持ちの時の下ボタンの反応を確認 or ジョイコンRのAボタン
                speed = 6.0f;
                //Debug.Log("加速");           
            }
            else
            {
                speed = 2.0f;
                //Debug.Log("通常");           
            }

            if(pause.activeSelf){ //ポーズ中なら
                speed = 0.0f;
            }

            // スティックの倒す向きで動く方向を変える
            //if (Input.GetAxis("Horizontal1") < 0)
            if(KeyDef.StickUp())
            {
                hrb.position = hrb.position + (transform.forward * Time.deltaTime * speed); //人を前進させる。
                                                                                            //Debug.Log("上"+Input.GetAxis("Horizontal1"));
            }
            else
            {
                hrb.position = hrb.position - (transform.forward * Time.deltaTime * speed); //人を後ずさりさせる。
                                                                                            //Debug.Log("下"+Input.GetAxis("Horizontal1"));
            }
        }
        //if (Input.GetAxis("Vertical1") != 0)
        if(KeyDef.StickLeft() || KeyDef.StickRight())
        {
            //横持ちのときの左右のスティックが反応

            // スティック操作時, 下(A)ボタンの押下の有無で, 速度を変える
            //if (Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0))
            if(KeyDef.Down())
            {
                //ジョイコンLの横持ちの時の下ボタンの反応を確認 or ジョイコンRのAボタン
                speed = 6.0f;
                //Debug.Log("加速");           
            }
            else
            {
                speed = 2.0f;
                //Debug.Log("通常");           
            }

            if(pause.activeSelf){ //ポーズ中なら
                speed = 0.0f;
            }

            // スティックの倒す向きで動く方向を変える
            //if (Input.GetAxis("Vertical1") < 0)
            if(KeyDef.StickLeft())
            {
                hrb.position = hrb.position - (transform.right * Time.deltaTime * speed); //人を左へカニ歩きさせる。
                                                                                          //Debug.Log("左"+Input.GetAxis("Vertical1"));
            }
            else
            {
                hrb.position = hrb.position + (transform.right * Time.deltaTime * speed); //人を右へカニ歩きさせる。
                                                                                          //Debug.Log("右"+Input.GetAxis("Vertical1"));
            }
        }

        //if (!(Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.UpArrow)) //上キーが押されていれば
        if(KeyDef.StickUp())
        {
            hrb.position = hrb.position + (transform.forward * Time.deltaTime * speed); //人を前進させる。
        }
        //else if (!(Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.DownArrow)) //下キーが押されていれば
        else if(KeyDef.StickDown())
        {
            hrb.position = hrb.position - (transform.forward * Time.deltaTime * speed); //人を後ずさりさせる。
        }
        //if (!(Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.LeftArrow)) //左キーが押されていれば
        if(KeyDef.StickLeft())
        {
            hrb.position = hrb.position - (transform.right * Time.deltaTime * speed); //人を左へカニ歩きさせる。
        }
        //else if (!(Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.RightArrow)) //右キーが押されていれば
        else if(KeyDef.StickRight())
        {
            hrb.position = hrb.position + (transform.right * Time.deltaTime * speed); //人を右へカニ歩きさせる。
        }

        /*
        if(Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Joystick2Button0)){
            //ジョイコンLの横持ちの時の下ボタンの反応を確認 or ジョイコンRのAボタン
        }
        if(Input.GetKeyUp(KeyCode.Joystick1Button0) || Input.GetKeyUp(KeyCode.Joystick2Button0)){
            //ジョイコンLの横持ちの時の下ボタンの反応を確認 or ジョイコンRのAボタン
        }
        */

        //if (Input.GetKey(KeyCode.Joystick1Button1) || Input.GetKey(KeyCode.Joystick2Button1))
        if(KeyDef.Right())
        {
            //ジョイコンLの横持ちの時の右ボタンの反応を確認 or ジョイコンRのXボタン

        }
        //if (Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Joystick2Button2))
        if(KeyDef.Left())
        {
            //ジョイコンLの横持ちの時の左ボタンの反応を確認 or ジョイコンRのBボタン

        }
        //if (Input.GetKey(KeyCode.Joystick1Button3) || Input.GetKey(KeyCode.Joystick2Button3))
        if(KeyDef.Up())
        {
            //ジョイコンLの横持ちの時の上ボタンの反応を確認 or ジョイコンRのYボタン
            //Debug.Log("上押した");
            StartCoroutine("JumpCoroutine");
        }
        if (Input.GetKey(KeyCode.Joystick1Button10) || Input.GetKey(KeyCode.Joystick2Button10)
        || Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.Joystick2Button11))
        {
            //ジョイコンの接続順によってJoystick1とJoystick2が定義される
            //ジョイコンLのスティックの押し込みの反応を確認
            Debug.Log("スティック押し込んだ");
        }

        //以下視点移動
        //if (Input.GetKey(KeyCode.Joystick1Button4) || Input.GetKey(KeyCode.Joystick2Button5))
        if(KeyDef.L())
        {
            if(pause.activeSelf){
                StartCoroutine("PauseCoroutine");
            }else{
            //ジョイコンの接続順で変わるため、左右逆転するかもしれないです
            transform.Rotate(new Vector3(0.0f, -2.0f, 0.0f)); //カメラを左へ回転。
            }
        }
        //if (Input.GetKey(KeyCode.Joystick1Button5) || Input.GetKey(KeyCode.Joystick2Button4))
        if(KeyDef.R())
        {
            if(pause.activeSelf){
                StartCoroutine("PauseCoroutine");
            }else{
            //ジョイコンの接続順で変わるため、左右逆転するかもしれないです
            transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f)); //カメラを右へ回転。
            }
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow)) //左側のShiftと上キーが押されていれば
        {
            transform.Rotate(new Vector3(-2.0f, 0.0f, 0.0f)); //カメラを上へ回転。
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow)) //左側のShiftと下キーが押されていれば
        {
            transform.Rotate(new Vector3(2.0f, 0.0f, 0.0f)); //カメラを下へ回転。
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftArrow)) //左側のShiftと左キーが押されていれば
        {
            transform.Rotate(new Vector3(0.0f, -2.0f, 0.0f)); //カメラを左へ回転。
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow)) //左側のShiftと右キーが押されていれば
        {
            transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f)); //カメラを右へ回転。
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.R)) //左側のShiftとRキーが押されていれば
        {
            tf.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f); //カメラの回転をリセットする。
        }
    }
    /*
    void OnTriggerStay(Collider other){
        //if (other.gameObject.name == "Plane")
        //    isGround = true;
        Debug.Log(other.gameObject.name);
    }
    void OnTriggerExit(Collider other){
        //if (other.gameObject.name == "Plane")
        //   isGround = false;
        Debug.Log(other.gameObject.name);
    }
    */

    IEnumerator JumpCoroutine()
    {
        if (isGround)
        {
            isGround = false;
            hrb.AddForce(new Vector3(0.0f, jumpPower, 0.0f), ForceMode.Impulse);
            yield return new WaitForSeconds(3f);
            isGround = true;
        }
    }
    
    IEnumerator PauseCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
    }
}