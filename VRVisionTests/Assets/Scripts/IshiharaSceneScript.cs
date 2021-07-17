using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IshiharaSceneScript : MonoBehaviour
{
    public GameObject img_1;
    public GameObject img_2;
    public GameObject img_3;
    public GameObject img_4;
    public GameObject img_5;
    public GameObject img_6;
    public GameObject img_7;
    public GameObject img_8;
    public GameObject img_9;
    public GameObject img_10;
    public GameObject img_11;
    public GameObject img_12;
    public GameObject img_13;
    public GameObject img_14;
    public GameObject img_15;
    public GameObject img_16;
    public GameObject img_17;

    public GameObject one_1;
    public GameObject one_2;

    public GameObject two_1;
    public GameObject two_2;
    public GameObject two_3;

    public GameObject three_1;
    public GameObject three_2;
    public GameObject three_3;

    public GameObject four_1;
    public GameObject four_2;
    public GameObject four_3;

    public GameObject five_1;
    public GameObject five_2;
    public GameObject five_3;

    public GameObject six_1;
    public GameObject six_2;
    public GameObject six_3;

    public GameObject seven_1;
    public GameObject seven_2;
    public GameObject seven_3;

    public GameObject eight_1;
    public GameObject eight_2;

    public GameObject nine_1;
    public GameObject nine_2;

    public GameObject ten_1;
    public GameObject ten_2;

    public GameObject eleven_1;
    public GameObject eleven_2;

    public GameObject twelve_1;
    public GameObject twelve_2;

    public GameObject thirteen_1;
    public GameObject thirteen_2;

    public GameObject fourteen_1;
    public GameObject fourteen_2;

    public GameObject fifteen_1;
    public GameObject fifteen_2;

    public GameObject sixteen_1;
    public GameObject sixteen_2;
    public GameObject sixteen_3;
    public GameObject sixteen_4;

    public GameObject seventeen_1;
    public GameObject seventeen_2;
    public GameObject seventeen_3;
    public GameObject seventeen_4; 

    public GameObject whichNumber;
    public GameObject mainMenuUI;
    public Text mainMenuText;
    public Text numCorrect;
    public Text numIncorrect;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Experiment());
    }

    IEnumerator Experiment()
    {
        mainMenuUI.SetActive(false);
        mainMenuText.enabled = false;
        // Set later images to non-active
        img_2.SetActive(false);
        img_3.SetActive(false);
        img_4.SetActive(false);
        img_5.SetActive(false);
        img_6.SetActive(false);
        img_7.SetActive(false);
        img_8.SetActive(false);
        img_9.SetActive(false);
        img_10.SetActive(false);
        img_11.SetActive(false);
        img_12.SetActive(false);
        img_13.SetActive(false);
        img_14.SetActive(false);
        img_15.SetActive(false);
        img_16.SetActive(false);
        img_17.SetActive(false);

        // Set UI buttons to nonactive
        one_1.SetActive(false);
        one_2.SetActive(false);
        two_1.SetActive(false);
        two_2.SetActive(false);
        two_3.SetActive(false);
        three_1.SetActive(false);
        three_2.SetActive(false);
        three_3.SetActive(false);
        four_1.SetActive(false);
        four_2.SetActive(false);
        four_3.SetActive(false);
        five_1.SetActive(false);
        five_2.SetActive(false);
        five_3.SetActive(false);
        six_1.SetActive(false);
        six_2.SetActive(false);
        six_3.SetActive(false);
        seven_1.SetActive(false);
        seven_2.SetActive(false);
        seven_3.SetActive(false);
        eight_1.SetActive(false);
        eight_2.SetActive(false);
        nine_1.SetActive(false);
        nine_2.SetActive(false);
        ten_1.SetActive(false);
        ten_2.SetActive(false);
        eleven_1.SetActive(false);
        eleven_2.SetActive(false);
        twelve_1.SetActive(false);
        twelve_2.SetActive(false);
        thirteen_1.SetActive(false);
        thirteen_2.SetActive(false);
        fourteen_1.SetActive(false);
        fourteen_2.SetActive(false);
        fifteen_1.SetActive(false);
        fifteen_2.SetActive(false);
        sixteen_1.SetActive(false);
        sixteen_2.SetActive(false);
        sixteen_3.SetActive(false);
        sixteen_4.SetActive(false);
        seventeen_1.SetActive(false);
        seventeen_2.SetActive(false);
        seventeen_3.SetActive(false);
        seventeen_4.SetActive(false); 
        whichNumber.SetActive(false);
        numIncorrect.enabled = false;
        numCorrect.enabled = false;

        yield return new WaitForSeconds(2.0f);
        whichNumber.SetActive(true);
        one_1.SetActive(true);
        one_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        one_1.SetActive(false);
        one_2.SetActive(false);
        img_1.SetActive(false);
        img_2.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        two_1.SetActive(true);
        two_2.SetActive(true);
        two_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        two_1.SetActive(false);
        two_2.SetActive(false);
        two_3.SetActive(false);
        img_2.SetActive(false);
        img_3.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        three_1.SetActive(true);
        three_2.SetActive(true);
        three_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        three_1.SetActive(false);
        three_2.SetActive(false);
        three_3.SetActive(false);
        img_3.SetActive(false);
        img_4.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        four_1.SetActive(true);
        four_2.SetActive(true);
        four_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        four_1.SetActive(false);
        four_2.SetActive(false);
        four_3.SetActive(false);
        img_4.SetActive(false);
        img_5.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        five_1.SetActive(true);
        five_2.SetActive(true);
        five_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        five_1.SetActive(false);
        five_2.SetActive(false);
        five_3.SetActive(false);
        img_5.SetActive(false);
        img_6.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        six_1.SetActive(true);
        six_2.SetActive(true);
        six_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        six_1.SetActive(false);
        six_2.SetActive(false);
        six_3.SetActive(false);
        img_6.SetActive(false);
        img_7.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        seven_1.SetActive(true);
        seven_2.SetActive(true);
        seven_3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        seven_1.SetActive(false);
        seven_2.SetActive(false);
        seven_3.SetActive(false);
        img_7.SetActive(false);
        img_8.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        eight_1.SetActive(true);
        eight_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        eight_1.SetActive(false);
        eight_2.SetActive(false);
        img_8.SetActive(false);
        img_9.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        nine_1.SetActive(true);
        nine_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        nine_1.SetActive(false);
        nine_2.SetActive(false);
        img_9.SetActive(false);
        img_10.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        ten_1.SetActive(true);
        ten_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        ten_1.SetActive(false);
        ten_2.SetActive(false);
        img_10.SetActive(false);
        img_11.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        eleven_1.SetActive(true);
        eleven_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        eleven_1.SetActive(false);
        eleven_2.SetActive(false);
        img_11.SetActive(false);
        img_12.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        twelve_1.SetActive(true);
        twelve_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        twelve_1.SetActive(false);
        twelve_2.SetActive(false);
        img_12.SetActive(false);
        img_13.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        thirteen_1.SetActive(true);
        thirteen_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        thirteen_1.SetActive(false);
        thirteen_2.SetActive(false);
        img_13.SetActive(false);
        img_14.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        fourteen_1.SetActive(true);
        fourteen_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        fourteen_1.SetActive(false);
        fourteen_2.SetActive(false);
        img_14.SetActive(false);
        img_15.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        fifteen_1.SetActive(true);
        fifteen_2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        fifteen_1.SetActive(false);
        fifteen_2.SetActive(false);
        img_15.SetActive(false);
        img_16.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        sixteen_1.SetActive(true);
        sixteen_2.SetActive(true);
        sixteen_3.SetActive(true);
        sixteen_4.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        whichNumber.SetActive(false);
        sixteen_1.SetActive(false);
        sixteen_2.SetActive(false);
        sixteen_3.SetActive(false);
        sixteen_4.SetActive(false);
        img_16.SetActive(false);
        img_17.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        whichNumber.SetActive(true);
        seventeen_1.SetActive(true);
        seventeen_2.SetActive(true);
        seventeen_3.SetActive(true);
        seventeen_4.SetActive(true); 
        yield return new WaitForSeconds(4.0f);
        img_17.SetActive(false);
        whichNumber.SetActive(false);
        seventeen_1.SetActive(false);
        seventeen_2.SetActive(false);
        seventeen_3.SetActive(false);
        seventeen_4.SetActive(false); 
        // After tests are over
        numCorrect.enabled = true;
        numCorrect.text = $"Number Correct: {IshiharaOption.returnNumCorrect().ToString()} out of 17";
        numIncorrect.enabled = true;
        numIncorrect.text = $"Number Incorrect: {IshiharaOption.returnNumIncorrect().ToString()} out of 17";
        mainMenuUI.SetActive(true);
        mainMenuText.enabled = true;
    }
}
