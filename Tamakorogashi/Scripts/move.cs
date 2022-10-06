using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    GameObject mainCamera;
    public float m_Thrust = 20f;
    bool canJump = true;
    Scene scene;
    Vector3 FirstPos;
    // Start is called before the first frame update
    void Start()
    {
        FirstPos = transform.position;//初期位置を取得
        mainCamera = GameObject.Find("Main Camera");
    }
    void FixedUpdate()
    {
        //Rigidbodyを取得する
        Rigidbody rb = this.GetComponent<Rigidbody>();
        //wキーで前方向に力を加える
        if (Input.GetKey("w"))
        {
            Vector3 force = mainCamera.transform.forward * 7.5f;
            rb.AddForce(force,ForceMode.Force);//addforceで力を加える
        }
        //aキーで左方向に力を加える
        if (Input.GetKey("a"))
        {
            Vector3 force = -(mainCamera.transform.right) * 7.5f;
            rb.AddForce(force,ForceMode.Force);
        }
        //sキーで後ろ方向に力を加える
        if (Input.GetKey("s"))
        {
            Vector3 force = -(mainCamera.transform.forward) * 7.5f;
            rb.AddForce(force,ForceMode.Force);
        }
        //dキーで右方向に力を加える
        if (Input.GetKey("d"))
        {
            Vector3 force = mainCamera.transform.right * 7.5f;
            rb.AddForce(force,ForceMode.Force);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //spaceキーでジャンプ
            if(canJump)
            {
                canJump = false;
                Rigidbody rb = this.GetComponent<Rigidbody>();//Rigidbodyを取得する
                Vector3 force = new Vector3 (0.0f,400.0f,0.0f);//新しくVector3を定義する
                rb.AddForce(force,ForceMode.Force);//addforceで力を加える
                Invoke("ChangeJumpState", 1.5f);//1.5秒間ChangeJumpState関数を止める
            }
        }
        //rキーでシーンをリセット
        if (Input.GetKeyDown("r"))
        {
            scene = SceneManager.GetActiveScene();//今のシーン名を取得
            SceneManager.LoadScene(scene.name);//取得したシーンをロード
        }
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("menu");
        }
    }
    void ChangeJumpState()
    {
        canJump = true;
    }
    void OnTriggerEnter(Collider collider)
    {
        //UnderlineにふれたときResetPos関数を呼び出す
        if (collider.gameObject.name == "Underline")
        {
            ResetPos();
        }
    }
    void ResetPos()
    {
        transform.position = FirstPos;//座標を初期位置に戻す
        transform.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);///加速度を0にする
    }
}
