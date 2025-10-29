using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene2_3 : MonoBehaviour
{
    public GameObject next_btn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene()
    {
        SceneManager.LoadScene("Third_Scene");
    }
}
