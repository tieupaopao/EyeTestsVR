using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NearSimScript : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("NearSimulation");
    }
}
