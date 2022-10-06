using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void GoSelect()
    {
        SceneManager.LoadScene("Stage select");
    }
    public void GoHow()
    {
        SceneManager.LoadScene("How");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
