using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class MainLoader : MonoBehaviour
{
    public GameObject text;

    private int firstLaunch = 0;

    // Start is called before the first frame update
    void Start()
    {
        firstLaunch = PlayerPrefs.GetInt(VarPrefs.FIRST_LAUNCH, 0);
        if (firstLaunch == 0) text.GetComponent<TextMeshProUGUI>().text = "Presente...";

        StartCoroutine(Launcher());
    }

    IEnumerator Launcher()
    {
        yield return new WaitForSeconds(4);

        if (firstLaunch == 0) SceneManager.LoadSceneAsync(SceneName.MAIN_CINEMATIQUE);
        else SceneManager.LoadSceneAsync(SceneName.HOME);
    }
}
