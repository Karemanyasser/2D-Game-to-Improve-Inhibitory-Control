using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene1_2 : MonoBehaviour
{
    public GameObject next_btn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene()
    {
        SceneManager.LoadScene("Second_Scene");
    }
}