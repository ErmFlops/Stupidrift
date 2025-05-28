using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
