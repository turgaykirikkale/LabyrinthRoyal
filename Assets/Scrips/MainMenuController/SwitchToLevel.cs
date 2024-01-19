using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchToLevel : MonoBehaviour
{

    public static void SwitchToSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
