using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{

    public void NextLevel()
    {
        NextLevel(1, false);
    }

    public void NextLevel(int distance, bool fromStart)
    {
        if (fromStart) {
            SceneManager.LoadScene(distance);
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + distance);
        }

    }
}
