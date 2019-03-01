using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverQuit : MonoBehaviour
{
    public void loadStart(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
