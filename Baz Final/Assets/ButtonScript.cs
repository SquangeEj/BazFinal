using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    public int scenetoload;
    public void restart()
    {
        SceneManager.LoadScene(scenetoload);
    }

}
