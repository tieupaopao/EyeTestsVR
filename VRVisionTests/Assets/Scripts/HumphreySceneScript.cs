using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HumphreySceneScript : MonoBehaviour
{
    public Material centralMaterial;
    public Material cubeMaterial;
    
    public GameObject centralCube;
    public GameObject cube_2;
    public GameObject cube_3;
    public GameObject cube_4;
    public GameObject cube_5;
    public GameObject bottomCube;
    public GameObject cube_8;
    public GameObject left_Cube;
    public GameObject right_Cube;
    public GameObject top_Cube;

    // Main Menu Cube
    public GameObject mainMenuCube;

    // UI
    public GameObject instructions;
    public GameObject ready;
    public GameObject finishedTest;
    public GameObject mainMenuUI;
    public Text finalScore;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Experiment());
    }

    IEnumerator Experiment()
    {
        mainMenuCube.SetActive(false);
        ready.SetActive(false);
        finishedTest.SetActive(false);
        mainMenuUI.SetActive(false);
        finalScore.enabled = false;
        centralCube.SetActive(false);
        cube_2.SetActive(false);
        cube_3.SetActive(false);
        cube_4.SetActive(false);
        cube_5.SetActive(false);
        bottomCube.SetActive(false);
        cube_8.SetActive(false);
        left_Cube.SetActive(false);
        right_Cube.SetActive(false);
        top_Cube.SetActive(false);
        yield return new WaitForSeconds(20.0f);
        instructions.SetActive(false);
        ready.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        ready.SetActive(false);
        centralCube.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        centralMaterial.SetColor("_EmissionColor", Color.blue);
        yield return new WaitForSeconds(3.0f);
        cube_2.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cube_2.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        cube_3.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cube_3.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        cube_4.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cube_4.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        cube_5.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cube_5.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        bottomCube.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        bottomCube.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        cube_8.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        cube_8.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        left_Cube.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        left_Cube.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        right_Cube.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        right_Cube.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        top_Cube.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        top_Cube.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        centralCube.SetActive(false);
        finishedTest.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        finalScore.enabled = true;
        finalScore.text = $"Score: {CentralTargetClick.numberPinches().ToString()} out of 9";
        mainMenuUI.SetActive(true);
        mainMenuCube.SetActive(true);
    }
}
