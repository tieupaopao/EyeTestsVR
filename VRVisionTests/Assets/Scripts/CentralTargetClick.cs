using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralTargetClick : MonoBehaviour
{
    private static int detectedPinches = 0;

    public void PinchDetected()
    {
        detectedPinches++;
    }

    public static int numberPinches() {
        return detectedPinches;
    }
}
