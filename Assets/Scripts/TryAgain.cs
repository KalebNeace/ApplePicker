using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadScene("__Scene_0");
     }
}

