using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_Script : MonoBehaviour
{
    public string targetSceneName;

    public void SwitchScene() => SceneManager.LoadScene(targetSceneName);

}

