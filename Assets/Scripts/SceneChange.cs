using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public GameObject next_btn;
    public string scene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
