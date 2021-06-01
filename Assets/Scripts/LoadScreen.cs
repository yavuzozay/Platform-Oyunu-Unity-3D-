using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
 public void LoadGameScreen()
    {
        SceneManager.LoadScene(1);
    }
}
