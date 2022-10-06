using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageSelect : MonoBehaviour
{
    public void Stage1Select()
    {
        SceneManager.LoadScene("1");
    }
    public void Stage2Select()
    {
        SceneManager.LoadScene("2");
    }
    public void Stage3Select()
    {
        SceneManager.LoadScene("3");
    }
    public void Stage4Select()
    {
        SceneManager.LoadScene("4");
    }
    public void Stage5Select()
    {
        SceneManager.LoadScene("5");
    }
    public void Back()
    {
        SceneManager.LoadScene("menu");
    }
}
