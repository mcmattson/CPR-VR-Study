using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitModule : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene("PostAssesment");
    }

}