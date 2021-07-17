using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IshiharaOption : MonoBehaviour
{
    private static int numberCorrect = 0;
    private static int numberIncorrect = 0;

    public void correctDetected()
    {
        numberCorrect++;
    }

    public void incorrectDetected()
    {
        numberIncorrect++;
    }

    public static int returnNumCorrect() {
        return numberCorrect;
    }

    public static int returnNumIncorrect() {
        return numberIncorrect;
    }
}
