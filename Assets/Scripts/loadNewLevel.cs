using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNewLevel : MonoBehaviour
{
    public int levelLength;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadLevel());
    }

    IEnumerator loadLevel()
    {
        yield return new WaitForSeconds(levelLength);
        newLevel();
    }

    public void newLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
