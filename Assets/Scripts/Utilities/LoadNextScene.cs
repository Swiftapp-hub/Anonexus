using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class LoadNextScene : MonoBehaviour
{
    public string sceneName;

    // Signal receptor
    public void load()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(sceneName);
    }
}
