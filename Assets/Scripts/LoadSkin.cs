using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSkin : MonoBehaviour
{
    // Start is called before the first frame update
     public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void paused()
    {
        Time.timeScale = 0;
    }

    public void resume()
    {
        Time.timeScale = 1;
    }
}
