using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goul : MonoBehaviour
{

    GameObject ball;//ballを取得
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "ball")
        {
            Scene scene = SceneManager.GetActiveScene();//今のシーン名を取得

            if ((int.Parse(scene.name)+1) <= 5)
            {
                SceneManager.LoadScene((int.Parse(scene.name)+1).ToString());//現在のステージ数に１を足しロードする
            }
            else if((int.Parse(scene.name)+1) >= 6)
            {
                SceneManager.LoadScene("Clear");
            }
        }
    }
}
