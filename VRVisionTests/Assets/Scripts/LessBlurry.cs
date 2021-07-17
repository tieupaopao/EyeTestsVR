using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessBlurry : MonoBehaviour
{
    public static void decreaseBlurriness() {
        if (BoxBlur.Iterations > 0) {
            BoxBlur.Iterations--;
        }
        if (BoxBlur.DownRes > 0) {
            BoxBlur.DownRes--;
        }
    }
}
